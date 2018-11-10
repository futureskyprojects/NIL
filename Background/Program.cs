using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureMail;

namespace Background
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Only one one in times
            Process CR = Process.GetCurrentProcess();
            Process[] LPR = Process.GetProcessesByName(CR.ProcessName);
            if (LPR.Length > 1)
            {
                return;
            }
            // Install | Update Registry key per time run
            StartWithWindows IU = new StartWithWindows();
            IU.InstallRes();
            // Load setting First
            if (Setting.Load() == false || Setting.Runbg == false)
            {
                Application.Exit();
            }

            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new BgRun());
            }
        }
    }
}
