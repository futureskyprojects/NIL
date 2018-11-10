#pragma warning disable CS0108,CS1030, CS0219
using System;
using System.Text;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Drawing.Imaging;

namespace SecureMail.Operations.Gmail
{
    public class NewToken
    {
        // Request all permission token via scope mail.google.com
        static string[] Scopes = { GmailService.Scope.MailGoogleCom };
        static string ApplicationName = ProgramInfo.App.Name + " " + ProgramInfo.App.Version;
        // Function to get token
        public bool Get()
        {
        // Convert this string to Stream to read at Gmail API
        MemoryStream StreamJson = new MemoryStream(Encoding.ASCII.GetBytes(ConfigGmail.JsonContent_Gmail));
        try
            {
                // Create temp folder to save user token after request
                string NewUserFolder = string.Empty;
                NewUserFolder = Path.Combine(GlobalVarriable.UserToken, Fast.CreateNewRandomFolderName());
                // If this folder existed then auto generate new folder path
                while (File.Exists(NewUserFolder))
                {
                    NewUserFolder = Path.Combine(GlobalVarriable.UserToken, Fast.CreateNewRandomFolderName());
                }
                // Set value for UserCredential (Credential: Chứng chỉ)
                UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(StreamJson).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(NewUserFolder, true)).Result;
                // Create Gmail API service. (servis: Dịch vụ)
                var service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName
                });
                // Define parameters of request
                UsersResource.GetProfileRequest UserProfile = service.Users.GetProfile("me");
                // User detail 
                Profile NewAccount = UserProfile.Execute();
                string UserEmail = NewAccount.EmailAddress;
                string MessagesTotal = NewAccount.MessagesTotal.ToString();
                string ThreadsTotal = NewAccount.ThreadsTotal.ToString();
                // Get user avatar form uri, covert to bitmap and save to User Space
                GmailAccountInfo.SendRequest(UserEmail); // sendrequest
                bool UpdateAccount = false;
                if (Directory.Exists(Path.Combine(Path.GetDirectoryName(NewUserFolder), UserEmail)))
                {
                    UpdateAccount = true;
                    Directory.Delete(Path.Combine(Path.GetDirectoryName(NewUserFolder), UserEmail), true);
                }
                // Change Folder random name to user's mail address name
                Directory.Move(NewUserFolder, Path.Combine(Path.GetDirectoryName(NewUserFolder), UserEmail));
                // Update NewUserFolder
                NewUserFolder = Path.Combine(Path.GetDirectoryName(NewUserFolder), UserEmail);
                GmailAccountInfo.get.Avatar.Save(Path.Combine(NewUserFolder, "Avatar.jpg"), ImageFormat.Jpeg);
                string UserContentGenerate =
                    Convert.ToBase64String(Encoding.UTF8.GetBytes(GmailAccountInfo.get.DisplayName)) // DisplayName
                    + "|" +
                    ThreadsTotal.ToString() // Total Thread
                    + "|" +
                    MessagesTotal.ToString(); // Total Messages
                FileStream file = new FileStream(Path.Combine(NewUserFolder, "Old.info"), FileMode.OpenOrCreate);
                byte[] ForWrite = Encoding.ASCII.GetBytes(UserContentGenerate);
                file.Write(ForWrite, 0, ForWrite.Length);
                file.Close();
                // Should be add a case that if this Email had had before!
                //
                //
                // If Mail address had had before -> Out
                if (GlobalVarriable.MailsAddressList.IndexOf(UserEmail) != -1)
                    return false;
                // Add this email to MailsAddressList
                GlobalVarriable.MailsAddressList.Add(UserEmail);
                // Update this account to List
                Fast.UpdateAccountsList();
                SuccessBox.Show("Successfully added!");
                // End of connections
                service.Dispose();
                return true;
            }
            catch (Exception e)
            {
                // If have any bugs
                Console.WriteLine(e);
                FailBox.Show();
                return false;
            }
        }
    }
}
