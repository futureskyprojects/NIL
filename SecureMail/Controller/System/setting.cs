using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SecureMail
{
    public static class Setting
    {
        public static bool AutoCheckIB = true;
        public static int TimeUpdate = 0;
        public static bool Runbg = true;
        public static bool AutoDelete = false;
        public static int TimeDele = 100;
        public static bool AutoDownloadAttachments = false;
        public static void Load()
        {
            if (File.Exists(ListOfPath.SavedSetting))
            {
                int i = 0;
                var Data = File.ReadLines(ListOfPath.SavedSetting);
                foreach (string item in Data)
                {
                    try
                    {
                        if (i == 0)
                            AutoCheckIB = Convert.ToBoolean(item);
                        else if (i == 1)
                            TimeUpdate = Convert.ToInt32(item);
                        else if (i == 2)
                            Runbg = Convert.ToBoolean(item);
                        else if (i == 3)
                            AutoDelete = Convert.ToBoolean(item);
                        else if (i == 4)
                            TimeDele = Convert.ToInt32(item);
                        else if (i == 5)
                            AutoDownloadAttachments = Convert.ToBoolean(item);
                        i++;
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
            }
        }
        public static bool Update()
        {
            try
            {
                // Check if directory not exists then create new
                if (!Directory.Exists(Path.GetDirectoryName(ListOfPath.SavedSetting)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(ListOfPath.SavedSetting));
                }
                // Then save to file
                string TempData = AutoCheckIB.ToString() + "\r\n" +
                    TimeUpdate.ToString() + "\r\n" +
                    Runbg.ToString() + "\r\n" +
                    AutoDelete.ToString() + "\r\n" +
                    TimeDele.ToString() + "\r\n" +
                    AutoDownloadAttachments.ToString();
                File.WriteAllText(ListOfPath.SavedSetting, TempData);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}
