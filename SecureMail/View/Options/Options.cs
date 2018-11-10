using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureMail.Options
{
    public partial class Options : UserControl
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            // Check, if have setting before, load it to show
            if (File.Exists(ListOfPath.SavedSetting))
            {
                Setting.Load();
                SwitchCheckIB.Value = Setting.AutoCheckIB;
                TimeUpdate.Value = Setting.TimeUpdate;
                SwitchAutoDelete.Value = Setting.AutoDelete;
                TimeDele.Value = Setting.TimeDele;
                SwitchRunBackgruond.Value = Setting.Runbg;
                SwitchAutoDowloadAtt.Value = Setting.AutoDownloadAttachments;
                AutoDeleXday.Text = "Delete after every " + Setting.TimeDele + " day(s)";
                autocheckXs.Text = "Update after every " + Setting.TimeUpdate + " minute(s)";
            }
            RunBackground.Text = "B. Run " + ProgramInfo.App.Name + " in background";
            if (SwitchAutoDelete.Value == false)
                TimeDele.Enabled = false;
            if (SwitchCheckIB.Value == false)
                TimeUpdate.Enabled = false;
        }

        private void TimeDele_ValueChanged(object sender, EventArgs e)
        {
            AutoDeleXday.Text = "Delete after every " + TimeDele.Value.ToString() + " day(s)";
        }

        private void TimeUpdate_ValueChanged(object sender, EventArgs e)
        {
            autocheckXs.Text = "Update after every " + TimeUpdate.Value.ToString() + " minute(s)";
        }

        private void SaveOptions_Click(object sender, EventArgs e)
        {
            // Ask user before save
            DialogResult ask = MessageBox.Show("Are you sure?", "SAVE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.No)
                return;
            // Check if folder of options not availble then create new
            if (!Directory.Exists(Path.GetDirectoryName(ListOfPath.SavedSetting)))
                Directory.CreateDirectory(Path.GetDirectoryName(ListOfPath.SavedSetting));
            // Then continue work: saved user setting
            Setting.AutoCheckIB = SwitchCheckIB.Value;
            Setting.TimeUpdate = TimeUpdate.Value;
            Setting.AutoDelete = SwitchAutoDelete.Value;
            Setting.TimeDele = TimeDele.Value;
            Setting.Runbg = SwitchRunBackgruond.Value;
            Setting.AutoDownloadAttachments = SwitchAutoDowloadAtt.Value;
            if (Setting.Update() == false)
                MessageBox.Show("Save setting fail!", "CAN NOT SAVE SETTING!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("setting saved!", "SAVED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SwitchCheckIB_Click(object sender, EventArgs e)
        {
                TimeUpdate.Enabled = SwitchCheckIB.Value;
        }

        private void SwitchAutoDelete_Click(object sender, EventArgs e)
        {
            TimeDele.Enabled = SwitchAutoDelete.Value;
        }

        private void SwitchRunBackgruond_Click(object sender, EventArgs e)
        {
            TimeUpdate.Enabled = SwitchCheckIB.Value = SwitchRunBackgruond.Value;
        }

        private void SwitchAutoDowloadAtt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please wait for next version!");
        }
    }
}
