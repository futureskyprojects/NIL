using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureMail
{
    class GmailForward
    {
        private string To = string.Empty;
        private string Content = string.Empty;
        private Dictionary<string, string> Attachments = new Dictionary<string, string>();
        private bool ImportAttachment()
        {
            foreach (String att in Operations.Content.Message.Attachments.Split(new string[] { "||" }, StringSplitOptions.None))
            {
                try
                {
                    if (!att.Contains("|"))
                        continue;
                    WorkSpace.Attachments GetAtt = new WorkSpace.Attachments();
                    string[] Temp = GetAtt.Download(att.Split('|')[1]);
                    Attachments.Add(att.Split('|')[0], Temp[0]);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }
        string Build()
        {
            if (Attachments.Count < 1)
                return WorkSpace.Compose.Send.Base64UrlEncode(
                    WorkSpace.Compose.Send.RepareContent(To, "Fwd: \"" + Operations.Content.Message.Subject + "\"", Content, string.Empty));
            else
            {
                string User_name = Operations.GlobalVarriable.User[0];
                if (User_name.IndexOf(" (") != -1)
                    User_name = User_name.Substring(0, Operations.GlobalVarriable.User[0].IndexOf(" ("));
                string Edit =
                    "Content-Type: multipart/mixed; boundary=\"foo_bar_baz\"\r\n" +
                    "Content-Type: text/html; q=0.5, text/html, text/x-dvi; q=0.8, text/x-c\r\n" +
                    "MIME-Version: 1.0\r\n" +
                    "From: " + "=?UTF-8?B?" + User_name + "?=" + " <" + Operations.GlobalVarriable.User[1] + ">" + "\r\n" +
                    "To: " + To + "\r\n" +
                    "Subject: " + "=?UTF-8?B?" + Convert.ToBase64String(Encoding.UTF8.GetBytes("Fwd: " + Operations.Content.Message.Subject)) + "?=" + "\r\n\r\n" +

                    "--foo_bar_baz\r\n" +
                    "Content-Type: text/html; charset=\"UTF-8\"\r\n" +
                    "MIME-Version: 1.0\r\n" +
                    "Content-Transfer-Encoding: 7bit\r\n\r\n" +
                    Content + "\r\n\r\n";

                foreach (string item in Attachments.Keys)
                {
                    if (item == null || item == String.Empty || !Attachments.TryGetValue(item, out string value))
                        continue;
                    Edit += "--foo_bar_baz\r\n" +
                        "Content-Type: " + MimeMap.GetMimeType(Path.GetExtension(item)) + "\r\n" +
                        "MIME-Version: 1.0\r\n" +
                        "Content-Transfer-Encoding: base64\r\n" +
                        "Content-Disposition: attachment; filename=\"" + item + "\"\r\n\r\n" +
                        value + "\r\n\r\n";
                }
                Edit += "--foo_bar_baz--";
                return WorkSpace.Compose.Send.Base64UrlEncode(Edit);
            }
        }
        public bool Send(List<string> _To, string _Content)
        {
            foreach (string item in _To)
            {
                if (To != String.Empty)
                    To += ",";
                To += item;
            }
            Content = _Content;
            if (ImportAttachment() == false)
                return false;
            try
            {
                var NewMessage = new Google.Apis.Gmail.v1.Data.Message();
                NewMessage.Raw = Build();
                var CallX = Operations.Gmail.Connect.service.Users.Messages.Send(NewMessage, "me");
                var msg = CallX.ExecuteAsync().Result;
                String temp = CallX.HttpMethod;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
