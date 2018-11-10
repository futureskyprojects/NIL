using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureMail.Operations
{
    public static class Fast
    {
        public static string CreateNewRandomFolderName()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 30)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        // Update file Account.List
        public static void UpdateAccountsList()
        {
            if (File.Exists(Path.Combine(GlobalVarriable.UserCombine, "Account.list")))
                File.Delete(Path.Combine(GlobalVarriable.UserCombine, "Account.list"));
            foreach (string MailAddressL in GlobalVarriable.MailsAddressList)
            {
                File.AppendAllText(Path.Combine(GlobalVarriable.UserCombine, "Account.list"), MailAddressL + " ");
            }
        }

        // Get body of mail
        public static string GetBody(string Email_ID)
        {
            string body = string.Empty;
            // Get body
            var EmailInfoReq = Gmail.Connect.service.Users.Messages.Get("me", Email_ID);
            var EmailInfoRes = EmailInfoReq.Execute();
            if (EmailInfoRes != null)
            {
                string date = "";
                string from = "";
                foreach (var item in EmailInfoRes.Payload.Headers)
                {
                    if (item.Name == "Date")
                    {
                        date = item.Value;
                    }
                    else if (item.Name == "From")
                    {
                        from = item.Value;
                    }
                    if (date != "" && from != "")
                    {
                        if (EmailInfoRes.Payload.Parts == null && EmailInfoRes.Payload.Body != null)
                        {
                            body = EmailInfoRes.Payload.Body.Data;
                            try
                            {
                                String codedBody = EmailInfoRes.Payload.Body.Data.Replace("-", "+");
                                codedBody = codedBody.Replace("_", "/");
                                byte[] data = Convert.FromBase64String(codedBody);
                                body = Encoding.UTF8.GetString(data);
                            }
                            catch (Exception)
                            {
                                // nothing  
                            }
                        }
                        else
                        {
                            body = GetNestedParts(EmailInfoRes.Payload.Parts, "");
                        }
                    }
                }
            }
            return body;
        }
        // Function to get MultiPart Body
        static String GetNestedParts(IList<MessagePart> part, string curr)
        {
            string str = curr;
            if (part == null)
            {
                return str;
            }
            else
            {
                foreach (var parts in part)
                {
                    if (parts.Parts == null)
                    {
                        if (parts.Body != null && parts.Body.Data != null)
                        {
                            //need to replace some characters as the data for the email's body is base64
                            String codedBody = parts.Body.Data.Replace("-", "+");
                            codedBody = codedBody.Replace("_", "/");
                            byte[] data = Convert.FromBase64String(codedBody);
                            str = Encoding.UTF8.GetString(data);
                        }
                    }
                    else
                    {
                        return GetNestedParts(parts.Parts, str);
                    }
                }

                return str;
            }

        }

    }

}
namespace SecureMail
{
    public static class SuccessBox
    {
        static Dialog.Success success;
        public static void Show(string cnt)
        {
            success = new Dialog.Success(cnt);
            success.ShowDialog();
        }
    }
    public static class FailBox
    {
        static Dialog.Fail fail;
        public static void Show()
        {
            fail = new Dialog.Fail();
            fail.ShowDialog();
        }
    }

}
