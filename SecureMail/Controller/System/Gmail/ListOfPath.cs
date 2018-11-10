using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureMail
{
    public static class ListOfPath
    {
        //Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
        // Big WorkPath
        public static String WorkPath = Path
            .Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
        #region WorkPathLoop
                    "Tnsoft", "Tnsoft", "Tnsoft", "Tnsoft", "Tnsoft", "Tnsoft", "Tnsoft", "Tnsoft");
        #endregion
        // Folder save MailLogs
        public static String SavedMailLogs = Path.Combine(WorkPath,"SavedMailLogs","logs.Tnsoft");
        public static String SavedSetting = Path.Combine(WorkPath, "SavedSetting", "setting.Tnsoft");
        // Folder for save Contact of user
        public static String SavedContacts = Path.Combine(WorkPath, "SavedContact", "Contact.Tnsoft");
    }
}
