using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesteroppgaveSentral1
{
    public partial class Valgvindu : Form
    {
        int brukerListeteller; // Teller antall brukere i listen for registrerte kort/brukere.
        private int klientListeteller; // Teller antall kortlesere i listen for kortlesere.

        string datoDag;    // Disse tre variablene brukes for å definere datoen i dag.
        string datoMåned; //
        string datoÅr;   //

        TcpListener lytter; // Lytter som lytter etter meldinger over TCP/IP.
        Thread lytteTråd; // Tråd som brukes til lytting etter meldinger. 

        bool KortlisteUtdatert; // Verdi som forteller om listen for tilkoblede kortlesere er utdatert eller ikke.

        StreamWriter filUt; // Funksjon for å skrive ut til fil. 

        public Valgvindu() // Initialiseringsvindu.
        {
            InitializeComponent(); // Initialiserer selve programmet.

            timer1.Start(); // Starter timeren "timer1".
            timer1.Enabled = true; // Gjør timeren "timer1" klar til bruk.
            
            datoDag = System.DateTime.Now.ToString("dd"); // Funksjon som brukes for å finne datoen for dagen i dag. 
            datoMåned = System.DateTime.Now.ToString("MM"); // Funksjon som brukes for å finne datoen for måneden vi er i. 
            datoÅr = System.DateTime.Now.ToString("yyyy"); // Funksjon som brukes for å finne datoen for året vi er i. 

            brukerListeteller = 0;
            klientListeteller = 0;

            KortlisteUtdatert = false;

            filUt = File.AppendText("SESJON.txt"); // Filen som loggen skal skrives til blir nå laget hvis den ikke finnes allerede. 

            lytter = new TcpListener(IPAddress.Any, 9090); // Lytteren lytter etter meldinger fra hvilken så helst IP på Port#9090.
            lytter.Start(); // Lyttingen starter
            lytteTråd = new Thread(TCPlytter); // Lyttere blir satt i egne tråder, som blir startet etter hvert som nye klienter kobler seg til. 
            lytteTråd.Start(); // Tråden for lytting blir startet. 
        }

        private void buttonAvslutt_Click(object sender, EventArgs e) // "Avslutt" knappen. Lukker programmet når det trykkes avslutt. 
        {
            Environment.Exit(0);
        }

        private void buttonLagre_Click(object sender, EventArgs e) // "Lagre" knappen. Kaller funksjonen "BrukerLagreFunksjon" som brukes for å lagre en bruker.
        {
            BrukerLagreFunksjon();
            faneVindu.SelectedIndex = 1; // Den valgte fanen vil hoppe til oversikten over brukere etter at en bruker har blitt lagret. 
        }

        private void buttonAvbryt_Click(object sender, EventArgs e) // "Avbryt knappen. Alle tekstfelt i registreringsfanen vil bli tomme. 
        {
            textEtternavn.Text = "";
            textFornavn.Text = "";
            textEpost.Text = "";
            textKortID.Text = "";
            textFraDag.Text = "";
            textFraMåned.Text = "";
            textFraÅr.Text = "";
            textTilDag.Text = "";
            textTilMåned.Text = "";
            textTilÅr.Text = "";
            textPIN.Text = "";
        }

        private void buttonSlett_Click(object sender, EventArgs e) // "Slett" knappen. Brukes for å slette en valgt bruker. 
        {
            if (Valgliste.SelectedIndex >= 0) // Ser om indexen i brukerlisten er større enn 0. dette gjør at en bruker må være valgt før funksjonen "SlettFunksjon" blir brukt. 
            {
                SlettFunksjon(); // Funksjon for å slette brukere 
            }
        }

        public void SlettFunksjon() // Funksjon for å slette brukere
        {
            BrukerListe.brukerListe.RemoveAt(Valgliste.SelectedIndex); // En bruker blir fjernet fra den lagrede listen for registrerte brukere.
            Valgliste.Items.Remove(Valgliste.SelectedItem); // Brukeren blir også fjernet fra valglisten som er synlig for Admin.
            brukerListeteller = klientListeteller - 1; // Antall brukere blir redusert med 1. 
        }

        public void LasteFunksjon() // Funksjon som brukes for å laste inn informasjonen til en valgt bruker inn i tekstfeltene i redigeringsvinduet.  
        {
            if (Valgliste.SelectedIndex >= 0) // Denne ser etter om en bruker er valgt. 
            {
                BrukerListe bruker = BrukerListe.brukerListe[Valgliste.SelectedIndex];
                textEtternavn.Text = bruker.Etternavn;
                textFornavn.Text = bruker.Fornavn;
                textEpost.Text = bruker.Epost;
                textKortID.Text = bruker.KortID;
                textFraDag.Text = bruker.FraDag;
                textFraMåned.Text = bruker.FraMåned;
                textFraÅr.Text = bruker.FraÅr;
                textTilDag.Text = bruker.TilDag;
                textTilMåned.Text = bruker.TilMåned;
                textTilÅr.Text = bruker.TilÅr;
                textPIN.Text = bruker.PIN;
            }
            else                           // Hvis ikek så blir alle tekstfeltene i redigeringsvinduet satt til å være tomme. 
            {
                textEtternavn.Text = "";
                textFornavn.Text = "";
                textEpost.Text = "";
                textKortID.Text = "";
                textFraDag.Text = "";
                textFraMåned.Text = "";
                textFraÅr.Text = "";
                textTilDag.Text = "";
                textTilMåned.Text = "";
                textTilÅr.Text = "";
                textPIN.Text = "";
            }
        }

        public void BrukerLagreFunksjon() // Denne funksjonen lagrer en bruker som er blitt endret på er lagt inn som ny bruker.
        {
            BrukerListe bruker = new BrukerListe
            {
                Etternavn = textEtternavn.Text,
                Fornavn = textFornavn.Text,
                Epost = textEpost.Text,
                KortID = textKortID.Text,
                FraDag = textFraDag.Text,
                FraMåned = textFraMåned.Text,
                FraÅr = textFraÅr.Text,
                TilDag = textTilDag.Text,
                TilMåned = textTilMåned.Text,
                TilÅr = textTilÅr.Text,
                PIN = textPIN.Text
            };

            if (Valgliste.SelectedIndex <= brukerListeteller && Valgliste.SelectedIndex >= 0) // Denne ser om en bruker har blitt valgt fra før. Hvis det stemmer så vet den
            {                                                                                 // at den må fjerne den gamle instansen i brukerlisten før en ny legges til på samme sted. 
                BrukerListe.brukerListe.RemoveAt(Valgliste.SelectedIndex);
                BrukerListe.brukerListe.Insert(Valgliste.SelectedIndex, bruker);
            }
            else                                                                              // Hvis ikke så blir en ny bruker lagt til ved siste posisjon i både brukerlisten og valglisten.
            {                                                                                 // Og antall brukere blir opphøyd med 1.
                BrukerListe.brukerListe.Add(bruker);
                brukerListeteller = brukerListeteller + 1;                    
            }
        }

        private void faneRedigering_Enter(object sender, EventArgs e) // Denne funksjonen blir aktivert når fanen for redigering av brukere blir valgt. Den ser etter om feltene for 
        {                                                             // dato er tomme, og fyller de deretter ut med dagens dato. 
            LasteFunksjon();

            if (textFraDag.Text == "")
            {
                textFraDag.Text = datoDag;
            }
            if (textFraMåned.Text == "")
            {
                textFraMåned.Text = datoMåned;
            }
            if (textFraÅr.Text == "")
            {
                textFraÅr.Text = datoÅr;
            }
            if (textTilDag.Text == "")
            {
                textTilDag.Text = datoDag;
            }
            if (textTilMåned.Text == "")
            {
                textTilMåned.Text = datoMåned;
            }
            if (textTilÅr.Text == "")
            {
                textTilÅr.Text = datoÅr;
            }
        }

        private void Valgliste_SelectedIndexChanged(object sender, EventArgs e) // Dette inntreffer når man velger en bruker fra listen med registrerte brukere. 
        {
            textTilbakemelding.Text = "Listeindex: " + Valgliste.SelectedIndex;
        }

        private void faneBrukere_Enter(object sender, EventArgs e) // Når fanen for registrerte brukere blir valgt, så blir den også oppdatert.
        {
            OppdaterValgliste();
        }

        private void OppdaterValgliste() // Funksjon som oppdaterer listen med registrerte brukere. 
        {
            Valgliste.Items.Clear();
            for (int i = 0; i < brukerListeteller; i++)
            {
                Valgliste.Items.Add("Etternavn: " + BrukerListe.brukerListe[i].Etternavn + ", " +
                                    "Fornavn: " + BrukerListe.brukerListe[i].Fornavn + ", " +
                                    "Epost: " + BrukerListe.brukerListe[i].Epost + ", " +
                                    "KortID: " + BrukerListe.brukerListe[i].KortID);
            }
        }

        private void OppdaterKortleserListe() // Funksjon som oppdaterer listen med tilkoblede kortlesere. 
        {
            if (klientListeteller > 1)
            {
                for (int i = 0; i < klientListeteller - 1; i++)
                {
                    if (Kortklasse.klientListe[klientListeteller - 1].KortleserID == Kortklasse.klientListe[i].KortleserID)
                    {
                        Kortklasse.klientListe.RemoveAt(klientListeteller - 1);
                        klientListeteller = klientListeteller - 1;
                    }
                }
            }

            KortleserListe.Items.Clear();
            for (int i = 0; i < klientListeteller; i++)
            {
                KortleserListe.Items.Add("KortleserID: " + Kortklasse.klientListe[i].KortleserID + ", " +
                                         "Plassering: " + Kortklasse.klientListe[i].Plassering + ", " +
                                         "Status: " + Kortklasse.klientListe[i].StatusDør);
            }
        }

        private void TCPlytter()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Kjører lytting...");
                    filUt.WriteLine("Kjører lytting...");

                    TcpClient kortklient = lytter.AcceptTcpClient();
                    // Mottar kortleser ID 
                    string kortleserID;
                    byte[] bits = new byte[1024];
                    NetworkStream stream;
                    stream = kortklient.GetStream();

                    kortleserID = Encoding.UTF8.GetString(bits, 0, stream.Read(bits, 0, bits.Length));

                    Console.WriteLine("Koblet til kortleser {0} på adresse. {1}", kortleserID, kortklient.Client.RemoteEndPoint);
                    filUt.WriteLine("Koblet til kortleser {0} på adresse. {1}", kortleserID, kortklient.Client.RemoteEndPoint);

                    //Splitter meldingen opp i logiske deler og setter hver del inn i en tabell. 
                    string[] meldingTabell = null;
                    char[] kolon = {':'};
                    meldingTabell = kortleserID.Split(kolon, StringSplitOptions.RemoveEmptyEntries);

                    klientListeteller++;
                    KortlisteUtdatert = true;

                    Kortklasse NyKortleser = new Kortklasse(meldingTabell[0], meldingTabell[1], kortklient);
                    Kortklasse.klientListe.Add(NyKortleser);

                    Console.WriteLine(NyKortleser.ToString());
                    filUt.WriteLine(NyKortleser.ToString());

                    Thread nyKlientTråd = new Thread(OneClient);
                    nyKlientTråd.Start(kortklient);

                    // Sender en velkomstmelding til en kortleser som kobler seg opp mot sentralen. 
                    byte[] utBytes = new byte[1024];
                    utBytes = Encoding.UTF8.GetBytes("$M:Du er nå tilkoblet sentralen.");
                    stream.Write(utBytes, 0, utBytes.Length);
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                filUt.WriteLine(ex.Message);
            }
        }

        private void OneClient(object tcpClient) // Funksjon som lytter etter meldinger fra hver gitte kortleser.
        {
            var client = tcpClient as TcpClient;
            if (client != null) client.ReceiveTimeout = 900000; // Hvis kortleseren blir markert som tilkoblet, så vil sentralen vente i 900'000 ms før den dropper tilkoblingen.

            try
            {
                while (true)
                {
                    string melding = null;
                    byte[] innbytes = new byte[1024];
                    byte[] utBytes = new byte[1024];
                    if (client != null)
                    {
                        var stream = client.GetStream();

                        // Mottar melding fra klient
                        melding = Encoding.UTF8.GetString(innbytes, 0, stream.Read(innbytes, 0, innbytes.Length));

                        // Meldingen blir skrevet til fil. 
                        Console.WriteLine("Melding fra {0}:\t{1}", client.Client.RemoteEndPoint, melding);
                        filUt.WriteLine("Melding fra {0}:\t{1}", client.Client.RemoteEndPoint, melding);

                        Thread.Sleep(10); 
                        // Sender respons til klient
                        utBytes = Encoding.UTF8.GetBytes(ReturFunksjon(melding));
                        stream.Write(utBytes, 0, utBytes.Length);
                    }
                }
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex);

            }
            catch (Exception ex) //Hvis en kortleser blir frakoblet, så blir den fjernet fra listen. Denne koden er desverre ufullstendig, siden den fjerner feil kortleser. 
            {
                Console.WriteLine(ex);

                Kortklasse.klientListe.RemoveAt(0);
                klientListeteller = klientListeteller - 1;
                KortlisteUtdatert = true;
            }
        }

        private string ReturFunksjon(string melding) // Dette er funksjonen som bestemmer hva som skal returneres tilbake til kortleseren. 
        {
            string[] meldingTabell = null;
            char[] splitter = {':'};
            string stringSvar = "$0:Feil";

            meldingTabell = melding.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

            switch (meldingTabell[0])
            {
                case "$A":                                                                                  // Dette inntreffer hvis den får melding om alarm.
                    Console.WriteLine("Alarm: {0} KortleserID: {1}", meldingTabell[2], meldingTabell[1]);
                    filUt.WriteLine("Alarm: {0} KortleserID: {1}", meldingTabell[2], meldingTabell[1]);

                    Kortklasse.klientListe[klientIndexFinner(meldingTabell[1])].StatusDør = meldingTabell[2];
                    KortlisteUtdatert = true;

                    MessageBox.Show("Alarm: " + meldingTabell[2] + " KortleserID: " + meldingTabell[1]);
                    stringSvar = "$M:Alarm mottatt";
                    break;

                case "$I":                                                                                  // Dette inntreffer hvis det oppstår en forsøkt innlogging 
                    Console.WriteLine("Innlogging");
                    stringSvar = Sammenligner(meldingTabell[2], meldingTabell[3]);
                    break;

                case "$S":                                                                                  // Dette inntreffer når det ankommer en melding om endring i status av døren. 
                    Console.WriteLine("Status: {0} KortleserID: {1}", meldingTabell[2], meldingTabell[1]);
                    filUt.WriteLine("Status: {0} KortleserID: {1}", meldingTabell[2], meldingTabell[1]);

                    Kortklasse.klientListe[klientIndexFinner(meldingTabell[1])].StatusDør = meldingTabell[2];
                    KortlisteUtdatert = true;
                    stringSvar = "$M:Melding mottatt";
                    break;

                default:
                    stringSvar = "$0:Feil";
                    break;
            }

            return stringSvar;
        }

        private string Sammenligner(string kortid, string pin) // Denne funksjonen sammenligner en mottatt KortleserID og PIN, og sammenligner det med ID og PIN som ligger i 
        {                                                      // listen med registrerte brukere. Den vil deretter gi tilbake ett svar som så sendes videre til den gitte kortleseren. 

            string svar = "$0:Feil";

            for (int i = 0; i < brukerListeteller; i++)
            {
                if (kortid == BrukerListe.brukerListe[i].KortID &&
                    pin == BrukerListe.brukerListe[i].PIN)
                {
                    if (Convert.ToInt32(BrukerListe.brukerListe[i].TilDag) >= Convert.ToInt32(datoDag) && // Sjekker om kortet fortsatt er gyldig. 
                        Convert.ToInt32(BrukerListe.brukerListe[i].TilMåned) >= Convert.ToInt32(datoMåned) &&
                        Convert.ToInt32(BrukerListe.brukerListe[i].TilÅr) >= Convert.ToInt32(datoÅr) &&
                        
                        Convert.ToInt32(BrukerListe.brukerListe[i].FraDag) <= Convert.ToInt32(datoDag) && // Sjekker om kortet har blitt gyldig
                        Convert.ToInt32(BrukerListe.brukerListe[i].FraMåned) <= Convert.ToInt32(datoMåned) &&
                        Convert.ToInt32(BrukerListe.brukerListe[i].FraÅr) <= Convert.ToInt32(datoÅr))
                    {
                        svar = "$1:OK";
                        filUt.WriteLine("Gyldig innloggingsinformasjon");
                        return svar;
                    }
                }
                else
                {
                    svar = "$0:Feil";
                }
            }
            filUt.WriteLine("Ugyldig innloggingsinformasjon");
            return svar;
        }

        private int klientIndexFinner(string kortleserID) // Denne funksjonen finner indexen til en kortleser i listen med tilkoblede kortlesere. 
        {
            for (int i = 0; i < klientListeteller; i++)
            {
                if (kortleserID == Kortklasse.klientListe[i].KortleserID)
                {
                    return i;
                }
            }

            return 0;
        }

        private void timer1_Tick(object sender, EventArgs e) // Dette er timeren som brukes for å oppdatere listen men tilkoblede kortlesere. 
        {
            if (KortlisteUtdatert)
            {
                OppdaterKortleserListe();
                KortlisteUtdatert = false;
            }
        }

        private void Valgvindu_FormClosing(object sender, FormClosingEventArgs e) // Denne funksjonen inntreffer når vinduet holder på å bli lukket.
        {
            lytter.Stop();
            Dispose();
            filUt.Close();
        }
    }
}