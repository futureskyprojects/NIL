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
    public partial class Record : UserControl
    {
        string UserName;
        string UserMail;
        Image Avatar;
        string MsgSubject;
        string RecivedTime;
        string EmailId;
        IList<string> PropertiesS = new List<string>();
        string FileName;
        public Record(string[] _Uname, Image _Avt, string MsgSubj, string RecivedT, string EmaiID, IList<string> _Properties, string _FileName)
        {
            FileName = _FileName;
            PropertiesS = _Properties;
            UserName = _Uname[0];
            UserMail = _Uname[1];
            Avatar = _Avt;
            MsgSubject = MsgSubj;
            RecivedTime = RecivedT;
            EmailId = EmaiID;
            InitializeComponent();
        }
        Color Default = new Color();
        bool SetDeaultColor = false;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (SetDeaultColor == false)
            {
                Default = BackColor;
                SetDeaultColor = true;
            }
            if (EmailId == Operations.Content.Message.ID)
                BackColor = Color.SandyBrown;
            else
                BackColor = Color.LightSeaGreen;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (SetDeaultColor == true)
                BackColor = Default;
        }
        private void Record_Load(object sender, EventArgs e)
        {
            if (PropertiesS.IndexOf("UNREAD") == -1)
            {
                BackColor = Color.White;
                panel1.Width = 0;
            }
            if (PropertiesS.IndexOf("STARRED") == -1)
                Starred.Hide();
            if (PropertiesS.IndexOf("IMPORTANT") == -1)
                Important.Hide();
            if (FileName == null || FileName == string.Empty)
                Attachment.Hide();
            
            SenderName.Text = UserName;
            SenderAvt.Image = Avatar;
            Subject.Text = MsgSubject;
            TimeRecived.Text = RecivedTime;
        }
        public event EventHandler MsgClick;
        private void ChangeToRead()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ChangeToRead));
                return;
            }
            Default = Color.White;
            this.BackColor = Color.White;
            panel1.Width = 0;
        }
        private void ShortText_MouseClick(object sender, MouseEventArgs e)
        {
            if (EmailId== Operations.Content.Message.ID)
            {
                return;
            }
            Operations.Content.Message.Properties = PropertiesS;
            Operations.Content.Sender.Email = UserMail;
            Operations.Content.Sender.Name = UserName;
            Operations.Content.Sender.Avatar = Avatar;
            Operations.Content.Message.Date = RecivedTime;
            Operations.Content.Message.Subject = MsgSubject;
            Operations.Content.Message.ID = EmailId;
            Operations.Content.Message.Attachments = FileName;
            ChangeToRead();
            if (MsgClick != null)
            {
                this.MsgClick(this, e);
            }
            Default = Color.SandyBrown;
        }

        private void Record_TabIndexChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, EventArgs>(Record_TabIndexChanged), new object[] { sender, e });
                return;
            }
            if (Default == Color.SandyBrown)
                Default = Color.White;
            else
                Default = Color.SandyBrown;
            if (Operations.Content.Message.ID == EmailId)
            {
                PropertiesS = Operations.Content.Message.Properties;
            }
            if (PropertiesS.IndexOf("UNREAD") == -1)
            {
                BackColor = Color.White;
                panel1.Width = 0;
            }
            else
            {
                BackColor = Color.FromArgb(241, 245, 248);
                panel1.Width = 5;
            }
            if (PropertiesS.IndexOf("STARRED") == -1)
                Effect.HideSync(Starred);
            else
                Effect.ShowSync(Starred);
            if (PropertiesS.IndexOf("IMPORTANT") == -1)
                Effect.HideSync(Important);
            else
                Effect.ShowSync(Important);
        }
    }
}
