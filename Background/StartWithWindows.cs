using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Background
{
    public class StartWithWindows
    {
        public void InstallRes()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // Add the value in the registry so that the application runs at startup
            rkApp.SetValue(Process.GetCurrentProcess().ProcessName, Application.ExecutablePath);
        }
        public void UninstallRes()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // Add the value in the registry so that the application runs at startup
            rkApp.DeleteValue(Process.GetCurrentProcess().ProcessName, false);
        }
    }
}
