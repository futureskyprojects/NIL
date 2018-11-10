using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace SecureMail
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Check Background file have or not
            // If have, close until program closed
            Process[] ListBgRun = Process.GetProcessesByName("Background");
            if (ListBgRun.Length > 0)
            {
                foreach (Process item in ListBgRun)
                    item.Kill();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage());
            // After finish ...continue run background
            if (Operations.GlobalVarriable.ShutdownX ==false)
                Process.Start(@"Background\Background.exe");
        }
    }
}
