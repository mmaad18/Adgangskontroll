using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesteroppgaveSentral1
{
    public class BrukerListe
    {
        public static List<BrukerListe> brukerListe = new List<BrukerListe>();

        public string Etternavn, Fornavn, Epost, KortID, FraDag, FraMåned, FraÅr, TilDag, TilMåned, TilÅr, PIN;

        public BrukerListe()
        {
            Etternavn = "";
            Fornavn = "";
            Epost = "";
            KortID = "";
            FraDag = "";
            FraMåned = "";
            FraÅr = "";
            TilDag = "";
            TilMåned = "";
            TilÅr = "";
            PIN = "";
        }
    }
    ///
    public class Kortklasse
    {
        public string KortleserID, Plassering, StatusDør;
        private TcpClient Klient;

        public static List<Kortklasse> klientListe = new List<Kortklasse>();

        public Kortklasse()
        {
            KortleserID = "";
            Plassering = "";
            StatusDør = "";
            Klient = null;
        }

        public Kortklasse(string _kortleserID, string _plassering, TcpClient _klient)
        {
            KortleserID = _kortleserID;
            Plassering = _plassering;
            Klient = _klient;
        }

        public override string ToString()
        {
            return string.Format("KortleserID: {0}\tPlassering: {1}\tKlient: {2}", KortleserID, Plassering, Klient.Client.RemoteEndPoint);
        }
    }
}
