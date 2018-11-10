using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureMail
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Load application infomations
            ApplicationName.Text = ProgramInfo.App.Name + " (" + ProgramInfo.App.Version + ")";
            // bring Account List show to front
            AccountListShow.BringToFront();
            this.Hide();
            TransitionWhenStartPanel.ShowSync(this);
            this.BringToFront();
            ShutdownShow.cancelshutdown += new EventHandler(CancelShutdown);
        }
        private void CancelShutdown(object sender, EventArgs e)
        {
            BT_Accounts.selected = true;
            BT_Accounts_Click(sender, e);
            BT_Shutdown.selected = false;
        }
        private void CallForHide(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void CallForShow(object sender, EventArgs e)
        {
            this.Show();
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BT_Accounts_Click(object sender, EventArgs e)
        {
            AccountListShow.BringToFront();
        }

        private void BT_SavedEmail_Click(object sender, EventArgs e)
        {
            SavedMailsShow.BringToFront();
        }

        private void BT_Options_Click(object sender, EventArgs e)
        {
            OptionsShow.BringToFront();
        }

        private void BT_Support_Click(object sender, EventArgs e)
        {
            SuportShow.BringToFront();
        }

        private void BT_Shutdown_Click(object sender, EventArgs e)
        {
            ShutdownShow.BringToFront();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Operations.GlobalVarriable.ShutdownX==false)
            {
                DialogResult ask = MessageBox.Show("EXIT NOW?",
    "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.No == ask)
                    e.Cancel = true;
            }
        }
    }
}
