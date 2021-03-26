using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrongaGlownaUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            KinomaniakLibrary.GlobalConfig.InitalizeConnections();
            //Application.Run(new StronaGlownaForm());
            Application.Run(new RegistrationForm());
        }
    }
}
