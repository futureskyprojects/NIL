using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureMail;

namespace Background
{
    public partial class BgRun : Form
    {
        public BgRun()
        {
            InitializeComponent();
        }

        NotifyIcon notify = new NotifyIcon();
        private void BgRun_Load(object sender, EventArgs e)
        {
            // Context Menu
            ContextMenu context = new ContextMenu();
            context.MenuItems.Add("Open NIL Info Mail", new EventHandler(OpenNIL));
            context.MenuItems.Add("Quit", new EventHandler(QuitNIL));
            notify.Icon = Properties.Resources.NUL_LOGO_SMALL;
            notify.BalloonTipTitle = "NIL Info mail";
            notify.BalloonTipText = "Double Left-Click to Open\r\nRight-Click to quit";
            notify.Visible = true;
            notify.ContextMenu = context;
            notify.ShowBalloonTip(100);
            Size = new Size(0, 0);
            HideFrom();
            Thread thread = new Thread(new ThreadStart(Loop));
            thread.Start();
        }
        private void OpenNIL(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object,EventArgs>(OpenNIL), new object[] { sender, e });
                return;
            }
            string PathOfMain = Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath)) + "\\SecureMail.exe";
            Process.Start(PathOfMain);
        }
        bool Clicked = false;
        private void QuitNIL(object sender, EventArgs e)
        {
            if (Clicked == true)
                return;
            Clicked = true;
            DialogResult ask = MessageBox.Show("Quit NIL Info Mail?","QUIT?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ask == DialogResult.No)
            {
                Clicked = false;
                return;
            }
            else
            {
                Clicked = false;
                Application.Exit();
            }
        }
        private void Loop()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(Loop));
                return;
            }
            // OK for check new mail
            if (Setting.AutoCheckIB == true)
            {
                // Timer to check new mail
                System.Windows.Forms.Timer TimerCheckInbox = new System.Windows.Forms.Timer();
                TimerCheckInbox.Interval = Convert.ToInt32(Setting.TimeUpdate*1000) + 1000;
                TimerCheckInbox.Tick += new EventHandler(CallLoad);
                TimerCheckInbox.Start();
            }
        }
        private void HideFrom()
        {
            if (InvokeRequired)
            {
                HideFrom();
            }
            this.Hide();
        }
        Thread LoadX;
        private void CallLoad(object sender, EventArgs e)
        {
            if (CheckINBOX.ListAllAccount.Loading == true)
                return;
            try
            {
                if (LoadX.ThreadState == System.Threading.ThreadState.Running)
                    return;
            }
            catch (Exception)
            {
                // Nothing
            }
            ////////
            HideFrom();
            LoadX = new Thread(new ThreadStart(CheckINBOX.ListAllAccount.Load));
            LoadX.Start();
        }
    }
}
