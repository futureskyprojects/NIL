using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SecureMail.Shutdown
{
    public partial class Shutdown : UserControl
    {
        public Shutdown()
        {
            InitializeComponent();
        }

        private void ShutDownAllRunning_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("When you accept:\r\n" +
                "     - Software will not run in background.\r\n" +
                "     - No new mail notification(s).\r\n" +
                "     - Important data may be lost.\r\n" +
                "If sure about all of things above, click following button to finish!", "SHUTDOWN PROGRAM?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ask == DialogResult.No)
                return;
            else
            {
                Operations.GlobalVarriable.ShutdownX = true;
                // 1nd. Close all running program
                Process[] Running = Process.GetProcesses();
                foreach (Process Pr in Running)
                {
                    if (Pr.Id == Process.GetCurrentProcess().Id)
                        continue;
                    try
                    {
                        Pr.Close();
                    }
                    catch (Exception)
                    {
                        // Nothing
                    }
                    try
                    {
                        Pr.Kill();
                    }
                    catch (Exception)
                    {
                        // Nothing
                    }
                    try
                    {
                        Pr.Dispose();
                    }
                    catch (Exception)
                    {
                        // Nothing
                    }
                }
                // 2st. Clear all account
                try
                {
                    Directory.Delete(Operations.GlobalVarriable.UserCombine, true);
                    Directory.Delete(Operations.GlobalVarriable.UserToken, true);
                }
                catch (Exception)
                {
                    // Nothing
                }
                // 3rd. Close this program
                Application.Exit();
            }
        }

        private void Shutdown_Load(object sender, EventArgs e)
        {
            TextShw.Text = "Shutdown " + ProgramInfo.App.Name + "?";
        }
        public EventHandler cancelshutdown;
        private void CancelShutdown_Click(object sender, EventArgs e)
        {
            if (cancelshutdown != null)
            {
                cancelshutdown(this,e);
                return;
            }
        }
    }
}
