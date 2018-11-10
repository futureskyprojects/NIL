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

namespace SecureMail.WorkSpace
{
    public partial class ForwardS : UserControl
    {
        public ForwardS()
        {
            InitializeComponent();
        }
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
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.ToString());
                        // Nothing
                    }
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
                // Nothing
            }
            MailAddress.AutoCompleteCustomSource = Source;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            // Check input
            if (String.IsNullOrEmpty(MailAddress.Text) || String.IsNullOrWhiteSpace(MailAddress.Text))
            {
                MessageBox.Show("Mailadress is empty!","PLEASE INPUT!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (!MailAddress.Text.Contains("@") || MailAddress.Text.Split('@').Length>2 || !MailAddress.Text.Split('@')[1].Contains('.'))
            {
                MessageBox.Show("Wrong email format!","WRONG MAIL ADDRESS!",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            foreach (char c in MailAddress.Text)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    if (c == '.' || c == '_' || c == '@')
                        continue;
                    else
                    {
                        MessageBox.Show("this Mail Adress have special character!","WRONG EMAIL!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            MailAddressList.Rows.Add(MailAddress.Text);
            MailAddress.Text = "";
        }
        public List<string> ListMail = new List<string>();
        private void MailAddressList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult ask = MessageBox.Show("Delete '"+ MailAddressList.CurrentRow.Cells[0].Value+"' from this list?",
                    "DELETE?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (ask == DialogResult.No)
                    return;
                MailAddressList.Rows.Remove(MailAddressList.CurrentRow);
            }
        }
        public EventHandler ClickedForward;
        private void ForWardAccept_Click(object sender, EventArgs e)
        {
            if (MailAddressList.Rows.Count==0)
            {
                if (ClickedForward != null)
                    ClickedForward(sender, e);
                return;
            }
            DialogResult askX = MessageBox.Show("Forward mail to " + MailAddressList.Rows.Count + " mail address?",
                "FORWARD?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (askX == DialogResult.No)
                return;
            foreach (DataGridViewRow Row in MailAddressList.Rows)
            {
                ListMail.Add(Row.Cells[0].Value.ToString());
            }
            if (ClickedForward!=null)
            {
                ClickedForward(sender, e);
            }
            MailAddress.Clear();
            MailAddressList.Rows.Clear();
        }

        private void ForwardS_SizeChanged(object sender, EventArgs e)
        {
            MailAddress.Clear();
            MailAddressList.Rows.Clear();
        }

        private void MailAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                Add_Click(sender,e);
            }
        }

        private void ForwardS_Load(object sender, EventArgs e)
        {
            System.Threading.Thread Ad = new System.Threading.Thread(new System.Threading.ThreadStart(AddCollection));
            Ad.Start();
        }
    }
}
