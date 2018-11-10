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
    public partial class ErrorDialog : Form
    {
        string Content;
        public ErrorDialog(string content)
        {
            Content = content;
            InitializeComponent();
        }

        private void OKBT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ErrorDialog_Load(object sender, EventArgs e)
        {
            ContentError.Text = Content;
        }
    }
}
