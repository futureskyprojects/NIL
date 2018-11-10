using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace SecureMail.Accounts
{
    public partial class AddNew : UserControl
    {
        string DisplayName;
        Image Avatar;
        string MailAdress;
        string UnreadCount;
        public AddNew(string _DisPlayName, Image _Avatar, string _MailAddress, string _UnreadCount)
        {
            DisplayName = _DisPlayName;
            Avatar = _Avatar;
            MailAdress = _MailAddress;
            UnreadCount = _UnreadCount;
            InitializeComponent();
        }
        public EventHandler UserClicked;
        private void AddNew_Load(object sender, EventArgs e)
        {
            AccountAvatar.Image = Avatar;
            AccountMailAddress.Text = MailAdress;
            try
            {
                if (Convert.ToInt32(UnreadCount) > 0)
                    Unread.Text = UnreadCount;
                else
                    Unread.Dispose();
            }
            catch (Exception)
            {
                Unread.Text = UnreadCount;
            }
        }

        private void AccountMailAddress_MouseUp(object sender, MouseEventArgs e)
        {
            AccountMailAddress.Text = DisplayName;
        }

        private void AccountMailAddress_MouseLeave(object sender, EventArgs e)
        {
            AccountMailAddress.Text = MailAdress;
        }
        private void AccountMailAddress_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult Res = MessageBox.Show("Delete this account from "+ProgramInfo.App.Name+"?", "Delete account?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Res == DialogResult.Yes)
                {
                    try
                    {
                        String PathImport = Path.Combine(Operations.GlobalVarriable.UserToken, MailAdress);
                        if (Directory.Exists(PathImport))
                        {
                            Dispose();
                            Directory.Delete(PathImport,true);
                            Operations.GlobalVarriable.MailsAddressList.Remove(MailAdress);
                            Operations.Fast.UpdateAccountsList();
                            SuccessBox.Show("Successfully deleted!");
                        }

                    }
                    catch (Exception)
                    {
                        FailBox.Show();
                    }
                }
            }
            else
            {
                if (UserClicked!=null)
                {
                    UserClicked(sender, e);
                }
                /////////
                String PathImport = System.IO.Path.Combine(Operations.GlobalVarriable.UserToken, MailAdress);
                if (System.IO.Directory.Exists(PathImport))
                {
                    Operations.GlobalVarriable.ListOfActiveAccounts.Add(MailAdress);
                    WorkSpace.WorkSpace WorkSpace = new WorkSpace.WorkSpace((String.IsNullOrEmpty(DisplayName) ? MailAdress : DisplayName)
                        , Avatar, MailAdress, PathImport);
                    WorkSpace.ShowDialog();
                }
                /////////
            }
        }
    }
}
