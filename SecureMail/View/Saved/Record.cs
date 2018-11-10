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
    public partial class Record : UserControl
    {
        String senderX = string.Empty;
        String Subjectmails = String.Empty;
        String PathOfSavedmail = string.Empty;
        Image SenderAvatar;
        public Record(string _Sender, string _Subject, string _PathOfSavedmail, Image _SenderAvatar)
        {
            senderX = _Sender;
            Subjectmails = _Subject;
            PathOfSavedmail = _PathOfSavedmail;
            SenderAvatar = _SenderAvatar;
            InitializeComponent();
        }
        private void Record_Load(object sender, EventArgs e)
        {
            #region For load data
            Subject.Text = Subjectmails;
            From.Text = "From: " + senderX;
            #endregion
            CallmailLogo();
        }
        private void CallmailLogo()
        {
            if (senderX.Contains("@gmail.com"))
            {
                MailKind.Image = Properties.Resources._008_gmail;
            }
            else
            {
                MailKind.Image = Properties.Resources.envelope;
            }
        }
        Color Default = new Color();
        bool MoveF = false;
        private void From_MouseMove(object sender, MouseEventArgs e)
        {
            MailKind.Image = SenderAvatar;
            if (MoveF==false)
            {
                Default = BackColor;
                BackColor = Color.Turquoise;
                //Subject.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(163)));
                //From.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(163)));
                MoveF = true;
            }
        }

        private void From_MouseLeave(object sender, EventArgs e)
        {
            CallmailLogo();
            if (MoveF == true)
            {
                BackColor = Default;
                //Subject.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                //From.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(163)));
                MoveF = false;
            }
        }

        public EventHandler SelectClick;
        private void Subject_Click(object sender, EventArgs e)
        {
            CurrentRecord.Value = this.Name;
            CurrentRecord.PathOfSavedMail = PathOfSavedmail;
            if (SelectClick != null)
                SelectClick(sender, e);
        }
        public EventHandler DeleteClicked;
        private void DeleteMsg_Click(object sender, EventArgs e)
        {
            DialogResult Ask = MessageBox.Show("Really delete this mail?", "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Ask == DialogResult.No)
                return;
            else
            {
                try
                {
                    if (File.Exists(PathOfSavedmail))
                        File.Delete(PathOfSavedmail);
                    if (File.Exists(PathOfSavedmail))
                        MessageBox.Show("Mail still here! Can not delete it!", "PERMISSION WRONG!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        MessageBox.Show("Deleted!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (DeleteClicked != null)
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
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
    public static class CurrentRecord
    {
        public static String Value = String.Empty;
        public static String PathOfSavedMail = String.Empty;
    }
}
