using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureMail.WorkSpace
{
    public partial class WelCome : UserControl
    {
        public WelCome()
        {
            InitializeComponent();
        }

        private void WelCome_Load(object sender, EventArgs e)
        {
            // WelcomeText
            WelcomeText.Text = "Welcome "+Operations.GlobalVarriable.User[0]+" to "+ProgramInfo.App.Name+"!";
            ProductOf.Text = "(c) "+ProgramInfo.App.Name+" "+ProgramInfo.App.Version+" - Create by IATT && NGHIA";
        }
        public EventHandler Wel_NewMail;
        private void NewMail_Click(object sender, EventArgs e)
        {
            if (Wel_NewMail!=null)
            {
                Wel_NewMail(sender, e);
            }
            return;
        }

        public EventHandler Wel_UserContact;
        private void ManageContact_Click(object sender, EventArgs e)
        {
            if (Wel_UserContact!=null)
            {
                Wel_UserContact(sender, e);
            }
            return;
        }

        public EventHandler Wel_GUI;
        private void GUIDE_Click(object sender, EventArgs e)
        {
            if (Wel_GUI!=null)
            {
                Wel_GUI(sender,e);
            }
            return;
        }
    }
}
