using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Adgangskontroll
{
    static class Program
    {
        // Kode for å kunne debugge til konsoll dersom programmet åpnes fra cmd.
        //[DllImport("kernel32.dll")]
        //static extern bool AttachConsole(int dwProcessId);
        //private const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // redirect console output to parent process;
            // must be before any calls to Console.WriteLine()
            //AttachConsole(ATTACH_PARENT_PROCESS);
            // Enable visual elements just like always
            Console.WriteLine("###########################################");
            Console.WriteLine("#                                         #");
            Console.WriteLine("#                KORTLESER                #");
            Console.WriteLine("#                                         #");
            Console.WriteLine("###########################################");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Kortleser());
        }
    }
}
