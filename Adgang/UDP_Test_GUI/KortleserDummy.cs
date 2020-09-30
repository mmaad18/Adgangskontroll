using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UDP_Test_GUI
{
    public delegate void MyDelegate();

    public partial class KortleserDummy : Form
    {
        private const int listenport = 9090;

        private Thread listenerThread;
        private UdpClient listenerClient;
        private IPEndPoint groupEndPoint;
        private MyDelegate md;

        private string melding;
        private bool avslutt = false;

        public KortleserDummy()
        {
            InitializeComponent();

            // oppretter UDP lytteren
            listenerClient = new UdpClient(listenport);
            groupEndPoint = new IPEndPoint(IPAddress.Any, listenport);
            listenerThread = new Thread(UdpListener);
            md = UpdateGui;

            // Starter lyttetråd
            listenerThread.Start();
        }

        public void UdpListener() // Lytte metode for UDP
        {
            try
            {
                while (!avslutt)
                {
                    byte[] bytes = listenerClient.Receive(ref groupEndPoint);
                    melding = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
                    this.Invoke(md);
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                listenerClient.Close();
            }
        }

        public void UpdateGui()
        {
            textBox1.Text = melding;
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            listenerClient.Close();
            listenerThread.Join();
            Environment.Exit(0);
        }
    }
}