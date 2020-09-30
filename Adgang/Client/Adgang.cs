using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Adgang : Form
    {
        // Kode for å kunne dra vinduet uten ramme
        private const int WM_NCHITTEST = 0x84;

        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public Adgang()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr) HT_CAPTION;
        }

        private void btAvslutt_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (kortleserID.Text.Length < 4 || brukerID.Text.Length < 4 || pin.Text.Length < 4) return;
            var melding = string.Format($"{kortleserID.Text}:{brukerID.Text}:{pin.Text}");
            try
            {
                var s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                var broadcastIP = IPAddress.Parse(ipFelt.Text);
                var sendBytes = Encoding.ASCII.GetBytes(melding);
                var ep = new IPEndPoint(broadcastIP, Convert.ToInt16(txtbPort.Text));
                s.SendTo(sendBytes, ep);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}