using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SecureMail.Operations.Gmail
{
    public static class GmailAccountInfo
    {
        public static void SendRequest(string gmail)
        {
            get.Email = gmail;
            try
            {
                // Request to get User Avatar
                string url = "https://pikmail.herokuapp.com/" + gmail + "?size=1024";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // Get User ID
                    get.Uid = Path.GetFileNameWithoutExtension(response.ResponseUri.AbsolutePath);
                    // Read Stream respone and convert to Image
                    using (Stream stream = response.GetResponseStream())
                        get.Avatar = Image.FromStream(stream);
                }
                // Abort old request
                request.Abort();
                // Request to get User Display Name
                url = "https://www.googleapis.com/plus/v1/people/" + get.Uid + "?fields=displayName&key=AIzaSyD4KLZTDFbGX6-VPB8KvlK7zdeQln-KqGY";
                request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string[] ResponeText = reader.ReadToEnd().Split('"');
                    get.DisplayName = ResponeText[3];
                }
            }
            catch (Exception)
            {
                get.Avatar = Properties.Resources.user;
                get.Uid = get.DisplayName = string.Empty;
            }

        }
        public static class get
        {
            public static string Uid;
            public static string Email;
            public static Image Avatar;
            public static string DisplayName;
            public static string Unread = "1";
        }
    }
}
