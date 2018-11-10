using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureMail.Operations
{
    public static class GlobalVarriable
    {
        public static string[] User = new string[3];
        public static bool ChooseMailSuccess = false;
        public static int CountAccount = 0;
        public static string RootPath = string.Empty;
        public static string UserCombine = Path.Combine(ListOfPath.WorkPath, "UserCombine");
        public static string UserToken = Path.Combine(ListOfPath.WorkPath, "UserToken");
        public static IList<string> MailsAddressList = new List<string>();
        public static bool AddAccountToPanel = false;
        public static IList<string> ListOfActiveAccounts = new List<string>();
        public const int MaxAttachmentSize = 5 * 1024 * 1024;
        public static int KindOfCrypt = 0;
        public static string SendToChoosedAddress = string.Empty;
        public static long MailSavedTemp = 0;
    }
}
