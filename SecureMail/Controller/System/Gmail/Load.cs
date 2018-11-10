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

namespace SecureMail.Operations.Gmail
{
    public static class Connect
    {
        // Request all permission token via scope mail.google.com
        static string[] Scopes = { GmailService.Scope.MailGoogleCom };
        static string ApplicationName = ProgramInfo.App.Name + " " + ProgramInfo.App.Version;
        public static GmailService service;
        public static bool Open(string PathOfUserData)
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
    }
    public static class Load
    {
        private static int LoadKind = 1;
        public static ListMessagesResponse Inbox()
        {
            LoadKind = 1;
            // Check connection
            if (CheckConnection.Check() == false)
            {
                return null;
            }
            // Define parameter for request
            UsersResource.MessagesResource.ListRequest MessageRequest = Connect.service.Users.Messages.List("me");
            MessageRequest.LabelIds = "INBOX";
            MessageRequest.MaxResults = int.MaxValue;
            // Get mail include spam trash?
            MessageRequest.IncludeSpamTrash = false; // NO
            // Make a request
            try
            {
                return MessageRequest.Execute();
            }
            catch (Exception ee)
            {
                if (LoadKind == 1)
                    MessageBox.Show("Sorry! INBOX is Empty!",
                        "EMPTY!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                MessageBox.Show(ee.ToString());
                return null;
            }
        }
        public static ListMessagesResponse Sent()
        {
            LoadKind = 2;
            // Check connection
            if (CheckConnection.Check() == false)
            {
                return null;
            }
            // Define parameter for request
            UsersResource.MessagesResource.ListRequest MessageRequest = Connect.service.Users.Messages.List("me");
            MessageRequest.LabelIds = "SENT";
            MessageRequest.MaxResults = int.MaxValue;
            // Get mail include spam trash?
            MessageRequest.IncludeSpamTrash = false; // NO
            // Make a request
            try
            {
                return MessageRequest.Execute();
            }
            catch (Exception)
            {
                if (LoadKind == 2)
                    MessageBox.Show("Sorry! SENT is Empty!",
                    "EMPTY!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
        public static ListMessagesResponse Drafts()
        {
            LoadKind = 3;
            // Check connection
            if (CheckConnection.Check() == false)
            {
                return null;
            }
            // Define parameter for request
            UsersResource.MessagesResource.ListRequest MessageRequest = Connect.service.Users.Messages.List("me");
            MessageRequest.LabelIds = "DRAFTS";
            MessageRequest.MaxResults = int.MaxValue;
            // Get mail include spam trash?
            MessageRequest.IncludeSpamTrash = false; // NO
            // Make a request
            try
            {
                return MessageRequest.Execute();
            }
            catch (Exception)
            {
                if (LoadKind == 3)
                    MessageBox.Show("Sorry! DRAFTS is Empty!",
                    "EMPTY!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
        public static ListMessagesResponse Search(string Query)
        {
            LoadKind = 4;
            // Check connection
            if (CheckConnection.Check() == false)
            {
                return null;
            }
            // Define parameter for request
            UsersResource.MessagesResource.ListRequest MessageRequest = Connect.service.Users.Messages.List("me");
            MessageRequest.Q = Query;
            MessageRequest.MaxResults = int.MaxValue;
            // Get mail include spam trash?
            MessageRequest.IncludeSpamTrash = false; // NO
            // Make a request
            try
            {
                return MessageRequest.Execute();
            }
            catch (Exception)
            {
                if (LoadKind == 4)
                    MessageBox.Show("Sorry! Result is Empty!",
                    "EMPTY!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }
        public static bool StopForNewMail = false;
        public static int CountMails(int KindOfScan)
        {
            string Label = string.Empty;
            if (KindOfScan == 1)
                Label = "INBOX";
            else if (KindOfScan == 2)
                Label = "SENT";
            else if (KindOfScan == 3)
                Label = "DRAFTS";
            // Check connection
            if (CheckConnection.Check() == false)
            {
                return 0;
            }
            // Define parameter for request
            UsersResource.ThreadsResource.ListRequest ThreadRequest = Connect.service.Users.Threads.List("me");
            ThreadRequest.LabelIds = Label;
            // Get mail include spam trash?
            ThreadRequest.MaxResults = int.MaxValue;
            ThreadRequest.IncludeSpamTrash = false; // NO
            // Make a request
            try
            {
                return ThreadRequest.ExecuteAsync().Result.Threads.Count();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }

}
