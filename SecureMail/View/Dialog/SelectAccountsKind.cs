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
    public partial class SelectAccountsKind : Form
    {
        public SelectAccountsKind()
        {
            InitializeComponent();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void YahooMail_Click(object sender, EventArgs e)
        {
            Hide();
            Operations.GlobalVarriable.ChooseMailSuccess = false;
            InfoDialog NewInfo = new InfoDialog("I still do not support Yahoo Mail! Please come back later.", "NOT SUPPORT NOW!");
            NewInfo.ShowDialog();
            Close();
        }

        private void HotMail_Click(object sender, EventArgs e)
        {
            Hide();
            Operations.GlobalVarriable.ChooseMailSuccess = false;
            InfoDialog NewInfo = new InfoDialog("I still do not support Hot Mail! Please come back later.", "NOT SUPPORT NOW!");
            NewInfo.ShowDialog();
            Close();
        }

        private void Gmail_Click(object sender, EventArgs e)
        {
            Thread ThreadX = new Thread(() => addGmail(sender,e));
            ThreadX.Start();
            Close();
        }
        public EventHandler ReloadNow;
        private void addGmail(object sender, EventArgs e)
        {
            //if (InvokeRequired)
            //{
            //    Invoke(new Action<object,EventArgs>(addGmail),new object[] { sender,e});
            //    return;
            //}
            Operations.GlobalVarriable.ChooseMailSuccess = false;
            #region Process code here
            Operations.Gmail.NewToken AddNew = new Operations.Gmail.NewToken();
            if (AddNew.Get() == true)
            {
                Operations.GlobalVarriable.ChooseMailSuccess = true;
                Operations.GlobalVarriable.AddAccountToPanel = true;
                if (ReloadNow != null)
                    ReloadNow(sender, e);
            }
            else
                Operations.GlobalVarriable.AddAccountToPanel = false;
            #endregion
        }
    }
}
