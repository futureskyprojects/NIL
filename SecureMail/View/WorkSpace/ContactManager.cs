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
using System.Threading;

namespace SecureMail.WorkSpace
{
    public partial class ContactManager : UserControl
    {
        public ContactManager()
        {
            InitializeComponent();
        }

        private void NewMailAddress_Click(object sender, EventArgs e)
        {
            NewMailAddress.Text = "";
        }

        private void NewMailAddress_TabStopChanged(object sender, EventArgs e)
        {
            NewMailAddress.Text = "";
        }

        private void NewMailAddress_Enter(object sender, EventArgs e)
        {
            NewMailAddress.Text = "";
        }

        private void NewMailAddress_Leave(object sender, EventArgs e)
        {
            NewMailAddress.Text = "Add new usually contact here...";
        }

        private void AddOptions_Click(object sender, EventArgs e)
        {
            // Check input
            if (String.IsNullOrEmpty(CurrentMailAddress) || String.IsNullOrWhiteSpace(CurrentMailAddress))
            {
                MessageBox.Show("Mailadress is empty!", "PLEASE INPUT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CurrentMailAddress.Contains("@") || CurrentMailAddress.Split('@').Length > 2 || !CurrentMailAddress.Split('@')[1].Contains('.'))
            {
                MessageBox.Show("Wrong email format!", "WRONG MAIL ADDRESS!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (char c in CurrentMailAddress)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    if (c == '.' || c == '_' || c == '@')
                        continue;
                    else
                    {
                        MessageBox.Show("this Mail Adress have special character!", "WRONG EMAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            Thread Update = new Thread(() => Contact_Update(sender, e, CurrentMailAddress));
            Update.Start();
            NewMailAddress.Text = "Add new usually contact here...";
        }
        string CurrentMailAddress = string.Empty;
        private void NewMailAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                NewMailAddress.Text = "Add new usually contact here...";
                MailList.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                CurrentMailAddress = NewMailAddress.Text;
                MailList.Focus();
                AddOptions_Click(sender, e);
            }

        }
        private void MailList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string MailAddress = MailList.CurrentRow.Cells[0].Value.ToString();
                DialogResult ask = MessageBox.Show("Do you want delete '" + MailAddress + "'?",
                    "DELETE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    MailList.Rows.Remove(MailList.CurrentRow);
                    Thread Update = new Thread(() => Contact_Update(sender, e, string.Empty));
                    Update.Start();
                    return;
                }
            }
        }
        private void Contact_Update(object sender, EventArgs e, String MailAddress)
        {
            LoadingImgShow();
            try
            {
                if (!Directory.Exists(Path.GetDirectoryName(ListOfPath.SavedContacts)))
                    Directory.CreateDirectory(Path.GetDirectoryName(ListOfPath.SavedContacts));
                if (File.Exists(ListOfPath.SavedContacts) && MailAddress == String.Empty)
                    File.Delete(ListOfPath.SavedContacts);
                // if remove
                if (MailAddress == string.Empty)
                {
                    foreach (DataGridViewRow Row in MailList.Rows)
                    {
                        File.AppendAllText(ListOfPath.SavedContacts, Row.Cells[0].Value.ToString() + "\r\n");
                    }
                }
                else
                {
                    File.AppendAllText(ListOfPath.SavedContacts, MailAddress + "\r\n");
                    AddToMailList(MailAddress);
                }
                MessageBox.Show("Update success!", "DONE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry! Update contact not success, we found some problem! Please try again or try to run this program with administrator!",
                    "UPDATE FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadingImgHide();
        }
        private void LoadingImgShow()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LoadingImgShow));
                return;
            }
            _Back.Enabled = false;
            NewMailAddress.Enabled = false;
            MailList.Enabled = false;
            _loading.Show();
        }
        private void LoadingImgHide()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LoadingImgHide));
                return;
            }
            _Back.Enabled = true;
            NewMailAddress.Enabled = true;
            MailList.Enabled = true;
            _loading.Hide();
        }

        private void LoadSavedMail(object sender, EventArgs e)
        {
            LoadingImgShow();
            try
            {
                foreach (string item in File.ReadLines(ListOfPath.SavedContacts))
                {
                    try
                    {
                        AddToMailList(item);
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
            LoadingImgHide();
        }
        private void AddToMailList(string MailAddress)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AddToMailList), new object[] { MailAddress });
                return;
            }
            MailList.Rows.Add(MailAddress);
        }
        private void ContactManager_Load(object sender, EventArgs e)
        {
            // Hide somethings
            _loading.Hide();
            MailList.RowTemplate.Height = 40;
            MailList.RowTemplate.Resizable = DataGridViewTriState.False;
            // Load saved mail address
            if (!File.Exists(ListOfPath.SavedContacts))
                return;
            Thread Load = new Thread(() => LoadSavedMail(sender, e));
            Load.Start();
        }

        private void _Back_Click(object sender, EventArgs e)
        {
            DialogResult ask = MessageBox.Show("Go back to main window?", "BACK?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.No)
                return;
            this.Dispose();
        }

        public EventHandler ChooedSendMail;
        private void MailList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string MailAddress = MailList.CurrentRow.Cells[0].Value.ToString();
            DialogResult ask = MessageBox.Show("Do you want to send mail to '" + MailAddress + "'?",
                "SEND NEW MAIL?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                Operations.GlobalVarriable.SendToChoosedAddress = MailAddress;
                if (ChooedSendMail != null)
                    ChooedSendMail(sender,e);
                return;
            }
        }
    }
}
