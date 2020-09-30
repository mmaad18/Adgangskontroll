using Adgangskontroll.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Adgangskontroll.Semesteroppgave;

namespace Adgangskontroll
{
    public partial class Kortleser : Form
    {
        //---------------------------------------Deklarasjoner-------------------------------------------------------------------

        #region Deklarasjoner

        // Kortleser info:
        private string kortleserID;

        private string kortleserPlassering;

        // Grafiske elementer:
        private readonly Image doorOpen;

        private readonly Image doorClosed;
        private readonly Image alarm;
        private readonly Image noalarm;

        // Serieport:
        private readonly SerialPort serialPort = new SerialPort();

        private string forrigeSerialData; // Sjekker ny melding mot forrige for å ikke spamme debug vinduet
        private string serialData; // Streng mottat på serieporten
        private string alarmType; // Hva utløste alarmen
        private string alarmDeaktivert; // Hvordan ble alarmen resatt

        // SimsimData:
        private List<object> simsimDataList; // Liste som inneholder alle dataene fra simsim i passende formater.

        private bool[] DI; // Array med boolske verdier fra simsim DI
        private bool[] DO; // Array med boolske verdier fra simsim DO
        private int[] potmeter; // Array med verdi av potmetrene fra simsim

        // Div variabler:
        private string kode = ""; // Holder styr på inntastet kode på

        private int tidAdgang; // Tid som gjenstår av et adgangsforsøk
        private int tidDoorOpen; // Hvor lenge døren har vært åpen.

        // UDP:
        private const int listenport = 9090;

        private UdpClient listenerClient;
        private IPEndPoint groupEndPoint;
        private Thread _listenerThread;

        // TCP:
        private TcpClient kortleserClient;

        private Thread _tcpConnectThread;
        private Thread _tcpListenThread;

        // Diverse bool:
        private bool innloggingSendt; // Forhindre at flere innlogginger sendes før svar er mottat fra sentral

        private bool innloggingOK; // Holder styr på innloggings status
        private bool LockFlag = true; // Lagrer forrige status for låsen
        private bool doorFlag; // Lagrer forrite status for døren
        private bool alarmFlag; // Holder styr på om en alarm er satt
        private bool avslutt; // Ment til å la tråder avslutte..
        private bool forrigeOK; // Holder styr på forrige "OK" trykk for å simulere en trykk knapp i simsim
        private bool forrigeC; // Holder styr på forrige "C" trykk for å simulere en trykk knapp i simsim

        #endregion Deklarasjoner

        //---------------------------------------Main (Kortleser)----------------------------------------------------------------

        #region MAIN

        public Kortleser()
        {
            InitializeComponent();
            kortleserID = txtbKortleserID.Text;
            kortleserPlassering = txtbKortleserPlassering.Text;
            Text = $@"Kortleser {kortleserID}";
            DI = new[] { false, false, false, false, false, false, false, false };
            DO = new[] { false, false, false, false, false, false, false, false };
            potmeter = new[] { 0, 0 };
            forrigeSerialData = "000000000000000000000000000000000000000000000000";

            doorClosed = Resources.locked;
            doorOpen = Resources.unlockedGreen;
            alarm = Resources.alarm;
            noalarm = Resources.noAlarm;

            pbOpenCLosed.Image = doorClosed;
            pbAlarm.Image = noalarm;
            pbAlarm.Visible = true;
            labelDoorTimer.Visible = false;
            labelLockTimer.Visible = false;
            btTcpDisconnect.Enabled = false;
            btTcpDisconnect.Visible = false;
            groupKodePanel.Enabled = false;
            timerGuiUpdater.Start();

            LogAll(txtbKortleserID.Text, "Kortleser starter...");

            // oppretter UDP lytteren
            StartUDP(listenport);
        }

        #endregion MAIN

        //---------------------------------------Generelle GUI Event handlers----------------------------------------------------

        #region GUI Event handlers

        // Fyller serieport rullegardin når musen entrer kontrollen
        private void comboBSerialPort_MouseEnter(object sender, EventArgs e)
        {
            GetSerialports();
        }

        // Forsøk på ryddig avslutning. Men Thread join fryser programmet.
        private void Kortleser_FormClosing(object sender, FormClosingEventArgs e)
        {
            avslutt = true;
            File.WriteAllText("loggvindu.txt", txtbLog.Text); // Lagrer all tekst i loggvinduet til fil.

            try
            {
                if(serialPort.IsOpen) CloseSerialPort();
                if (listenerClient != null)
                {
                    if (listenerClient.Client.Connected) listenerClient.Close();
                }
                if (kortleserClient != null)
                {
                    if (kortleserClient.Client.Connected) kortleserClient.Close();
                }
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                SkrivTilLoggFil(kortleserID, ex.Message);
            }
        }

        // Teller ned 45s etter at et kort er "scannet"
        private void Kode_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (kode.Length < 4)
            {
                kode += b.Text;
            }
            else
            {
                kode = "";
                kode += b.Text;
            }
            sevenSegmentArray1.Value = kode;
        }

        // Slettetast kodepanel
        private void btClear_Click(object sender, EventArgs e)
        {
            kode = "";
            sevenSegmentArray1.Value = kode;
        }

        // OK tast kodepanel
        private void btOK_Click(object sender, EventArgs e)
        {
            if (kode.Length == 4)
            {
                // Sender innlogging
                if (kortleserClient != null)
                {
                    if (kortleserClient.Connected && !innloggingSendt)
                    {
                        innloggingSendt = true;
                        string innlogging = $"$I:{kortleserID}:{txtbKortnummer.Text}:{kode}";
                        LogAll(kortleserID, $"Innlogging: {innlogging}");
                        TcpSendMelding(innlogging);
                    }
                    else LogAll(kortleserID, "Innlogging ikke sendt");
                }
                else LogAll(kortleserID, "TcpCient = NULL");
                // Viser messagebox på egen tråd for å ikke låse hovedprogrammet
                Task.Run(() => { MessageBox.Show("Innlogging sendt", "kortleser", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); });
                kode = "";
                sevenSegmentArray1.Value = kode;
            }
            else
            {
                LogAll(kortleserID, "Kode må inneholde 4 siffer");
                // Viser messagebox på egen tråd for å ikke låse hovedprogrammet
                Task.Run(() => { MessageBox.Show("Kode må inneholde 4 siffer!", "Feil", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                kode = "";
                sevenSegmentArray1.Value = kode;
            }
            kode = "";
            sevenSegmentArray1.Value = kode;
            timerAdgangsforsok.Stop();
            btScanKort.Text = "Scan";
            btScanKort.Enabled = true;
            groupKodePanel.Enabled = false;
            if (serialPort.IsOpen) serialPort.WriteLine("$O40");
        }

        // Åpner hjelpevindu
        private void Kortleser_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            hjelp _hjelp = new hjelp();
            _hjelp.Show();
        }

        // "Scan" knapp simulerer scanning av et RFID kort
        private void button1_Click(object sender, EventArgs e)
        {
            LogAll(kortleserID, $"Scanner kort {txtbKortnummer.Text}");
            kode = "";
            sevenSegmentArray1.Value = kode;
            tidAdgang = 45;
            btScanKort.Text = tidAdgang.ToString();
            btScanKort.Enabled = false;
            groupKodePanel.Enabled = true;
            timerAdgangsforsok.Start();
            if (serialPort.IsOpen) serialPort.WriteLine("$O41");
        }

        // Lar enter og return virke i tekstboks for kortnummer (i stedet for å trykke scan)
        private void kortnummerTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btScanKort.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Tick funksjon for adgang timer
        private void timerAdgangsforsok_Tick(object sender, EventArgs e)
        {
            if (tidAdgang > 0)
            {
                tidAdgang -= 1;
                btScanKort.Text = tidAdgang.ToString();
            }
            else
            {
                kode = "";
                sevenSegmentArray1.Value = kode;
                timerAdgangsforsok.Stop();
                btScanKort.Text = "Scan";
                btScanKort.Enabled = true;
                groupKodePanel.Enabled = false;
                if (serialPort.IsOpen) serialPort.WriteLine("$O40");
            }
        }

        // Tick funksjon for GUI updater
        private void timerGuiUpdater_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("g");
            SimsimStatus();
            StatusLabels();
        }

        // Tick funksjon for dør alarm
        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            tidDoorOpen += 1;
            labelDoorTimer.Visible = true;
            labelDoorTimer.Text = tidDoorOpen.ToString();

            if (DO[6])
            {
                if (tidDoorOpen <= 45) return;
                if (alarmFlag) return;
                serialPort.WriteLine("$O71");
                alarmType = "Dør åpen";
                LogAll(kortleserID, $"Alarm: {alarmType}");
                if (kortleserClient != null)
                {
                    if (kortleserClient.Connected) TcpSendMelding($"$A:{kortleserID}:{alarmType}");
                }
                alarmFlag = true;
            }
            else
            {
                labelDoorTimer.Visible = false;
                timerAlarm.Stop();
            }
        }

        private int _tid7SegReset;

        // Tick funksjon tilbakestiller melding som vises på 7seg display
        private void timerReset7seg_Tick(object sender, EventArgs e)
        {
            if (timerAdgangsforsok.Enabled)
            {
                timerReset7seg.Stop();
                return;
            }
            _tid7SegReset += 1;
            if (_tid7SegReset <= 3) return;
            sevenSegmentArray1.Value = "";
            timerReset7seg.Stop();
        }

        private int tidInnlogging;

        // Tick funksjon innlogging. Etter innlogging er mottatt har man 20 sekunder på å åpne døren før den låses igjen.
        private void timerInnloggingOK_Tick(object sender, EventArgs e)
        {
            labelLockTimer.Visible = true;
            labelLockTimer.Text = tidInnlogging.ToString();
            tidInnlogging -= 1;
            if (tidInnlogging >= 0 && !DO[5]) return;
            if (serialPort.IsOpen)
            {
                if (!DO[6]) serialPort.WriteLine("$O51");
            }
            timerInnloggingOK.Stop();
            innloggingOK = false;
            labelLockTimer.Visible = false;
        }

        // Setter kortleser plassering
        private void txtbKortleserPlassering_TextChanged(object sender, EventArgs e)
        {
            kortleserPlassering = txtbKortleserPlassering.Text;
        }

        // Setter kortleser nummer
        private void txtbKortleserID_TextChanged(object sender, EventArgs e)
        {
            kortleserID = txtbKortleserID.Text;
            this.Text = $"Kortleser {kortleserID}";
        }

        #endregion GUI Event handlers

        //---------------------------------------Generelle Metoder---------------------------------------------------------------

        #region Generelle Metoder

        /// <summary>
        /// Samlemetode for logging.
        /// </summary>
        /// <param name="avsender"></param>
        /// <param name="melding"></param>
        private void LogAll(string avsender, string melding)
        {
            SkrivTilLoggvindu(avsender, melding);
            SkrivTilKonsoll(avsender, melding);
            SkrivTilLoggFil(avsender, melding);
        }

        /// <summary>
        /// Sjekker om loggvinduet kan oppdateres fra gjeldende tråd og skriver ut melding.
        /// </summary>
        /// <param name="melding"></param>
        private void SkrivTilLoggvindu(string avsender, string melding)
        {
            if (txtbLog.InvokeRequired)
            {
                Invoke(new EventHandler(delegate { txtbLog.AppendText($"@{avsender}: {melding}" + Environment.NewLine); }));
            }
            else
            {
                txtbLog.AppendText($"@{avsender}: {melding}" + Environment.NewLine);
            }
        }

        /// <summary>
        /// Skriver ut gjeldende tidspunkt etterfulgt av melding
        /// </summary>
        /// <param name="melding"></param>
        private void SkrivTilKonsoll(string avsender, string melding)
        {
            Console.WriteLine($"{DateTime.Now}: @{avsender}: {melding}");
        }

        /// <summary>
        /// Skriver til loggfil
        /// </summary>
        /// <param name="melding"></param>
        private void SkrivTilLoggFil(string avsender, string melding)
        {
            File.AppendAllText("logg.txt", $"{DateTime.Now}: @{avsender}: {melding}\r\n");
        }

        // Oppdaterer GUI elementer som viser simsim status
        private void SimsimStatus()
        {
            txtbPot1.Text = potmeter[0].ToString();
            txtbPot2.Text = potmeter[1].ToString();
            cbDI0.Checked = DI[0];
            cbDI1.Checked = DI[1];
            cbDI2.Checked = DI[2];
            cbDI3.Checked = DI[3];
            cbDI4.Checked = DI[4];
            cbDI5.Checked = DI[5];
            cbDI6.Checked = DI[6];
            cbDI7.Checked = DI[7];
            cbDO0.Checked = DO[0];
            cbDO1.Checked = DO[1];
            cbDO2.Checked = DO[2];
            cbDO3.Checked = DO[3];
            cbDO4.Checked = DO[4];
            cbDO5.Checked = DO[5];
            cbDO6.Checked = DO[6];
            cbDO7.Checked = DO[7];
        }

        private void StatusLabels()
        {
            // Oppdaterer diverse status labels og ikoner
            pbOpenCLosed.Image = DO[5] ? doorClosed : doorOpen; // Lås låst/ulåst, ikke dør
            pbAlarm.Image = DO[7] ? alarm : noalarm;
            labelLockStatus.Visible = serialPort.IsOpen;
            labelLockStatus.Text = DO[5] ? "Låst" : "Åpen";
            labelDoorStatus.Visible = serialPort.IsOpen;
            labelDoorStatus.Text = DO[6] ? "Åpen" : "Lukket";
            labelAlarmStatus.Visible = serialPort.IsOpen;
            labelAlarmStatus.Text = DO[7] ? "Utløst" : "Ingen";
            labelAlarmType.Visible = alarmFlag;
            labelAlarmType.Text = alarmType;
        }

        #endregion Generelle Metoder

        //---------------------------------------TCP kommunikasjon med sentral---------------------------------------------------

        #region TCP Kommunikasjon

        private void ShowTcpControls(bool inn)
        {
            btTcpConnect.Enabled = inn;
            btTcpConnect.Visible = inn;
            txtbKortleserID.Enabled = inn;
            txtbKortleserPlassering.Enabled = inn;
            txtbTcpIP.Enabled = inn;
            txtbTcpPort.Enabled = inn;
        }

        // Kode som kjøres når koble til knapp trykkes
        private void btTcpConnect_Click(object sender, EventArgs e)
        {
            kortleserID = txtbKortleserID.Text;
            kortleserPlassering = txtbKortleserPlassering.Text;
            if (kortleserID.Length < 4 || kortleserPlassering.Length == 0) return;
            // Skjuler koble til, vis koble fra.
            ShowTcpControls(false);
            btTcpDisconnect.Enabled = true;
            btTcpDisconnect.Visible = true;
            // Skriver til logvindu og konsoll.
            LogAll(kortleserID, "Kobler til sentral...");

            // Oppretter egen tråd for å ikke fryse kortleser programmet om sentralen ikke svarer umiddelbart
            _tcpConnectThread = new Thread(Connect);
            _tcpConnectThread.Start();
        }

        // Kode som kjøres når koble fra knapp trykkes
        private void btTcpDisconnect_Click(object sender, EventArgs e)
        {
            ShowTcpControls(true);
            btTcpDisconnect.Enabled = false;
            btTcpDisconnect.Visible = false;
            kortleserClient?.Close();
            LogAll(kortleserID, "Kobler fra sentral...");
        }

        // Funksjon kjøres en gang når man kobler til sentral. Kjøres på egen tråd for å ikke henge opp programmet mens man venter på respons fra server.
        private void Connect()
        {
            try
            {
                var melding = $"{kortleserID}:{kortleserPlassering}";
                kortleserClient = new TcpClient(txtbTcpIP.Text, Convert.ToInt32(txtbTcpPort.Text));
                LogAll("Sentral", "Tilkobling vellykket");
                if (kortleserClient == null) return;
                if (kortleserClient.Connected) TcpSendMelding(melding);
                // Mottar velkomstmelding fra server
                var velkommen = TcpMottaMelding();
                TcpSendMelding($"$S:{kortleserID}:Alt OK");
                _tcpListenThread = new Thread(SentralLytter);
                _tcpListenThread.Start();
                LogAll("Sentral", velkommen);
            }
            catch (SocketException ex)
            {
                LogAll(kortleserID, ex.Message);
                Invoke(new EventHandler(delegate
                {
                    ShowTcpControls(true);
                    btTcpDisconnect.Enabled = false;
                    btTcpDisconnect.Visible = false;
                    kortleserClient?.Close();
                }));
            }
        }

        // Lytter på svar fra sentralen på egen tråd
        private void SentralLytter()
        {
            try
            {
                while (true)
                {
                    string melding = null;
                    byte[] innbytes = new byte[1024];
                    var stream = kortleserClient?.GetStream();
                    melding = Encoding.UTF8.GetString(innbytes, 0, stream.Read(innbytes, 0, innbytes.Length));
                    BehandleSentralMelding(melding);
                }
            }
            catch (Exception ex)
            {
                LogAll(kortleserID, ex.Message);
            }
        }

        private void BehandleSentralMelding(string svar)
        {
            char[] split = { ':' };
            var svarFelt = svar.Split(split, StringSplitOptions.RemoveEmptyEntries);
            if (!(svarFelt.Length >= 2)) return;
            var prefiks = svarFelt[0]; // Meldings prefiks fra sentralen
            var melding = svarFelt[1]; // Melding innhold.

            switch (prefiks)
            {
                case "$1":
                    LogAll("Sentral", $"Innlogging \"{melding}\"");
                    innloggingSendt = false;
                    innloggingOK = true;
                    Invoke(new EventHandler(delegate { InnloggingOK(); }));
                    break;

                case "$0":
                    LogAll("Sentral", $"Innlogging \"{melding}\"");
                    innloggingSendt = false;
                    innloggingOK = false;
                    Invoke(new EventHandler(delegate { InnloggingFail(); }));
                    break;

                default:
                    LogAll("Sentral", melding);
                    break;
            }
        }

        private void InnloggingFail()
        {
            // Skriver feilmelding til 7seg display
            sevenSegmentArray1.Value = "Err.";
            _tid7SegReset = 0;
            timerReset7seg.Start();
        }

        private void InnloggingOK()
        {
            // Skriver "PASS" til 7seg display
            sevenSegmentArray1.Value = "PA55";
            _tid7SegReset = 0;
            tidInnlogging = 20;
            timerReset7seg.Start();
            timerInnloggingOK.Start();

            // Sender melding til simsim
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine("$O50");
                }
            }
        }

        /// <summary>
        /// Funksjon for å sende melding til sentralen
        /// </summary>
        /// <param name="melding"></param>
        private void TcpSendMelding(string melding)
        {
            try
            {
                var stream = kortleserClient.GetStream();
                byte[] bytes = Encoding.UTF8.GetBytes(melding);
                stream.Write(bytes, 0, bytes.Length);
            }
            catch (Exception ex)
            {
                LogAll(kortleserID, ex.Message);
            }
        }

        /// <summary>
        /// Funksjon for å motta en melding fra sentralen
        /// </summary>
        /// <param name="tcpClient"></param>
        /// <returns></returns>
        private string TcpMottaMelding()
        {
            try
            {
                byte[] bytes = new byte[1024];
                var stream = kortleserClient.GetStream();
                var melding = Encoding.UTF8.GetString(bytes, 0, stream.Read(bytes, 0, bytes.Length));
                return melding;
            }
            catch (Exception ex)
            {
                LogAll(kortleserID, ex.Message);
                return "$S:Feil ved kommunikasjon med sentralen";
            }
        }

        #endregion TCP Kommunikasjon

        //---------------------------------------UDP kommunikasjon med adgang "app"----------------------------------------------

        #region UDP Kommunikasjon

        private void StartUDP(int port)
        {
            try
            {
                listenerClient = new UdpClient(port);
                groupEndPoint = new IPEndPoint(IPAddress.Any, port);
                // Starter lyttetråd
                LogAll(kortleserID, "Starter UDP lytter");
                _listenerThread = new Thread(UdpListener);
                _listenerThread.Start();
            }
            catch (Exception ex)
            {
                LogAll(kortleserID, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        // Lytte metode for UDP
        private void UdpListener()
        {
            while (!avslutt)
            {
                try
                {
                    byte[] bytes = listenerClient.Receive(ref groupEndPoint);
                    var appInnlogging = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    BehandleAppInnlogging(appInnlogging);
                }
                catch
                    (Exception ex)
                {
                    LogAll(kortleserID, ex.Message);
                }
            }
        }

        // Videresender innlogging til sentral dersom kortleserID matcher og klienten er opprettet og har kontakt.
        private void BehandleAppInnlogging(string appInnlogging)
        {
            char[] split = { ':' };
            string[] dataFelt = appInnlogging.Split(split, StringSplitOptions.RemoveEmptyEntries);
            if (dataFelt.Length != 0 && dataFelt[0] == kortleserID)
            {
                LogAll("App", appInnlogging);
                if (kortleserClient == null || !kortleserClient.Connected) return;
                if (innloggingSendt) return;
                TcpSendMelding($"$I:{appInnlogging}");
                innloggingSendt = true;
            }
            else
            {
                LogAll("App", "Feil kortleserID");
                Invoke(new EventHandler(delegate { InnloggingFail(); }));
            }
        }

        #endregion UDP Kommunikasjon

        //---------------------------------------Seriell kommunikasjon-----------------------------------------------------------

        #region Seriell Kommunikasjon

        // Sjekker om serieporter er opptatt, og fyller komboboksen med tilgjengelige porter
        private void GetSerialports()
        {
            comboBSerialPort.Items.Clear();

            foreach (var portname in SerialPort.GetPortNames())
            {
                try
                {
                    var availablePorts = new SerialPort(portname);
                    availablePorts.Open();
                    if (availablePorts.IsOpen) comboBSerialPort.Items.Add(portname);
                    availablePorts.Close();
                    availablePorts.Dispose();
                }
                catch (Exception ex)
                {
                    LogAll(kortleserID, ex.Message);
                }
            }
        }

        // Metode for oppretting av seriell forbindelse når koble til knappen trykkes
        private void btSerialConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.DataReceived -= new SerialDataReceivedEventHandler(DataReceived);
                    CloseSerialPort();
                    comboBSerialPort.Enabled = true;
                    txtbSerialBaud.Enabled = true;
                    btSerialConnect.Text = "Koble til";
                    LogAll(kortleserID, $"Stenger {comboBSerialPort.SelectedItem}");
                }
                else
                {
                    serialPort.PortName = comboBSerialPort.SelectedItem.ToString();
                    serialPort.BaudRate = Convert.ToInt16(txtbSerialBaud.Text);
                    serialPort.DataBits = 8;
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;
                    serialPort.Open();
                    if (serialPort.IsOpen)
                    {
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);

                        // Setter lås på, dør lukket og alarm av
                        serialPort.WriteLine("$O51");
                        serialPort.WriteLine("$O60");
                        serialPort.WriteLine("$O70");
                        serialPort.WriteLine("$R1");

                        txtbSerialBaud.Enabled = false;
                        comboBSerialPort.Enabled = false;
                        btSerialConnect.Text = "Koble fra...";
                        LogAll(kortleserID, $"Serieport lytter på {comboBSerialPort.SelectedItem}");
                    }
                }
            }
            catch (Exception ex)
            {
                LogAll(kortleserID, ex.Message);
            }
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var tegn = '*';
            try
            {
                // For å unngå å begynne å lese i midten av en melding
                // ignorerer vi alle tegn inntil vi mottar '$'-tegn
                while (tegn != '$')
                {
                    tegn = Convert.ToChar(serialPort.ReadChar());
                }
                var lesebuffer = "$";

                // Melding mottas her
                while (tegn != '#')
                {
                    tegn = Convert.ToChar(serialPort.ReadChar());
                    lesebuffer += tegn;
                }
                serialData = lesebuffer;
                BehandleSeriedata();

                // Sjekker ny melding mot forrige for å ikke spamme debug vinduet
                if (serialData.Substring(21) != forrigeSerialData.Substring(21))
                {
                    LogAll("simsim", serialData);
                }

                forrigeSerialData = serialData;
                Invoke(new EventHandler(delegate
                {
                    SimsimCode();
                    SimsimDoor();
                }));
            }
            catch (Exception ex)
            {
                LogAll(kortleserID, ex.Message);
            }
        }

        // Lukker serieport og frigir resurser
        private void CloseSerialPort()
        {
            if (serialPort == null) return;
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                LogAll(kortleserID, "Serieport lukket");
            }
            serialPort.Dispose();
        }

        #endregion Seriell Kommunikasjon

        //---------------------------------------Behandle data fra simsim--------------------------------------------------------

        #region Behandle Simsim data

        // Lagrer alle relevante verdier fra simsim
        private void BehandleSeriedata()
        {
            simsimDataList = BehandleSimsimData(serialData);
            DI = simsimDataList.ElementAt(3) as bool[]; // Digitale innganger. Kan ikke settes over serieport
            DO = simsimDataList.ElementAt(4) as bool[]; // Digitale utganger. Kan settes over serieport. $Oxy hvor x = utgang# og y = verdi
            potmeter[0] = Convert.ToInt32(simsimDataList.ElementAt(6));
            potmeter[1] = Convert.ToInt32(simsimDataList.ElementAt(7));
        }

        // Sjekker om en digital utgang er TRUE simsim. Utfører korresponderende knappetrykk og resetter den digitale utgangen i simsim.
        private void SimsimCode()
        {
            if (DO[0]) // Tast "0"
            {
                btCode0.PerformClick();
                serialPort.WriteLine("$O00");
            }
            if (DO[1]) // Tast "1"
            {
                btCode1.PerformClick();
                serialPort.WriteLine("$O10");
            }
            if (DO[2]) // Tast "2"
            {
                btCode2.PerformClick();
                serialPort.WriteLine("$O20");
            }
            if (DO[3]) // Tast "3"
            {
                btCode3.PerformClick();
                serialPort.WriteLine("$O30");
            }
            if (DO[4]) // Tast Scan starter et adgangsforsøk.
            {
                btScanKort.PerformClick();
            }
            if (forrigeOK != DI[4]) btOK.PerformClick(); // Tast "OK"

            if (forrigeC != DI[3]) btClear.PerformClick(); // Tast "C"

            // Lagrer forrige verdi til neste runde
            forrigeOK = DI[4];
            forrigeC = DI[3];
        }

        private void SimsimDoor()
        {
            // Resetter alarmSatt flagget om status endres fra simsim
            if (!DO[7] && alarmFlag)
            {
                alarmFlag = false;
                alarmDeaktivert = "Resatt eksternt";
                LogAll(kortleserID, $"Alarm :{alarmDeaktivert}");
                if (kortleserClient != null)
                {
                    if (kortleserClient.Connected) TcpSendMelding($"$S:{kortleserID}:{alarmDeaktivert}");
                }
            }
            // Resetter alarm og alarmSatt dersom alarmen er aktiv, døren er lukket+låst og potmeter ikke indikerer innbrudd.
            if (DO[5] && !DO[6] && DO[7] && (potmeter[0] <= 500))
            {
                serialPort.WriteLine("$O70");
                if (alarmFlag)
                {
                    alarmFlag = false;
                    alarmDeaktivert = "Alt ok";
                    LogAll(kortleserID, $"Alarm :{alarmDeaktivert}");
                    if (kortleserClient != null)
                    {
                        if (kortleserClient.Connected) TcpSendMelding($"$S:{kortleserID}:{alarmDeaktivert}");
                    }
                }
            }
            // Starter dørtimer dersom døren er åpen, timeren ikke går og alarmflagg ikke allerede er satt.
            if (DO[6] && !timerAlarm.Enabled && !alarmFlag)
            {
                tidDoorOpen = 0;
                timerAlarm.Start();
            }
            // Setter alarm og alarmflagg dersom potmeter indikerer innbrudd og alarmflagg ikke allerede er satt
            if (potmeter[0] > 500 && !alarmFlag)
            {
                serialPort.WriteLine("$O71");
                alarmType = "Lås brutt opp";
                LogAll(kortleserID, $"Alarm :{alarmType}");
                if (kortleserClient != null)
                {
                    if (kortleserClient.Connected) TcpSendMelding($"$A:{kortleserID}:{alarmType}");
                }
                alarmFlag = true;
            }
            // Dersom dør er låst og alarmflagg ikke er satt skal den settes til status lukket.
            if (DO[5] && !alarmFlag && !innloggingOK)
            {
                serialPort.WriteLine("$O60");
            }

            // Dersom døren åpnes og er ulåst skal den automatisk låses når den lukkes igjen.
            if (doorFlag && !DO[6] && !DO[5])
            {
                serialPort.WriteLine("$O51");
                innloggingOK = false;
            }

            // Setter forrige verdi:
            doorFlag = DO[6];
            LockFlag = DO[5];
        }

        #endregion Behandle Simsim data
    }
}