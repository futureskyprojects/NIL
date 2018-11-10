using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Drawing.Imaging;
using System.Data;
using System.Windows.Forms;


// Use again!!!
namespace SecureMail.Operations
{
    public class Connect
    {
        // Request all permission token via scope mail.google.com
        string[] Scopes = { GmailService.Scope.MailGoogleCom };
        string ApplicationName = "NIL Info mail";
        public GmailService service;
        public bool Open(string PathOfUserData)
        {
            // Convert this string to Stream to read at Gmail API
            MemoryStream StreamJson = new MemoryStream(Encoding.ASCII.GetBytes(ConfigGmail.JsonContent_Gmail));
            try
            {
                // Set value for UserCredential (Credential: Chứng chỉ)
                UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(StreamJson).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(PathOfUserData, true)).Result;
                // Create Gmail API service. (servis: Dịch vụ)
                service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int GetINBOX()
        {
            // Define parameter for request
            UsersResource.MessagesResource.ListRequest ThreadRequest = service.Users.Messages.List("me");
            ThreadRequest.LabelIds = "INBOX";
            // Get mail include spam trash?
            ThreadRequest.IncludeSpamTrash = false; // NO
            ThreadRequest.MaxResults = int.MaxValue;
            // Make a request
            try
            {
                return ThreadRequest.ExecuteAsync().Result.Messages.Count();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
