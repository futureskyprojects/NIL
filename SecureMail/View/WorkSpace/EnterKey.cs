using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureMail.WorkSpace
{
    public partial class EnterKey : Form
    {
        public EnterKey()
        {
            InitializeComponent();
        }

        private void ClosePop_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if (Password.Text==string.Empty)
            {
                Dialog.ErrorDialog error = new Dialog.ErrorDialog("Password empty!");
                error.ShowDialog();
            }
            Operations.Content.Message.CurrentPassword = Password.Text;
            Close();
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                accept_Click(sender,e);
            }
        }

        private void CryptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operations.GlobalVarriable.KindOfCrypt = CryptType.SelectedIndex;
        }

        private void EnterKey_Load(object sender, EventArgs e)
        {
            CryptType.SelectedIndex = 0;
        }
    }
}
