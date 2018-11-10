using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureMail.Dialog
{
    public partial class InfoDialog : Form
    {
        string Content;
        string Header;
        public InfoDialog(string cnt, string hder)
        {
            Content = cnt;
            Header = hder;
            InitializeComponent();
        }

        private void OKBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InfoDialog_Load(object sender, EventArgs e)
        {
            InfoLabel.Text = Header;
            ContentInfo.Text = Content;
        }
    }
}
