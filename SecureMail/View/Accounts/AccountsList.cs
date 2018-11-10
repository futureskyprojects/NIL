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

namespace SecureMail
{
    public partial class AccountsList : UserControl
    {
        public AccountsList()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            ListOfAccount.Controls.Clear();
            // Get folder path of application
            Operations.GlobalVarriable.RootPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            // check area to save user data like token, infomations,...
            // If area exist 
            if (System.IO.Directory.Exists(Operations.GlobalVarriable.UserCombine))
            {
                // If Folder Exist, Continute check log file: Account.list
                if (System.IO.File.Exists(System.IO.Path.Combine(Operations.GlobalVarriable.UserCombine, "Account.list")))
                {
                    // If it exists, Load date from Account.list to MailsAddressList
                    string Temp = System.IO.File.ReadAllText(System.IO.Path.Combine(Operations.GlobalVarriable.UserCombine, "Account.list"));
                    string[] AddressList = Temp.Split(' ');
                    // If elment of AddressList lager than 0
                    if (AddressList.Length > 0)
                        // Then insert to MailsAddressList and MailAddress Panel
                        foreach (var Address in AddressList)
                        {
                            // A. Insert to Maildress Panel
                            // 1. Get This Mail Path where save info of this mail account
                            string ThisMailPath = System.IO.Path.Combine(Operations.GlobalVarriable.UserToken, Address);
                            // Check if ThisMailPath is exists or not
                            if (!System.IO.Directory.Exists(ThisMailPath))
                                // If not continue And don't insert to MailsAddress
                                continue;
                            // Read file inclue user data
                            string[] Data = new string[4];
                            try
                            {
                                if (System.IO.File.Exists(System.IO.Path.Combine(ThisMailPath, "Old.info")))
                                {
                                    string trashSTR = System.IO.File.ReadAllText(System.IO.Path.Combine(ThisMailPath, "Old.info"));
                                    Data = trashSTR.Split('|');
                                    Data[0] = Encoding.UTF8.GetString(Convert.FromBase64String(Data[0]));
                                }
                                else
                                    continue;
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                            Image avt;
                            // Add user data 
                            try
                            {
                                if (File.Exists(System.IO.Path.Combine(ThisMailPath, "Avatar.jpg")))
                                {
                                    using (FileStream fs = new FileStream(System.IO.Path.Combine(ThisMailPath, "Avatar.jpg"),FileMode.Open,FileAccess.Read))
                                    {
                                        avt = Image.FromStream(fs);
                                        fs.Close();
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        avt = Properties.Resources.user;
                                    }
                                    catch (Exception)
                                    {
                                        continue;
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    avt = Properties.Resources.user;
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                            }
                            AddAccount(Data[0], avt, Address, "0");
                        }
                    // And Update AccountsList
                    Operations.Fast.UpdateAccountsList();
                }
            }
            // Otherwise
            else
            {
                // Create User folder
                System.IO.Directory.CreateDirectory(Operations.GlobalVarriable.UserCombine);
            }

            if (Operations.GlobalVarriable.CountAccount > 0)
                HideEmpty();
        }
        private void HideEmpty()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(HideEmpty));
                return;
            }
            emptyX.Hide();
        }
        private void AddAccount(string _displayname, Image _avatar, string _mailaddress, string _unreadcounts)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string,Image,string,string>(AddAccount), new object[] { _displayname, _avatar, _mailaddress, _unreadcounts});
                return;
            }
            Accounts.AddNew add = new Accounts.AddNew(_displayname, _avatar, _mailaddress, _unreadcounts);
            add.Name = _mailaddress.Replace("@", "_").Replace(".", "_");
            ListOfAccount.Controls.Add(add);
            Operations.GlobalVarriable.MailsAddressList.Add(_mailaddress);
            emptyX.Hide();
        }
        public EventHandler DirectEvents;
        private void AddNewAccount_Click(object sender, EventArgs e)
        {
            // Annoucement when user got limit of mail accounts
            if (Operations.GlobalVarriable.CountAccount >= 6)
            {
                AddNewAccount.Hide();
                Dialog.WarnDialog NewWarn = new Dialog.WarnDialog("Sorry, but you got the limit of mail accounts.", "LIMIT OF ACCOUNT!");
                NewWarn.ShowDialog();
                return;
            }
            // Show Dialog to choose a mail accounts kind
            Dialog.SelectAccountsKind selectAccountsKind = new Dialog.SelectAccountsKind();
            selectAccountsKind.ReloadNow += new EventHandler(LoadAgain);
            selectAccountsKind.ShowDialog();
        }
        private void LoadAgain(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object,EventArgs>(LoadAgain), new object[] { sender,e });
                return;
            }
            // If user choose supported mail accounts kind
            if (Operations.GlobalVarriable.ChooseMailSuccess == true)
            {
                if (Operations.GlobalVarriable.AddAccountToPanel == true)
                {
                    emptyX.Hide();
                    Operations.GlobalVarriable.CountAccount++;
                    Accounts.AddNew Add = new Accounts.AddNew(Operations.Gmail.GmailAccountInfo.get.DisplayName, Operations.Gmail.GmailAccountInfo.get.Avatar, Operations.Gmail.GmailAccountInfo.get.Email, Operations.Gmail.GmailAccountInfo.get.Unread);
                    Add.UserClicked += new EventHandler(CallDirectEvent);
                    ListOfAccount.Controls.Add(Add);
                }
            }
            // If user choose unsupport mail account kind
            else
            {
                // Nothing here
            }
        }
        private void CallDirectEvent(object sender, EventArgs e)
        {
            if (DirectEvents != null)
                DirectEvents(sender, e);
        }
    }
}
