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
using System.Security.Cryptography;
using System.Threading;

namespace SecureMail.Saved
{
    public partial class Saved : UserControl
    {
        public Saved()
        {
            InitializeComponent();
        }
        bool FirstTimeLoadFinish = false;
        bool Updating = false;
        private void Saved_Load(object sender, EventArgs e)
        {
            ShowMailContents.Hide();
            #region Check have saved mail or not
            if (!File.Exists(ListOfPath.SavedMailLogs) || new FileInfo(ListOfPath.SavedMailLogs).Length < 1)
            {
                EmptySavedMails.Show();
                return;
            }
            else
                EmptySavedMails.Hide();
            #endregion
            LoadSavedmails();
            FirstTimeLoadFinish = true;
            // Call Timer Update
            System.Windows.Forms.Timer UpdateTimer = new System.Windows.Forms.Timer();
            UpdateTimer.Interval = 10000;
            UpdateTimer.Tick += new EventHandler(CallUpdate);
            UpdateTimer.Start();
        }
        private void LoadSavedmails()
        {
            #region Load saved mails
            foreach (String item in File.ReadLines(ListOfPath.SavedMailLogs))
            {
                string thePath = Encoding.UTF8.GetString(
                    Convert.FromBase64String(item));
                if (Availble.AvailblePath.Contains(thePath))
                    continue;
                if (File.Exists(thePath))
                {
                    SaveMail Savedmail = new SaveMail();
                    if (Savedmail.Load(thePath) == true)
                    {
                        Availble.AvailblePath.Add(thePath);
                        CallRecord(Savedmail.Sender, Savedmail.Subject,
                            thePath, Savedmail.SenderAvatar);
                    }
                    Savedmail = null;
                }
            }
            if (ListSavedMails.Controls.Count < 1)
                ShowEmptySavedMail();
            #endregion
        }
        private void ShowEmptySavedMail()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ShowEmptySavedMail));
                return;
            }
            ListSavedMails.Controls.Clear();
            Availble.AvailblePath.Clear();
            EmptySavedMails.Show();
        }
        private void HideEmptySavedMail()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(HideEmptySavedMail));
                return;
            }
            EmptySavedMails.Hide();
        }
        private void CallRecord(string _Sender, string _Subject, string _pathofsavedmail, Image _SenderAvatar)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, string, string, Image>(CallRecord),
                    new object[] { _Sender, _Subject, _pathofsavedmail, _SenderAvatar });
                return;
            }
            Record NewRecord = new Record(_Sender, _Subject, _pathofsavedmail, _SenderAvatar);
            NewRecord.SelectClick += new EventHandler(CallSelectedMail);
            NewRecord.DeleteClicked += new EventHandler(CallDeletedMail);
            #region Create MD5 of Path string, use for Control name
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(
                Encoding.ASCII.GetBytes(_pathofsavedmail));

            // step 2, convert byte array to hex string and set to name
            NewRecord.Name = BitConverter.ToString(hash).Replace("-", "");
            #endregion
            ListSavedMails.Controls.Add(NewRecord);
        }
        private void UpdateInfile(object sender, EventArgs e)
        {
            // Repare for update
            string RepareString = string.Empty;
            foreach (string item in Availble.AvailblePath)
            {
                RepareString += Convert.ToBase64String(Encoding.UTF8.GetBytes(item)) + "\r\n";
            }
            // OverWrite this file contnent
            try
            {
                File.WriteAllText(ListOfPath.SavedMailLogs, RepareString);
            }
            catch (Exception)
            {
                return;
            }
        }
        private void CallSelectedMail(object sender, EventArgs e)
        {
            ShowSavedMail ShowUp = new ShowSavedMail(CurrentRecord.PathOfSavedMail);
            ShowUp.DeleteClicked += new EventHandler(CallDeletedMail);
            ShowUp.Disposed += new EventHandler(ShowMailContentsAreaHide);
            ShowMailContents.Controls.Add(ShowUp);
            ShowMailContents.Show();
        }
        private void ShowMailContentsAreaHide(object sender, EventArgs e)
        {
            ShowMailContents.Hide();
        }
        private void CallDeletedMail(object sender, EventArgs e)
        {
            ListSavedMails.Controls.RemoveByKey(CurrentRecord.Value);
            Availble.AvailblePath.Remove(CurrentRecord.PathOfSavedMail);
            UpdateInfile(sender, e);
            if (ListSavedMails.Controls.Count < 1)
                ShowEmptySavedMail();
        }
        private void UpdateSavedMail()
        {
            Updating = true;
            if (FirstTimeLoadFinish == false)
                return;
            #region Check have saved mail or not
            if (!File.Exists(ListOfPath.SavedMailLogs) || new FileInfo(ListOfPath.SavedMailLogs).Length < 1)
            {
                ShowEmptySavedMail();
                return;
            }
            else
                HideEmptySavedMail();
            #endregion
            LoadSavedmails();
            Updating = false;
        }
        private void CallUpdate(object sender, EventArgs e)
        {
            if (Updating == true)
                return;
            else
            {
                Thread UpdateNow = new Thread(new ThreadStart(UpdateSavedMail));
                UpdateNow.Start();
            }
        }
    }
    public static class Availble
    {
        public static List<String> AvailblePath = new List<string>();
    }
}