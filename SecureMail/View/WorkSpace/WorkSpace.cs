using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureMail.WorkSpace
{
    public partial class WorkSpace : Form
    {
        // Set kind of select
        // 1 - INBOX
        // 2 - SENT
        // 3 - DRAFTS
        int KindOfSelect = 1;
        // Set/Get ID of mail box work stations
        // Another varriables

        bool ConnectStatus = false;
        string DisplayName;
        Image AvatarX;
        string MailAdress;
        string ImportFrom;
        int NumloadPerTime = 6;
        System.Threading.Thread LoadMessage = null;
        public WorkSpace()
        {
            InitializeComponent();
        }

        public WorkSpace(string _DisPlayName, Image _Avatar, string _MailAddress, string _ImportFrom)
        {
            Operations.GlobalVarriable.User[0] = DisplayName = _DisPlayName;
            AvatarX = _Avatar;
            Operations.GlobalVarriable.User[1] = MailAdress = _MailAddress;
            ImportFrom = _ImportFrom;
            InitializeComponent();
        }
        string HomeName = string.Empty;
        #region For Window and OptionBox
        private void WorkSpace_Load(object sender, EventArgs e)
        {
            #region  Setting Tool Tips
            ToolTip tooltip = new ToolTip();
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;
            tooltip.ShowAlways = true;
            #region Set tooltip
            tooltip.SetToolTip(this.back_button,"Back to main screen");
            tooltip.SetToolTip(this.Reply, "Reply");
            tooltip.SetToolTip(this.Forward, "Forward");
            tooltip.SetToolTip(this.FlagMsg, "Important");
            tooltip.SetToolTip(this.StarMsg, "Star");
            tooltip.SetToolTip(this.DeleteMsg,"Delete");
            tooltip.SetToolTip(this.SaveMsg, "Save");
            tooltip.SetToolTip(this.Decrypt, "Decrypt");
            tooltip.SetToolTip(this.Minimize_BT,"Minimize");
            tooltip.SetToolTip(this.Close_BT,"Close");
            tooltip.SetToolTip(this.Sending_,"Sendifng...");
            tooltip.SetToolTip(this.Load_,"Loading...");
            tooltip.SetToolTip(this.SearchBox, "Insert keywords to search...");
            tooltip.SetToolTip(this.Avatar, "Quick menu");
            #endregion
            #endregion
            #region ###
            // Hide main form before show
            HomeName = HomePage.ActiveForm.Name;
            HomePage.ActiveForm.Hide();
            LoadMailShowPicture.Hide();
            Sending_.Hide();
            LoadMailShowPicture.Size = new Size(597, 511);
            AttachmentPanelX.Hide();
            AttachmentPanelX.Height = 0;
            ShowMailList.Width = 300 - 19;
            BACK_Click(sender, e);
            WorkPlace.Location = panel6.Location;
            WorkPlace.Size = panel6.Size;
            // Setting form before run
            Decrypt.Enabled = false;
            UserName.Text = DisplayName;
            Avatar.Image = AvatarX;
            back_button.Enabled = false;
            Fr.Size = new Size(233, 229);
            Fr.ClickedForward += new EventHandler(GetListMailFromBox);
            Fr.Width = 0;
            Fr.Hide();
            if (Operations.Gmail.Connect.Open(ImportFrom) == true)
            {
                ConnectStatus = true;
            }
            else
            {
                ConnectStatus = false;
                FailBox.Show();
                return;
            }
            // First, we will load INBOX
            INBOX_Click(sender, e);
            // Hide Options Box!
            Avatar.Image = AvatarX;
            UserName.Text = DisplayName;
            DropdownShow.Hide(OptionsBox);
            IsShow = false;
            OptionsBox.Size = new Size(169, 203);
            // ShowWork Here
            WelCome wc = new WelCome();
            wc.Wel_NewMail += new EventHandler(COMPOSER_Click);
            wc.Wel_UserContact += new EventHandler(ContactManagerShow);
            wc.Wel_GUI += new EventHandler(GUIDEshow);
            ShowWork.Controls.Add(wc);
            // Timer for check INBOX
            System.Windows.Forms.Timer TimerCheckInbox = new System.Windows.Forms.Timer();
            TimerCheckInbox.Interval = 1000;
            TimerCheckInbox.Tick += new EventHandler(CheckNewMailINBOX);
            TimerCheckInbox.Start();
            #endregion
            MailShowArea.MouseWheel += new MouseEventHandler(MailShowArea_MouseWheel);
        }

        private void MailShowArea_MouseWheel(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;
            if (MailShowArea.VerticalScroll.Visible)
            {
//                int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines;
                int numberOfPixelsToMove = 10;//numberOfTextLinesToMove * Convert.ToInt32(control.Font.Size);
                if (MailShowArea.VerticalScroll.Value - numberOfPixelsToMove < MailShowArea.VerticalScroll.Minimum)
                    MailShowArea.VerticalScroll.Value = MailShowArea.VerticalScroll.Minimum;
                else if (MailShowArea.VerticalScroll.Value - numberOfPixelsToMove > MailShowArea.VerticalScroll.Maximum)
                    MailShowArea.VerticalScroll.Value = MailShowArea.VerticalScroll.Maximum;
                else
                    MailShowArea.VerticalScroll.Value -= numberOfPixelsToMove;
            }
        }

        private void Close_BT_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Hey, " + DisplayName + "! Do you want to close WorkSpace now?",
                "CLOSE WORKSPACE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes != ask)
                return;
            Operations.GlobalVarriable.ListOfActiveAccounts.Remove(MailAdress);
            Close();
        }

        private void Minimize_BT_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            Operations.GlobalVarriable.ListOfActiveAccounts.Remove(MailAdress);
            this.Close();
        }

        private void COMPOSER_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            CallShowWorkPlace(sender, e);
            ShowWork.Controls.Clear();
            if (IsShow == true)
                Avatar_Click(sender, e);
            Compose.Gmail Compose = new Compose.Gmail();
            Compose.SendClicked += new EventHandler(SendMailCall);
            Compose.Disposed += new EventHandler(FINISH_CONTROL);
            ShowWork.Controls.Add(Compose);
        }
        private void FINISH_CONTROL(object sender, EventArgs e)
        {
            if (Operations.Content.Message.ID == string.Empty)
                CallShowWorkPlace(sender, e);
            else
                CallHideWorkPlace(sender, e);

        }
        private void CallHideWorkPlace(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, EventArgs>(CallHideWorkPlace), new object[] { sender, e });
                return;
            }
            WorkPlace.Hide();
            if (MailContents.DocumentText != "")
                panel1.Show();
        }
        private void CallShowWorkPlace(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, EventArgs>(CallShowWorkPlace), new object[] { sender, e });
                return;
            }
            if (ShowWork.Controls.Count > 0)
                ShowWork.Controls.Clear();
            WelCome wc = new WelCome();
            wc.Wel_NewMail += new EventHandler(COMPOSER_Click);
            wc.Wel_UserContact += new EventHandler(ContactManagerShow);
            wc.Wel_GUI += new EventHandler(GUIDEshow);
            ShowWork.Controls.Add(wc);
            WorkPlace.Show();
            WorkPlace.Size = panel6.Size;
            WorkPlace.BringToFront();
        }
        private void CallSendFunction()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(CallSendFunction));
                return;
            }
            if (Compose.Send.OK())
            {
                SendingIconHide();
                SuccessBox.Show("Message sent!");
            }
            else
            {
                SendingIconHide();
                FailBox.Show();
            }
        }
        private void SendMailCall(object sender, EventArgs e)
        {
            SendingIconShow();
            System.Threading.Thread Thread = new System.Threading.Thread(new ThreadStart(
                CallSendFunction));
            Thread.Start();
        }
        private delegate void SetMessageCallback();
        public void LoadShow()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LoadShow));
                return;
            }
            Load_.Show();

        }
        public void LoadHide()
        {
            if (this.IsDisposed)
                return;
            if (InvokeRequired)
            {
                Invoke(new Action(LoadHide));
                return;
            }
            Load_.Hide();
        }
        string PreviousMsg = string.Empty;
        private void CallChangeChooedMail()
        {
            if (this.IsDisposed)
                return;
            if (InvokeRequired)
            {
                Invoke(new Action(CallChangeChooedMail));
                return;
            }
            if (MailShowArea.Controls.ContainsKey(PreviousMsg))
                MailShowArea.Controls[PreviousMsg].TabIndex++;
            PreviousMsg = Operations.Content.Message.ID;
        }
        private void Msg_Click(object sender, EventArgs e)
        {
            CallChangeChooedMail();
            CallHideWorkPlace(sender, e);
            LoadMailShowShow();
            panel1.Show();
            System.Threading.Thread LoadContentOfMail = new System.Threading.Thread(
                new System.Threading.ThreadStart(LoadMsgContent));
            LoadContentOfMail.Start();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            // check
            if (Operations.Content.Message.ID == String.Empty)
            {
                MessageBox.Show("Sorry! You must choose a message before do this task!",
                    "CHOOSE A MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EnterKey KeyIn = new EnterKey();
            KeyIn.ShowDialog();
            if (String.IsNullOrEmpty(Operations.Content.Message.CurrentPassword))
            {
                MessageBox.Show("Not entered a password yet!",
                    "NO PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #region Decrypt option
            string Res = string.Empty;
            switch (Operations.GlobalVarriable.KindOfCrypt)
            {
                case 0:
                    {
                        Res = Operations.AES.Decrypt(MailContents.DocumentText, Operations.Content.Message.CurrentPassword);
                        break;
                    }
                case 1:
                    {
                        Res = Operations.DES.Decrypt(MailContents.DocumentText, Operations.Content.Message.CurrentPassword);
                        break;
                    }
                case 2:
                    {
                        Res = Operations.TwoFish.Decrypt(MailContents.DocumentText, Operations.Content.Message.CurrentPassword);
                        break;
                    }
                case 3:
                    {
                        Res = Operations.BlowFish.Decrypt(MailContents.DocumentText, Operations.Content.Message.CurrentPassword);
                        break;
                    }
                default:
                    Res = Operations.AES.Decrypt(MailContents.DocumentText, Operations.Content.Message.CurrentPassword);
                    break;
            }
            #endregion
            if (Res == string.Empty)
            {
                Dialog.ErrorDialog error = new Dialog.ErrorDialog("Wrong password!");
                error.ShowDialog();
                return;
            }
            MailContents.DocumentText = Res;
            Decrypt.Enabled = false;
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            MailShowArea.Focus();
            Operations.Content.Message.ID = string.Empty;
            MailSubject.Text = "Let's work with Secure Mail!";
            Sender.Text = "You will always safe!";
            DateTimeRecived.Text = DateTime.Now.ToString();
            Decrypt.Enabled = false;
            SenderAvatar.Image = Properties.Resources.hello_1;
            panel1.Hide();
            CallShowWorkPlace(sender, e);
        }

        private void DeleteMsg_Click(object sender, EventArgs e)
        {
            // check
            if (Operations.Content.Message.ID == String.Empty)
            {
                MessageBox.Show("Sorry! You must choose a message before do this task!",
                    "CHOOSE A MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DialogResult askX = MessageBox.Show("Delete '" + MailSubject.Text + "'?",
                    "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.No == askX)
                    return;
                Operations.Gmail.Connect.service.Users.Messages.Delete("me", Operations.Content.Message.ID).Execute();
                MailShowArea.Controls.RemoveByKey(Operations.Content.Message.ID);
                UpdateWorkShowSize(sender, e);
                BACK_Click(sender, e);
                LoadShow();
                MailsCount--;
                UpdateMailCount();
                SuccessBox.Show("Successfully Deleted!");
            }
            catch (Exception)
            {
                FailBox.Show();
            }
            LoadHide();
        }

        private void FlagMsg_Click(object sender, EventArgs e)
        {
            // check
            if (Operations.Content.Message.ID == String.Empty)
            {
                MessageBox.Show("Sorry! You must choose a message before do this task!",
                    "CHOOSE A MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IList<String> LabelsToRemove = new List<String>();
            IList<String> LabelsToAdd = new List<String>();
            if (Operations.Content.Message.Properties.IndexOf("UNREAD") != -1)
            {
                Operations.Content.Message.Properties.Remove("UNREAD");
                LabelsToRemove.Add("UNREAD");
            }
            if (Operations.Content.Message.Properties.IndexOf("IMPORTANT") == -1)
            {
                DialogResult ask = MessageBox.Show("Do you want mark this message IMPORTANT?",
                    "ADD IMPORTANT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.No)
                    return;
                LabelsToAdd.Add("IMPORTANT");
                try
                {
                    Operations.Options.MODIFY(LabelsToAdd, LabelsToRemove, Operations.Content.Message.ID);
                    Operations.Content.Message.Properties.Add("IMPORTANT");
                    MessageBox.Show("Marked this message IMPORTANT!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fail! Have some problem when do this work!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                DialogResult ask = MessageBox.Show("Do you want unmark this message IMPORTANT?",
                    "REMOVE IMPORTANT?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.No)
                    return;
                LabelsToRemove.Add("IMPORTANT");
                try
                {
                    Operations.Options.MODIFY(LabelsToAdd, LabelsToRemove, Operations.Content.Message.ID);
                    Operations.Content.Message.Properties.Remove("IMPORTANT");
                    MessageBox.Show("Remove IMPORTANT success!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fail! Have some problem when do this work!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MailShowArea.Controls[Operations.Content.Message.ID].TabIndex++;
        }
        bool IsShow = false;
        private void Avatar_Click(object sender, EventArgs e)
        {
            if (IsShow == false)
            {
                Avatar.Image = Properties.Resources.menu;
                UserName.Text = "SELECT YOUR OPTION";
                DropdownShow.Show(OptionsBox);
                IsShow = true;
            }
            else
            {
                Avatar.Image = AvatarX;
                UserName.Text = DisplayName;
                DropdownShow.Hide(OptionsBox);
                IsShow = false;
            }

        }
        private void WorkSpace_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancel Thread
            if (LoadMessage != null)
            {
                LoadMessage.Abort();
                LoadMessage.DisableComObjectEagerCleanup();
                LoadMessage = null;
            }
            // Show home page again before close
            foreach (Form OpenForm in Application.OpenForms)
            {
                if (OpenForm.Name == HomeName)
                {
                    OpenForm.Show();
                }
            }
        }
        #endregion
        // Save Mail ID, which wass added to list
        IList<String> AddedMailId = new List<string>();
        private EventWaitHandle WaitHandle = new AutoResetEvent(false);
        // Count alls mail in the inbox
        int MailsCount = 0;
        private void UpdateIfEmpty()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateIfEmpty));
                return;
            }
            if (KindOfSelect == 1)
                MailBoxName.Text = "INBOX EMPTY";
            else if (KindOfSelect == 2)
                MailBoxName.Text = "SENT EMPTY";
            else if (KindOfSelect == 3)
                MailBoxName.Text = "DRAFTS EMPTY";
            else if (KindOfSelect == 4)
                MailBoxName.Text = "NO RESULT FOR '" + CurrentSearch + "'";
            LoadHide();
            BACK_Click(null, EventArgs.Empty);
        }
        void InsertMailMessageOfGmail()
        {
            int LoadedCount = 0;
            #region Check and out
            LoadShow();
            // Check, if coonect is fail -> out
            if (ConnectStatus == false)
            {
                Dialog.ErrorDialog Error = new Dialog.ErrorDialog("Connect to Gmail Fail! Please try again!");
                Error.ShowDialog();
                return;
            }
            // Check connection
            if (CheckConnection.Check() == false)
            {
                LoadHide();
                UpdateMailCount();
                ShowNetWorkError = true;
                DialogResult Accept = MessageBox.Show("Please check your connection! And Reload!",
                    "CONNECTION ERROR!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                if (Accept == DialogResult.OK)
                    ShowNetWorkError = false;
                return;
            }

            MailsCount = Operations.Gmail.Load.CountMails(KindOfSelect);
            if (MailsCount < 1 && KindOfSelect != 4)
            {
                UpdateIfEmpty();
                return;
            }
            UpdateMailCount();
            #endregion  
            // Request INBOX
            ListMessagesResponse MsgResult = new ListMessagesResponse();
            if (KindOfSelect == 1)
                MsgResult = Operations.Gmail.Load.Inbox();
            else if (KindOfSelect == 2)
                MsgResult = Operations.Gmail.Load.Sent();
            else if (KindOfSelect == 3)
                MsgResult = Operations.Gmail.Load.Drafts();
            else if (KindOfSelect == 4)
                MsgResult = Operations.Gmail.Load.Search(SearchBox.Text);
            else
            {
                MessageBox.Show("????????????", "??????", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MsgResult == null)
            {
                UpdateIfEmpty();
                return;
            }
            // Insert Data to it
            if (MsgResult.Messages != null)
            {
                if (KindOfSelect == 4)
                {
                    MailsCount = MsgResult.Messages.Count;
                    UpdateMailCount();
                }
                foreach (var email in MsgResult.Messages)
                {
                    #region Check conection and check haved mails
                    // Check connection
                    if (CheckConnection.Check() == false)
                    {
                        if (ShowNetWorkError == true)
                            return;
                        LoadHide();
                        UpdateMailCount();
                        ShowNetWorkError = true;
                        DialogResult Accept = MessageBox.Show(" ## Please check your connection! And Reload!",
                            "CONNECTION ERROR!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        if (Accept == DialogResult.OK)
                            ShowNetWorkError = false;
                        return;
                    }
                    // Do the work
                    if (AddedMailId.IndexOf(email.Id) != -1)
                        continue;
                    else
                        AddedMailId.Add(email.Id);
                    #endregion
                    Google.Apis.Gmail.v1.Data.Message EmailInfoRes;
                    try
                    {
                        Google.Apis.Gmail.v1.UsersResource.MessagesResource.GetRequest EmailInfoReq = Operations.Gmail.Connect.service.Users.Messages.Get("me", email.Id);
                        EmailInfoRes = EmailInfoReq.Execute();
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                    IList<string> Propeties = new List<string>();
                    Propeties = EmailInfoRes.LabelIds;
                    if (EmailInfoRes != null)
                    {
                        #region For get attachment name
                        string Attachment = String.Empty;
                        if (EmailInfoRes.Payload.Parts != null)
                            foreach (MessagePart part in EmailInfoRes.Payload.Parts)
                            {
                                if (!String.IsNullOrEmpty(part.Filename))
                                    Attachment += part.Filename + "|" + part.Body.AttachmentId + "||";
                            }
                        #endregion
                        // Get mail properties
                        String from = String.Empty;
                        String date = String.Empty;
                        String subject = String.Empty;
                        // Get Header
                        foreach (var need in EmailInfoRes.Payload.Headers)
                        {
                            if (need.Name == "Date")
                            {
                                date = need.Value;
                            }
                            else if (need.Name == "From" && KindOfSelect != 2)
                            {
                                from = need.Value;
                            }
                            else if (need.Name == "To" && KindOfSelect == 2)
                            {
                                from = need.Value;
                            }
                            else if (need.Name == "Subject")
                            {
                                subject = need.Value;
                            }
                        }
                        string[] Name_Mail = from.Split('<');
                        if (Name_Mail.Length < 2)
                        {
                            Name_Mail = new string[2];
                            Name_Mail[0] = Name_Mail[1] = from;
                        }
                        else
                        {
                            try
                            {
                                Name_Mail[0] = Name_Mail[0].Substring(0, Name_Mail[0].Length - 1);
                                Name_Mail[1] = Name_Mail[1].Substring(0, Name_Mail[1].Length - 1);
                            }
                            catch (Exception)
                            {
                                // 
                            }
                        }
                        // GET sender avatar
                        Image AvatarSender;
                        if (Name_Mail[1].IndexOf("@gmail.com") != -1)
                        {
                            try
                            {
                                // Request to get User Avatar
                                string url = "https://pikmail.herokuapp.com/" + Name_Mail[1] + "?size=40";
                                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                                request.AutomaticDecompression = DecompressionMethods.GZip;
                                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                                {
                                    // Read Stream respone and convert to Image
                                    using (Stream stream = response.GetResponseStream())
                                        AvatarSender = Image.FromStream(stream);
                                }

                            }
                            catch (Exception)
                            {
                                AvatarSender = Properties.Resources.user;
                            }
                        }
                        else
                        {
                            AvatarSender = Properties.Resources.user;
                        }
                        //Add to list message view
                        if ((LoadedCount) % NumloadPerTime == 0 && LoadedCount != 0 && MailShowArea.VerticalScroll.Visible == true)
                        {
                            LoadHide();
                            return;
                        }
                        else
                        {
                            AddRecord(Name_Mail, AvatarSender, subject, date, email.Id, Propeties, Attachment);
                            LoadedCount++;
                        }
                    }
                }
            }
            LoadHide();
            if (NumloadPerTime != 2)
                NumloadPerTime = 2;
        }
        private void UpdateMailCount()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateMailCount));
                return;
            }
            if (KindOfSelect == 1)
                MailBoxName.Text = "INBOX (" + MailsCount.ToString() + ")";
            else if (KindOfSelect == 2)
                MailBoxName.Text = "SENT (" + MailsCount.ToString() + ")";
            else if (KindOfSelect == 3)
                MailBoxName.Text = "DRAFT (" + MailsCount.ToString() + ")";
            else if (KindOfSelect == 4)
                MailBoxName.Text = "'" + CurrentSearch + "' (" + MailsCount.ToString() + ")";
        }
        #region For INBOX
        public void AddRecord(string[] _Name_Mail, Image _AvatarSender, string _subject, string _date,
            string _EmailID, IList<string> _Propeties, string _Attachment)
        {
            if (this.IsDisposed)
                return;
            if (InvokeRequired)
            {
                Invoke(new Action<string[], Image, string, string, string, IList<string>, string>(AddRecord),
                    new object[] { _Name_Mail, _AvatarSender, _subject, _date, _EmailID, _Propeties, _Attachment });
                return;
            }
            Record AddRecordX = new Record(_Name_Mail, _AvatarSender, _subject, _date, _EmailID, _Propeties, _Attachment);
            AddRecordX.MsgClick += new EventHandler(Msg_Click);
            AddRecordX.Name = _EmailID;
            AddRecordX.Disposed += new EventHandler(UpdateWorkShowSize);
            AddRecordX.MouseMove += new MouseEventHandler(FakeScroll);
            AddRecordX.MouseWheel += new MouseEventHandler(FakeScroll);
            MailShowArea.Controls.Add(AddRecordX);
            if (MailShowArea.VerticalScroll.Visible == true)
                ShowMailList.Width = 300;
            else
                ShowMailList.Width = 300 - 19;
        }
        private void UpdateWorkShowSize(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, EventArgs>(UpdateWorkShowSize), new object[] { sender, e });
                return;
            }
            // Update MailShow
            if (MailShowArea.VerticalScroll.Visible == true)
                ShowMailList.Width = 300;
            else
                ShowMailList.Width = 300 - 19;
            // Update Panel6
            panel6.Dock = DockStyle.Fill;
        }
        private void FakeScroll(object sender, MouseEventArgs e)
        {
            if ((LoadMessage != null && LoadMessage.ThreadState == ThreadState.Running) || MailShowArea.Controls.Count == MailsCount - 2)
                return;
            int Res = (int)Math.Round((
                (float)MailShowArea.VerticalScroll.Value /
                (float)(MailShowArea.VerticalScroll.Maximum - MailShowArea.VerticalScroll.LargeChange + 1)) * 100
                );
            if (Res > 70)
            {
                LoadMessage = new System.Threading.Thread(
                    new ThreadStart(InsertMailMessageOfGmail));
                LoadMessage.Start();
            }
        }
        private void MailShowArea_Scroll(object sender, ScrollEventArgs e)
        {
            if (LoadMessage != null && LoadMessage.ThreadState == ThreadState.Running)
                return;
            VScrollProperties vs = MailShowArea.VerticalScroll;
            if (e.NewValue == vs.Maximum - vs.LargeChange + 1)
            {
                LoadMessage = new System.Threading.Thread(
                    new ThreadStart(InsertMailMessageOfGmail));
                LoadMessage.Start();
            }
        }
        SaveMail SaveMailNow = new SaveMail();
        // When User click to Msg :))
        private void LoadMsgContent()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LoadMsgContent));
                return;
            }
            AttachmentPanel.Controls.Clear();
            SaveMailNow = new SaveMail();
            back_button.Enabled = true;
            MailContents.DocumentText = string.Empty;
            if (KindOfSelect != 2)
                Sender.Text = "From: " + Operations.Content.Sender.Email;
            else
                Sender.Text = "To: " + Operations.Content.Sender.Email;
            if (Operations.Content.Message.Subject.Length > 70)
                MailSubject.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            else
                if (Operations.Content.Message.Subject.Length > 100)
                MailSubject.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            MailSubject.Text = Operations.Content.Message.Subject;
            DateTimeRecived.Text = Operations.Content.Message.Date;
            string body = Operations.Fast.GetBody(Operations.Content.Message.ID);
            MailContents.DocumentText = body;
            if (String.IsNullOrEmpty(body) || String.IsNullOrWhiteSpace(body))
            {
                Decrypt.Enabled = false;
                WorkSpaceStartTransition.Hide(Decrypt);
                panel14.Hide();
            }
            else
                try
                {
                    var Temp = Convert.FromBase64String(body);
                    WorkSpaceStartTransition.Show(Decrypt);
                    panel14.Show();
                    Decrypt.Enabled = true;
                }
                catch (Exception)
                {
                    Decrypt.Enabled = false;
                    WorkSpaceStartTransition.Hide(Decrypt); panel14.Hide();
                }
            SenderAvatar.Image = Operations.Content.Sender.Avatar;
            if (String.IsNullOrEmpty(Operations.Content.Message.Attachments))
                HideAttPanel();
            else
            {
                foreach (String att in Operations.Content.Message.Attachments.Split(new string[] { "||" }, StringSplitOptions.None))
                {
                    if (!att.Contains("|"))
                        continue;
                    InsertToAttPanel(att.Split('|')[0], att.Split('|')[1], Decrypt.Enabled);
                }
                if (AttachmentPanel.Controls.Count > 0)
                    ShowAttPanel();
            }
            // check
            LoadMailShowHide();
            #region Area repare for save mail
            SaveMailNow.Reset();
            SaveMailNow.Set(Operations.Content.Sender.Email,
                Operations.Content.Message.Subject,
                Operations.Content.Message.Date,
                body,
                Operations.Content.Sender.Avatar);
            #endregion
            // if unread, marked it as read
            if (Operations.Content.Message.Properties.IndexOf("UNREAD") != -1)
            {
                IList<String> LabelsToRemove = new List<String>();
                IList<String> LabelsToAdd = new List<String>();
                LabelsToRemove.Add("UNREAD");
                Operations.Content.Message.Properties.Remove("UNREAD");
                MailShowArea.Controls[Operations.Content.Message.ID].TabIndex++;
                try
                {
                    Operations.Options.MODIFY(LabelsToAdd, LabelsToRemove, Operations.Content.Message.ID);
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
        private void INBOX_Click(object sender, EventArgs e)
        {
            if (LoadMessage != null)
            {
                LoadMessage.Abort();
                LoadMessage.DisableComObjectEagerCleanup();
                LoadMessage = null;
            }
            if (KindOfSelect != 1)
            {
                panel1.Hide();
                // If not of INBOX -> Clear all logrecord
                KindOfSelect = 1;
                AddedMailId.Clear();
                MailBoxName.Text = "LOADDING...";
                // Clear Follow
                MailShowArea.Controls.Clear();
                BACK_Click(sender, e);
            }
            LoadMessage = new System.Threading.Thread(
                new ThreadStart(InsertMailMessageOfGmail));
            LoadMessage.Start();
            Avatar_Click(sender, e);
        }
        #endregion
        #region For SENT
        private void _SENT_Click(object sender, EventArgs e)
        {
            if (LoadMessage != null)
            {
                LoadMessage.Abort();
                LoadMessage.DisableComObjectEagerCleanup();
                LoadMessage = null;
            }
            if (KindOfSelect != 2)
            {
                panel1.Hide();
                // If not SENT mail
                KindOfSelect = 2;
                AddedMailId.Clear();
                MailBoxName.Text = "LOADDING...";
                // Clear Follow
                MailShowArea.Controls.Clear();
                BACK_Click(sender, e);
            }
            LoadMessage = new System.Threading.Thread(
            new ThreadStart(InsertMailMessageOfGmail));
            LoadMessage.Start();
            Avatar_Click(sender, e);
        }

        #endregion
        #region For DRAFTS
        private void _DRAFTS_Click(object sender, EventArgs e)
        {
            if (LoadMessage != null)
            {
                LoadMessage.Abort();
                LoadMessage.DisableComObjectEagerCleanup();
                LoadMessage = null;
            }
            if (KindOfSelect != 3)
            {
                panel1.Hide();
                // If not DRAFTS
                KindOfSelect = 3;
                AddedMailId.Clear();
                MailBoxName.Text = "LOADDING...";
                // Clear Follow
                MailShowArea.Controls.Clear();
                BACK_Click(sender, e);
            }
            LoadMessage = new System.Threading.Thread(
            new ThreadStart(InsertMailMessageOfGmail));
            LoadMessage.Start();
            Avatar_Click(sender, e);
        }
        #endregion
        private void StarMsg_Click(object sender, EventArgs e)
        {
            // check
            if (Operations.Content.Message.ID == String.Empty)
            {
                MessageBox.Show("Sorry! You must choose a message before do this task!",
                    "CHOOSE A MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IList<String> LabelsToRemove = new List<String>();
            IList<String> LabelsToAdd = new List<String>();
            if (Operations.Content.Message.Properties.IndexOf("UNREAD") != -1)
            {
                LabelsToRemove.Add("UNREAD");
                Operations.Content.Message.Properties.Remove("UNREAD");
            }
            if (Operations.Content.Message.Properties.IndexOf("STARRED") == -1)
            {
                DialogResult ask = MessageBox.Show("Do you want mark this message STARRED?",
                    "ADD STARRED?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.No)
                    return;
                LabelsToAdd.Add("STARRED");
                try
                {
                    Operations.Options.MODIFY(LabelsToAdd, LabelsToRemove, Operations.Content.Message.ID);
                    Operations.Content.Message.Properties.Add("STARRED");
                    MessageBox.Show("Marked this message STARRED!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fail! Have some problem when do this work!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                DialogResult ask = MessageBox.Show("Do you want unmark this message STARRED?",
                    "REMOVE STARRED?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.No)
                    return;
                LabelsToRemove.Add("STARRED");
                try
                {
                    Operations.Options.MODIFY(LabelsToAdd, LabelsToRemove, Operations.Content.Message.ID);
                    Operations.Content.Message.Properties.Remove("STARRED");
                    MessageBox.Show("Remove STARRED success!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Fail! Have some problem when do this work!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MailShowArea.Controls[Operations.Content.Message.ID].TabIndex++;
        }

        private void SaveMsg_Click(object sender, EventArgs e)
        {
            #region check
            if (Operations.Content.Message.ID == String.Empty)
            {
                MessageBox.Show("Sorry! You must choose a message before do this task!",
                    "CHOOSE A MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult Ask = MessageBox.Show("The mail will be saved in encrypted form if it was encrypted before!",
                "SAVE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Ask == DialogResult.No)
                return;
            #endregion
            try
            {
                if (String.IsNullOrEmpty(Encoding.UTF8.GetString(SaveMailNow.Get())) ||
                    String.IsNullOrWhiteSpace(Encoding.UTF8.GetString(SaveMailNow.Get())))
                {
                    MessageBox.Show("Can not save 2 times in a row! If you want, Please Reload...", "STOP!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can not save 2 times in a row! If you want, Please Reload...", "STOP!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveFileDialog ChoosePath = new SaveFileDialog();
            ChoosePath.SupportMultiDottedExtensions = false;
            ChoosePath.OverwritePrompt = true;
            ChoosePath.Title = "SAVE MAIL";
            ChoosePath.Filter = "TNsoft (IATT & NGHIA file)|*.tnsoft";
            ChoosePath.ShowDialog();
            if (string.IsNullOrEmpty(ChoosePath.FileName) || string.IsNullOrWhiteSpace(ChoosePath.FileName))
            {
                MessageBox.Show("Cancel action!", "FINISH", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                using (FileStream fs = (FileStream)ChoosePath.OpenFile())
                {
                    SaveMailNow.Get();
                    fs.Write(SaveMailNow.Get(), 0, SaveMailNow.Get().Length);
                    fs.Close();
                }
                if (ChoosePath.CheckPathExists == true)
                {
                    try
                    {
                        // Repare the path
                        if (!Directory.Exists(Path.GetDirectoryName(ListOfPath.SavedMailLogs)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(ListOfPath.SavedMailLogs));
                        }
                        File.AppendAllText(ListOfPath.SavedMailLogs, Convert.ToBase64String(Encoding.UTF8.GetBytes(ChoosePath.FileName)) + "\r\n");
                    }
                    catch (Exception ok)
                    {
                        MessageBox.Show("#1. Please try run this program with Administration permission!", "PERMISSION DENIED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(ok.ToString());
                        File.Delete(ChoosePath.FileName);
                        return;
                    }
                    MessageBox.Show("Saved success!", "SUCCESS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveMailNow.Reset();
                    return;
                }
                else
                {
                    MessageBox.Show("#2. Please try run this program with Administration permission!", "PERMISSION DENIED!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not finish save this mail! Please check again!",
                    "SAVE FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
                return;
            }

            #region Save

            #endregion
        }

        #region For Check New Mail Inbox

        private void Reload(bool KeepCurrent)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(Reload), new object[] { KeepCurrent });
                return;
            }
            if (LoadMessage != null)
            {
                LoadMessage.Abort();
                LoadMessage.DisableComObjectEagerCleanup();
                LoadMessage = null;
            }
            if (KeepCurrent == false)
                KindOfSelect = 1;
            AddedMailId.Clear();
            MailBoxName.Text = "LOADDING...";
            // Clear Follow
            MailShowArea.Controls.Clear();
            BACK_Click(null, EventArgs.Empty);
            LoadMessage = new System.Threading.Thread(
                new ThreadStart(InsertMailMessageOfGmail));
            LoadMessage.Start();
        }
        int CurrentCount = -1;
        private void RunningForCheckInbox()
        {
            if (Operations.Gmail.Load.StopForNewMail == true)
                return;
            int Count = Operations.Gmail.Load.CountMails(1);
            if (Count == 0)
                return;
            if (CurrentCount == -1)
            {
                CurrentCount = Count;
                return;
            }
            if (Count > CurrentCount)
            {
                Operations.Gmail.Load.StopForNewMail = true;
                DialogResult ask = MessageBox.Show("You have " + (Count - CurrentCount).ToString() + " new mail(s)! Reload INBOX to check now!",
                    "HAVE NEW MAIL(S)!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                CurrentCount = Count;
                if (ask == DialogResult.No)
                {
                    Operations.Gmail.Load.StopForNewMail = false;
                    return;
                }
                Reload(false);
                Operations.Gmail.Load.StopForNewMail = false;
            }
            CurrentCount = Count;
        }
        System.Threading.Thread ThreadForCheck;
        private void CheckNewMailINBOX(object sender, EventArgs e)
        {
            if (Operations.Gmail.Load.StopForNewMail == true)
            {
                if (ThreadForCheck != null)
                {
                    if (ThreadForCheck.ThreadState == ThreadState.Running)
                    {
                        ThreadForCheck.Abort();
                        ThreadForCheck = null;
                        return;
                    }
                }
                else
                    return;
            }
            try
            {
                if (ThreadForCheck.ThreadState == ThreadState.Running)
                    return;
            }
            catch (Exception)
            {
                // Nothing
            }
            ThreadForCheck = new System.Threading.Thread(new
                System.Threading.ThreadStart(RunningForCheckInbox));
            ThreadForCheck.Start();
        }
        #endregion

        bool ShowNetWorkError = false;
        private void _Reload_Click(object sender, EventArgs e)
        {
            if (ShowNetWorkError == true)
                return;
            // Check connection
            if (CheckConnection.Check() == false)
            {
                ShowNetWorkError = true;
                DialogResult Accept = MessageBox.Show("Please check your connection!",
                    "CONNECTION ERROR!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                if (Accept == DialogResult.OK)
                    ShowNetWorkError = false;
                return;
            }
            panel1.Hide();
            System.Threading.Thread ReloadThread = new System.Threading.Thread(
                () => Reload(true));
            ReloadThread.Start();
            Avatar_Click(sender, e);
        }
        #region LoadMailShowPicture
        private void LoadMailShowHide()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LoadMailShowHide));
                return;
            }
            LoadMailShowPicture.Hide();
        }
        private void LoadMailShowShow()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LoadMailShowShow));
                return;
            }
            LoadMailShowPicture.Show();
        }
        #endregion
        #region Sending load Icon
        private void SendingIconHide()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(SendingIconHide));
                return;
            }
            Sending_.Hide();
        }
        private void SendingIconShow()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(SendingIconShow));
                return;
            }
            Sending_.Show();
        }
        #endregion
        #region Attachments Panel
        private void ShowAttPanel()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ShowAttPanel));
                return;
            }
            if (AttachmentPanel.HorizontalScroll.Visible == false)
                AttachmentPanelX.Height = 80 - 19;
            else
                AttachmentPanelX.Height = 80;
            AttachmentPanelX.Show();
        }
        private void HideAttPanel()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(HideAttPanel));
                return;
            }
            AttachmentPanelX.Hide();
            AttachmentPanelX.Height = 0;
            AttachmentPanel.Controls.Clear();
        }
        private void InsertToAttPanel(string FileName, string AttID, bool _IsEncrypted)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string, string, bool>(InsertToAttPanel), new object[] { FileName, AttID, _IsEncrypted });
                return;
            }
            Attachment att = new Attachment(FileName, AttID, _IsEncrypted);
            AttachmentPanel.Controls.Add(att);
        }
        #endregion
        #region For Reply
        Compose.Gmail ReplyKZ;
        private void Reply_Click(object sender, EventArgs e)
        {
            // check
            if (Operations.Content.Message.ID == String.Empty)
            {
                MessageBox.Show("Sorry! You must choose a message before do this task!",
                    "CHOOSE A MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            panel1.Hide();
            CallShowWorkPlace(sender, e);
            ShowWork.Controls.Clear();
            ReplyKZ = new Compose.Gmail(Operations.Content.Sender.Email, "Re: \"" + Operations.Content.Message.Subject + "\"");
            ReplyKZ.SendClicked += new EventHandler(SendMailCall);
            ReplyKZ.Disposed += new EventHandler(CallHideWorkPlace);
            ShowWork.Controls.Add(ReplyKZ);
        }
        #endregion
        private void panel6_SizeChanged(object sender, EventArgs e)
        {
            WorkPlace.Location = panel6.Location;
            WorkPlace.Size = panel6.Size;
        }

        #region Fro Avatar Effect
        private void Avatar_MouseMove(object sender, MouseEventArgs e)
        {
            Avatar.Image = Properties.Resources.menu;
        }

        private void Avatar_MouseLeave(object sender, EventArgs e)
        {
            if (IsShow == false)
                Avatar.Image = AvatarX;
        }
        #endregion
        #region For Forward
        bool ForwardStatus = false;
        private void Forward_Click(object sender, EventArgs e)
        {
            // check
            if (Operations.Content.Message.ID == String.Empty)
            {
                MessageBox.Show("Sorry! You must choose a message before do this task!",
                    "CHOOSE A MESSAGE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ForwardStatus == false)
            {
                MailList.Clear();
                Fr.Width = 233;
                DropdownShow.Show(Fr);
                Fr.BringToFront();
                ForwardStatus = true;
            }
            else
            {
                DialogResult ask = MessageBox.Show("Cancel Forward?", "CANCEL?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.No)
                    return;
                Fr.Width = 0;
                DropdownShow.Hide(Fr);
                ForwardStatus = false;
            }
        }
        List<string> MailList = new List<string>();
        private void GetListMailFromBox(object sender, EventArgs e)
        {
            DropdownShow.Hide(Fr);
            ForwardStatus = false;
            if (Fr.ListMail.Count == 0)
            {
                MessageBox.Show("Forward cancel", "FINISH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (string MailAddress in Fr.ListMail)
            {
                MailList.Add(MailAddress);
            }
            Fr.ListMail.Clear();
            System.Threading.Thread SendFwdX = new System.Threading.Thread(
                new ThreadStart(SenForward));
            SendFwdX.Start();
            return;
        }
        private void SenForward()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(SenForward));
                return;
            }
            GmailForward GmailFwd = new GmailForward();
            if (GmailFwd.Send(MailList, MailContents.DocumentText))
            {
                SuccessBox.Show("Successfully Forwarded!");
            }
            else
            {
                FailBox.Show();
            }
        }
        #endregion
        private void ContactManagerShow(object sender, EventArgs e)
        {
            panel1.Hide();
            CallShowWorkPlace(sender, e);
            ShowWork.Controls.Clear();
            if (IsShow == true)
                Avatar_Click(sender, e);
            ContactManager ContactNow = new ContactManager();
            ContactNow.Disposed += new EventHandler(FINISH_CONTROL);
            ContactNow.ChooedSendMail += new EventHandler(COMPOSER_Click);
            ShowWork.Controls.Add(ContactNow);
            return;
        }
        private void GUIDEshow(object sender, EventArgs e)
        {
            MessageBox.Show("GUIDE not support now!");
            return;
        }

        #region For Search
        private string CurrentSearch = string.Empty;
        private void SearchBox_Leave(object sender, EventArgs e)
        {
            SearchBox.Text = "Search your mail...";
        }

        private void SearchBox_TabStopChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == "Search your mail...")
                SearchBox.Text = "";
            else
                SearchBox.Text = "Search your mail...";
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
            if (IsShow)
                Avatar_Click(sender, e);
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CurrentSearch = SearchBox.Text;
                SearchRunCall(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                SearchBox.Text = "Search your mail...";
                ShowMailList.Focus();
            }
        }

        private void SearchRunCall(object sender, EventArgs e)
        {
            if (LoadMessage != null)
            {
                LoadMessage.Abort();
                LoadMessage.DisableComObjectEagerCleanup();
                LoadMessage = null;
            }
            panel1.Hide();
            // If not DRAFTS
            KindOfSelect = 4;
            AddedMailId.Clear();
            MailBoxName.Text = "SEARCHING...";
            // Clear Follow
            MailShowArea.Controls.Clear();
            BACK_Click(sender, e);
            LoadMessage = new System.Threading.Thread(
            new ThreadStart(InsertMailMessageOfGmail));
            LoadMessage.Start();
        }
        private void SearchBox_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBox.Text = "";
            if (IsShow)
                Avatar_Click(sender, e);
        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {
            SearchBox.Text = "";
            if (IsShow)
                Avatar_Click(sender, e);
        }
        #endregion

        private void ShowWork_Paint(object sender, PaintEventArgs e)
        {
            if (IsShow)
                Avatar_Click(sender, e);
        }
    }
}