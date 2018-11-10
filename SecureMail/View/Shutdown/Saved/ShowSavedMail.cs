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

namespace SecureMail.Saved
{
    public partial class ShowSavedMail : UserControl
    {
        string PathOfSavedMail = string.Empty;
        public ShowSavedMail(string _PathOfSavedMail)
        {
            PathOfSavedMail = _PathOfSavedMail;
            InitializeComponent();
            ShowSavedMail_Load(this,EventArgs.Empty);
        }
        string SenderMail = string.Empty;
        Image SenderAvatar;
        private void ShowSavedMail_Load(object sender, EventArgs e)
        {
            #region Check Saved mail path is availble or not
            if (!File.Exists(PathOfSavedMail))
            {
                MessageBox.Show("Sorry! This mail is no longer!","NOT FOUND!",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Dispose();
                return;
            }
            #endregion
            #region LoadInfomation
            SaveMail Savedmail = new SaveMail();
            if (Savedmail.Load(PathOfSavedMail) == true)
            {
                Subject.Text = Savedmail.Subject;
                senderX.Text = SenderMail = "From: " + Savedmail.Sender;
                SenderAvatar = Savedmail.SenderAvatar;
                DateTimeShow.Text = Savedmail.DateTimeReceived;
                if (String.IsNullOrEmpty(Savedmail.Body) || String.IsNullOrWhiteSpace(Savedmail.Body))
                    Decrypt.Enabled = false;
                else
                    try
                    {
                        var Temp = Convert.FromBase64String(Savedmail.Body);
                        Decrypt.Enabled = true;
                    }
                    catch (Exception)
                    {
                        Decrypt.Enabled = false;
                    }
                ContentShow.DocumentText = Savedmail.Body;
            }
            else
            {
                MessageBox.Show("Saved Mail is defective!","CAN NOT READ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Dispose();
                return;
            }
            #endregion
        }
        private void CallmailLogo()
        {
            if (SenderMail.Contains("@gmail.com"))
            {
                MailKind.Image = Properties.Resources._008_gmail;
            }
            else
            {
                MailKind.Image = Properties.Resources.envelope;
            }
        }

        private void MailKind_MouseMove(object sender, MouseEventArgs e)
        {
            MailKind.Image = SenderAvatar;
        }

        private void MailKind_MouseLeave(object sender, EventArgs e)
        {
            CallmailLogo();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            WorkSpace.EnterKey KeyIn = new WorkSpace.EnterKey();
            KeyIn.ShowDialog();
            if (Operations.Content.Message.CurrentPassword == string.Empty)
            {
                MessageBox.Show("This content is WhiteSpace or Empty!",
                    "NO CONTENT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string Res = Operations.AES.Decrypt(ContentShow.DocumentText, Operations.Content.Message.CurrentPassword);
            if (Res == string.Empty)
            {
                Dialog.ErrorDialog error = new Dialog.ErrorDialog("Wrong password! Suspiciously -_-");
                error.ShowDialog();
                return;
            }
            ContentShow.DocumentText = Res;
            Decrypt.Enabled = false;
        }

        public EventHandler DeleteClicked;
        private void DeleteSavedMsg_Click(object sender, EventArgs e)
        {
            DialogResult Ask = MessageBox.Show("Really delete this mail?","DELETE?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Ask == DialogResult.No)
                return;
            else
            {
                try
                {
                    if (File.Exists(PathOfSavedMail))
                        File.Delete(PathOfSavedMail);
                    if (File.Exists(PathOfSavedMail))
                        MessageBox.Show("Mail still here! Can not delete it!","PERMISSION WRONG!",
                            MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Deleted!","SUCCESS!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        if (DeleteClicked!=null)
                        {
                            DeleteClicked(sender, e);
                        }
                        this.Dispose();
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Some thing wrongs! Try run this program with administrator and do again!",
                        "ERROR!",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Dispose();
            return;
        }
    }
}
