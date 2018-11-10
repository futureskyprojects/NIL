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
    public partial class WarnDialog : Form
    {
        string Content;
        string Header;
        public WarnDialog(string content, string header)
        {
            Content = content;
            Header = header;
            InitializeComponent();
        }

        private void WarnDialog_Load(object sender, EventArgs e)
        {
            ContentWarning.Text = Content;
            WarningLabel.Text = Header;
        }

        private void OKBT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
