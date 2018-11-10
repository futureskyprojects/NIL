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
    public partial class Fail : Form
    {
        public Fail()
        {
            InitializeComponent();
        }

        private void Fail_Load(object sender, EventArgs e)
        {

            this.Hide();
            appearance.ShowSync(this);
            Timer AutoClose = new Timer();
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
