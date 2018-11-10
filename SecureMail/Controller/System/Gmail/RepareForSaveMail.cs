using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SecureMail
{
    public class SaveMail
    {
        public string Sender = string.Empty;
        public string Subject = string.Empty;
        public string DateTimeReceived = string.Empty;
        public string Body = string.Empty;
        public Image SenderAvatar;
        private string SenderAvatarSet = string.Empty;
        //
        public void Reset()
        {
            Sender = string.Empty;
            Subject = string.Empty;
            DateTimeReceived = string.Empty;
            Body = string.Empty;
            SenderAvatarSet = string.Empty;
        }
        public void Set(string _sender, string _subject, string _datetimereceived, string _body, Image _senderAvatart)
        {
            Sender = _sender;
            Subject = _subject;
            DateTimeReceived = _datetimereceived;
            Body = _body;
            using (var ms = new MemoryStream())
            {
                _senderAvatart.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                SenderAvatarSet = Convert.ToBase64String(ms.ToArray());
            }
        }
        public byte[] Get()
        {
            string TextForSave =
                /* 1 */ Convert.ToBase64String(Encoding.UTF8.GetBytes(Sender)) + "\r\n" +
                /* 2 */ Convert.ToBase64String(Encoding.UTF8.GetBytes(Subject)) + "\r\n" +
                /* 3 */ Convert.ToBase64String(Encoding.UTF8.GetBytes(DateTimeReceived)) + "\r\n" +
                /* 4 */ Convert.ToBase64String(Encoding.UTF8.GetBytes(Body)) + "\r\n" +
                /* 5 */ Convert.ToBase64String(Encoding.UTF8.GetBytes(SenderAvatarSet));
            return Encoding.UTF8.GetBytes(TextForSave);
        }
        public bool Load(string _PathOfMailSaved)
        {
            IEnumerable<String> LinesData = File.ReadLines(_PathOfMailSaved);
            if (LinesData.Count() != 5)
            {
                return false;
            }
            Reset();
            int count = 0;
            foreach (string Line in LinesData)
            {
                count++;
                try
                {
                    if (count == 1)
                        Sender = Encoding.UTF8.GetString(Convert.FromBase64String(Line));
                    else if (count == 2)
                        Subject = Encoding.UTF8.GetString(Convert.FromBase64String(Line));
                    else if (count == 3)
                        DateTimeReceived = Encoding.UTF8.GetString(Convert.FromBase64String(Line));
                    else if (count == 4)
                        Body = Encoding.UTF8.GetString(Convert.FromBase64String(Line));
                    else if (count == 5)
                    {
                        MemoryStream ms = new MemoryStream(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Line))));
                        SenderAvatar = Image.FromStream(ms);
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
