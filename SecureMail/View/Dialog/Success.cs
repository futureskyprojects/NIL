using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureMail.Dialog
{
    public partial class Success : Form
    {
        string content = string.Empty;
        public Success(string Content)
        {
            content = Content;
            InitializeComponent();
        }

        private void Success_Load(object sender, EventArgs e)
        {
            success_lb.Text = content;
            this.Hide();
            appearance.ShowSync(this);
            System.Windows.Forms.Timer AutoClose = new System.Windows.Forms.Timer();
            AutoClose.Interval = 1200;
            AutoClose.Enabled = true;
            AutoClose.Tick += new EventHandler(AutoClose_Tick);
        }
        void AutoClose_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
