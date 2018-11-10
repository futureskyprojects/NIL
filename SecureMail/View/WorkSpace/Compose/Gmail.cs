using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SecureMail.WorkSpace.Compose
{
    public partial class Gmail : UserControl
    {
        #region Form Start
        bool Reply = false;
        string ToX = string.Empty;
        string SubjectX = string.Empty;
        public Gmail(string _ToX, string _SubjectX)
        {
            Reply = true;
            ToX = _ToX;
            SubjectX = _SubjectX;
            InitializeComponent();
            Gmail_Load(null, EventArgs.Empty);
        }
        public Gmail()
        {
            Reply = false;
            InitializeComponent();
        }
        // Function for load this program
        private void AddCollection()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(AddCollection));
                return;
            }
            if (!File.Exists(ListOfPath.SavedContacts))
                return;
            var Source = new AutoCompleteStringCollection();
            try
            {
                foreach (string item in File.ReadLines(ListOfPath.SavedContacts))
                {
                    try
                    {
                        Source.Add(item);
                    }
                    catch (Exception)
                    {
                        // Nothing
                    }
                }
            }
            catch (Exception)
            {
                // Nothing
            }
            SendTo.AutoCompleteCustomSource = Source;
        }
        private void Gmail_Load(object sender, EventArgs e)
        {
            if (Reply == true)
            {
                Title.Text = "Reply Message";
                PanelTo.Height = 0;
                PanelTo.Hide();
                SendTo.Text = ToX;
                PanelSubject.Height = 0;
                PanelSubject.Hide();
                Subject.Text = SubjectX;
                BOXATT.Height = 82;
            }
            else
            {
                SendTo.Text = Operations.GlobalVarriable.SendToChoosedAddress;
                Operations.GlobalVarriable.SendToChoosedAddress = string.Empty;
            }
            System.Threading.Thread Ad = new System.Threading.Thread(new System.Threading.ThreadStart(AddCollection));
            Ad.Start();
            CryptType.SelectedIndex = 0;
            // AES 1
            // DES 2
            // TwoFish 3
            // BlowFish 4
            BOXATT.Hide();
            TurnOnUsePass.Value = true;
            SendBT.Enabled = false;
        }
        bool ClosingX = false;
        private void CloseCompose_Click(object sender, EventArgs e)
        {
            ClosingX = true;
            if (SendTo.Text != string.Empty || Subject.Text != string.Empty || Content.Text != string.Empty)
            {
                DialogResult Res = MessageBox.Show("You have content in here, Want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Res == DialogResult.Yes)
                    Dispose();
            }
            else
                Dispose();
        }

        private void Attachment_Click(object sender, EventArgs e)
        {
            // renew 
            Send.Att.Clear();
            FileNameShow.Text = "";
            BOXATT.Hide();
            // Create and show choosen box
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.AutoUpgradeEnabled = true;
            filedialog.CheckFileExists = true;
            filedialog.CheckPathExists = true;
            filedialog.Multiselect = true;
            filedialog.Title = ProgramInfo.App.Name + " " + ProgramInfo.App.Version;
            filedialog.ShowDialog();
            #region File types you can't include as attachments
            // https://support.google.com/mail/answer/6590?hl=en
            string BlockedFileType = ".ADE .ADP .BAT .CHM .CMD .COM .CPL .EXE .HTA .INS .ISP .JAR .JS .JSE .LIB .LNK .MDE .MSC .MSI .MSP .MST .NSH .PIF .SCR .SCT .SHB .SYS .VB .VBE .VBS .VXD .WSC .WSF .WSH";
            #endregion
            string Error = string.Empty;
            if (filedialog.FileNames.Length < 1)
                return;
            else
                foreach (var file in filedialog.FileNames)
                {
                    FileInfo FF = new FileInfo(file);
                    if (FF.Attributes == FileAttributes.Directory)
                    {
                        Error += "\r\nYou can NOT attachment " + Path.GetDirectoryName(file) + "! Because it is folder! Please try Compress it before select!";
                        continue;
                    }
                    if (FF.Length > Operations.GlobalVarriable.MaxAttachmentSize)
                    {
                        Error += "\r\nYou can NOT attachment " + Path.GetFileName(file) + "! Because it large than " + ((Operations.GlobalVarriable.MaxAttachmentSize / 1024) / 1024) + " MB!";
                        continue;
                    }
                    if (BlockedFileType.IndexOf(Path.GetExtension(file).ToUpper()) != -1)
                    {
                        Error += "\r\nYou can NOT send " + Path.GetFileName(file) + " via Gmail!";
                        continue;
                    }
                    FileNameShow.Text += Path.GetFileName(file).ToUpper() + "\t";
                    Send.Att.Add(file);
                }
            __COUNT.Text = "SELECTED " + Send.Att.Count + " FILE(S)";
            if (Error != String.Empty)
                MessageBox.Show(Error, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (Send.Att.Count > 0)
                BOXATT.Show();
        }

        bool asking = true;
        private void TurnOnUsePass_OnValueChange(object sender, EventArgs e)
        {
            if (asking == false)
            {
                asking = true;
                return;
            }
            if (TurnOnUsePass.Value == true && String.IsNullOrEmpty(Password.Text))
            {
                SendBT.Enabled = false;
            }
            else
                SendBT.Enabled = true;
            if (TurnOnUsePass.Value == false)
            {
                DialogResult ask = MessageBox.Show("Your mail contents and attachment(s) won't be Encrypted! Do you want to continue?",
                    "TURN OF ENCRYPT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.No == ask)
                {
                    TurnOnUsePass.Value = true;
                    return;
                }
                Password.Text = "";
                Password.Enabled = false;
                CryptType.Enabled = false;
                Password.ForeColor = SystemColors.AppWorkspace;
            }
            else
            {
                Password.Text = "";
                Password.Enabled = true;
                CryptType.Enabled = true;
                Password.ForeColor = Color.LightSeaGreen;
            }

        }

        #endregion
        public EventHandler SendClicked;
        private void SendBT_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Send this mail?", "SEND?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == x)
                return;
            #region Check Input
            bool error = false;
            string listerror = "List of error:";
            // Check format of revicer input
            if (SendTo.Text == string.Empty)
            {
                listerror += "\r\n- Reciver empty!";
                error = true;
            }
            foreach (char c in SendTo.Text)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    if (c == ' ')
                    {
                        MessageBox.Show("Please split many emailaddress by ','\nEX" +
                            "ex1@example.com,ex2@example.com");
                    }
                    if (c == '.' || c == '_' || c == '@' || c == ',')
                        continue;
                    else
                    {
                        MessageBox.Show("this Mail Adress have special character!", "WRONG EMAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (SendTo.Text.Split(',').Length != SendTo.Text.Split('@').Length - 1)
            {
                error = true;
                listerror += "\r\n- Invalid Reciver email format!";
            }
            // Check subject
            if (Subject.Text == string.Empty)
            {
                error = true;
                listerror += "\r\n- Subject Empty!";
            }
            // Check Content
            if (Content.Text == string.Empty)
            {
                error = true;
                listerror += "\r\n- Content Empty!";
            }
            // Check Password if have
            if (TurnOnUsePass.Value == true && Password.Text == string.Empty)
            {
                error = true;
                listerror += "\r\n- Password Empty!";
            }
            #endregion
            if (error == true)
            {
                MessageBox.Show(listerror, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Send.SetArgument(SendTo.Text, Subject.Text, Content.Text, Password.Text);
            }
            if (SendClicked != null)
                SendClicked(sender, e);
            // then Dispose
            Content.Text = string.Empty;
        }

        private void CryptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operations.GlobalVarriable.KindOfCrypt = CryptType.SelectedIndex;
            // AES 1
            // DES 2
            // TwoFish 3
            // BlowFish 4
        }

        private void SendTo_Leave(object sender, EventArgs e)
        {
            if (Reply == true)
            {
                SendBT.Enabled = true;
                return;
            }

        }

        private void Subject_Leave(object sender, EventArgs e)
        {
            if (Reply == true)
            {
                SendBT.Enabled = true;
                return;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Password.Text) && ClosingX == false)
            {
                DialogResult ask = MessageBox.Show("Do you want to send un-encrypted mail?", "NO PASSWORD", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.No == ask)
                {
                    SendBT.Enabled = false;
                    return;
                }
                else
                {
                    asking = false;
                    TurnOnUsePass.Value = false;
                    return;
                }
            }
        }

        private void Content_Leave(object sender, EventArgs e)
        {

        }

        private void SendTo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Subject.Text) || String.IsNullOrEmpty(Subject.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
    if (String.IsNullOrEmpty(Content.Text) || String.IsNullOrWhiteSpace(Content.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
    if (TurnOnUsePass.Value == true && String.IsNullOrEmpty(Password.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
            if (SendTo.Text.Length<1)
            {
                SendBT.Enabled = false;
                return;
            }
            else
            SendBT.Enabled = true;
        }

        private void Subject_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SendTo.Text) || String.IsNullOrEmpty(SendTo.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
    if (String.IsNullOrEmpty(Content.Text) || String.IsNullOrWhiteSpace(Content.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
    if (TurnOnUsePass.Value == true && String.IsNullOrEmpty(Password.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
                            if (Subject.Text.Length < 1)
            {
                SendBT.Enabled = false;
                return;
            }
            else
                SendBT.Enabled = true;
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Subject.Text) || String.IsNullOrEmpty(Subject.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
if (String.IsNullOrEmpty(SendTo.Text) || String.IsNullOrWhiteSpace(SendTo.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
if (TurnOnUsePass.Value == true && String.IsNullOrEmpty(Password.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
                            if (Content.Text.Length < 1)
            {
                SendBT.Enabled = false;
                return;
            }
            else
                SendBT.Enabled = true;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Subject.Text) || String.IsNullOrEmpty(Subject.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
if (String.IsNullOrEmpty(Content.Text) || String.IsNullOrWhiteSpace(Content.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
if (String.IsNullOrEmpty(SendTo.Text) || String.IsNullOrWhiteSpace(SendTo.Text))
            {
                SendBT.Enabled = false;
                return;
            }
            else
                            if (Password.Text.Length < 1)
            {
                SendBT.Enabled = false;
                return;
            }
            else
                SendBT.Enabled = true;
        }
    }
    public static class Send
    {
        private static string To = String.Empty;
        private static string Sbject = String.Empty;
        private static string Cnt = String.Empty;
        private static string pwd = String.Empty;
        public static IList<string> Att = new List<string>();
        public static void SetArgument(string _To, string _Sbject, string _Cnt, string _pwd)
        {
            To = _To;
            Sbject = _Sbject;
            Cnt = _Cnt;
            pwd = _pwd;
        }
        public static bool OK()
        {
            try
            {
                var NewMessage = new Google.Apis.Gmail.v1.Data.Message();
                if (Att.Count < 1)
                    NewMessage.Raw = Base64UrlEncode(RepareContent(To, Sbject, Cnt, pwd));
                else
                    NewMessage.Raw = Base64UrlEncode(SendEmail.CreateMail_MultiPart(To, Sbject, Cnt, pwd));
                var CallX = Operations.Gmail.Connect.service.Users.Messages.Send(NewMessage, "me");
                var msg = CallX.ExecuteAsync().Result;
                String temp = CallX.HttpMethod;
                Send.Att.Clear();
                return true;
            }
            catch (Exception)
            {
                Send.Att.Clear();
                return false;
            }
        }
        public static string Base64UrlEncode(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }
        public static string RepareContent(string To, string Sbject, string Cnt, string pwd)
        {
            if (pwd != string.Empty)
            {
                switch (Operations.GlobalVarriable.KindOfCrypt)
                {
                    case 0:
                        {
                            Cnt = Operations.AES.Encrypt(Cnt, pwd);
                            break;
                        }
                    case 1:
                        {
                            Cnt = Operations.DES.Encrypt(Cnt, pwd);
                            break;
                        }
                    case 2:
                        {
                            Cnt = Operations.TwoFish.Encrypt(Cnt, pwd);
                            break;
                        }
                    case 3:
                        {
                            Cnt = Operations.BlowFish.Encrypt(Cnt, pwd);
                            break;
                        }
                    default:
                        {
                            Cnt = Operations.AES.Encrypt(Cnt, pwd);
                            break;
                        }
                }
            }
            string User_name = Operations.GlobalVarriable.User[0];
            if (User_name.IndexOf(" (") != -1)
                User_name = User_name.Substring(0, Operations.GlobalVarriable.User[0].IndexOf(" ("));
            User_name = Convert.ToBase64String(Encoding.UTF8.GetBytes(User_name));
            //
            return "From: " + "=?UTF-8?B?" + User_name + "?=" + " <" + Operations.GlobalVarriable.User[1] + ">" + "\r\n" +
                   "To: " + To + "\r\n" +
                   "Subject: " + "=?UTF-8?B?" + Convert.ToBase64String(Encoding.UTF8.GetBytes(Sbject)) + "?=" + "\r\n" +
                   "Content-Type: text/html\r\n\r\n" +
                    Cnt + "\r\n\r\n";
        }
    }
    public static class SendEmail
    {
        public static string CreateMail_MultiPart(string To, string Subject, string Content, string password)
        {
            string User_name = Operations.GlobalVarriable.User[0];
            if (User_name.IndexOf(" (") != -1)
                User_name = User_name.Substring(0, Operations.GlobalVarriable.User[0].IndexOf(" ("));
            User_name = Convert.ToBase64String(Encoding.UTF8.GetBytes(User_name));
            if (!String.IsNullOrEmpty(password))
            {
                switch (Operations.GlobalVarriable.KindOfCrypt)
                {
                    case 0:
                        {
                            Content = Operations.AES.Encrypt(Content, password);
                            break;
                        }
                    case 1:
                        {
                            Content = Operations.DES.Encrypt(Content, password);
                            break;
                        }
                    case 2:
                        {
                            Content = Operations.TwoFish.Encrypt(Content, password);
                            break;
                        }
                    case 3:
                        {
                            Content = Operations.BlowFish.Encrypt(Content, password);
                            break;
                        }
                    default:
                        Content = Operations.AES.Encrypt(Content, password);
                        break;
                }
            }
            string Edit =
                    "Content-Type: multipart/mixed; boundary=\"foo_bar_baz\"\r\n" +
                    "MIME-Version: 1.0\r\n" +
                    "From: " + "=?UTF-8?B?" + User_name + "?=" + " <" + Operations.GlobalVarriable.User[1] + ">" + "\r\n" +
                    "To: " + To + "\r\n" +
                    "Subject: " + "=?UTF-8?B?" + Convert.ToBase64String(Encoding.UTF8.GetBytes(Subject)) + "?=" + "\r\n\r\n" +

                    "--foo_bar_baz\r\n" +
                    "Content-Type: text/html; charset=\"UTF-8\"\r\n" +
                    "MIME-Version: 1.0\r\n" +
                    "Content-Transfer-Encoding: 7bit\r\n\r\n" +

                    Content + "\r\n\r\n";
            foreach (var item in Send.Att)
            {
                if (item == null || item == String.Empty || !File.Exists(item))
                    continue;
                Edit += "--foo_bar_baz\r\n" +
                    "Content-Type: " + MimeMap.GetMimeType(Path.GetExtension(item)) + "\r\n" +
                    "MIME-Version: 1.0\r\n" +
                    "Content-Transfer-Encoding: base64\r\n" +
                    "Content-Disposition: attachment; filename=\"" + Path.GetFileName(item) + "\"\r\n\r\n" +
                    (String.IsNullOrEmpty(password) ? Convert.ToBase64String(File.ReadAllBytes(item)) :
                    (Operations.GlobalVarriable.KindOfCrypt == 0 ? Operations.AES.EncryptFile(item, password) :
                    (Operations.GlobalVarriable.KindOfCrypt == 1 ? Operations.DES.EncryptFile(item, password) :
                    (Operations.GlobalVarriable.KindOfCrypt == 2 ? Operations.TwoFish.EncryptFile(item, password) :
                    Operations.BlowFish.EncryptFile(item, password))))) + "\r\n\r\n";
            }
            Edit += "--foo_bar_baz--";
            Send.Att.Clear();
            return Edit;
        }
    }
}
