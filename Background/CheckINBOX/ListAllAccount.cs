using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SecureMail;
using System.Windows.Forms;
using SecureMail.Operations;
using System.Diagnostics;

namespace Background.CheckINBOX
{
    public static class ListAllAccount
    {
        public static bool Loading = false;
        public static void Load()
        {
            Loading = true;
            try
            {
                // Check if have account in account list
                if (Directory.Exists(GlobalVarriable.UserCombine))
                {
                    // If it exists, Load date from Account.list to MailsAddressList
                    string Temp = File.ReadAllText(Path.Combine(GlobalVarriable.UserCombine, "Account.list"));
                    string[] AddressList = Temp.Split(' ');
                    // If elment of AddressList lager than 0
                    if (AddressList.Length > 0)
                        // Then insert to MailsAddressList and MailAddress Panel
                        foreach (string Address in AddressList)
                        {
                            // A. Insert to Maildress Panel
                            // 1. Get This Mail Path where save info of this mail account
                            string ThisMailPath = Path.Combine(GlobalVarriable.UserToken, Address);
                            // Check if ThisMailPath is exists or not
                            if (!Directory.Exists(ThisMailPath))
                                // If not continue And don't insert to MailsAddress
                                continue;
                            // Read file inclue user data
                            string[] Data = new string[4];
                            try
                            {
                                if (File.Exists(Path.Combine(ThisMailPath, "Old.info")))
                                {
                                    #region Read file and check user inbox here
                                    using (StreamReader sr = new StreamReader(Path.Combine(ThisMailPath, "Old.info")))
                                    {
                                        string trashSTR = sr.ReadToEnd();
                                        Data = trashSTR.Split('|');
                                        // Open connect
                                        Connect cn = new Connect();
                                        if (cn.Open(ThisMailPath) == false)
                                        {
                                            Loading = false;
                                            return;
                                        }
                                        // Conncet to INBOX
                                        int INBOXmsg = cn.GetINBOX();
                                        // Check some conditions
                                        if (INBOXmsg != 0)
                                        {
                                            if (GlobalVarriable.MailSavedTemp==0)
                                            {
                                                GlobalVarriable.MailSavedTemp = INBOXmsg;
                                                continue;
                                            }
                                            //MessageBox.Show(INBOXmsg.ToString() + "\r\n" + Data[2].ToString() + " || " + GlobalVarriable.MailSavedTemp,
                                            //    Address);
                                            // Check have new mail or not
                                            if (INBOXmsg > GlobalVarriable.MailSavedTemp)
                                            {
                                                DialogResult ask = MessageBox.Show(Address + " have " +
                                                    (INBOXmsg - Convert.ToInt32(Data[2])).ToString() +
                                                    " new mail(s)!\r\n" +
                                                    "Open NIL Info mail to check?", "YOU HAVE NEW MAIL(S)!",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                                if (ask==DialogResult.Yes)
                                                {
                                                    string PathOfMain = Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath)) +"\\SecureMail.exe";
                                                    Process.Start(PathOfMain);
                                                    continue;
                                                }
                                            }
                                            // Then update log
                                            GlobalVarriable.MailSavedTemp = INBOXmsg;
                                            Data[2] = INBOXmsg.ToString();
                                            trashSTR = Data[0] + "|" + Data[1] + "|" + Data[2];
                                            sr.Close();
                                            File.WriteAllText(Path.Combine(ThisMailPath, "Old.info"), trashSTR);
                                            continue;
                                        }
                                        else
                                        {
                                            sr.Close();
                                        }

                                    }
                                    #endregion
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            catch (Exception cx)
                            {
                                MessageBox.Show(cx.ToString());
                                continue;
                            }
                        }
                }
            }
            catch (Exception)
            {
                // Nothing
            }
            Loading = false;
        }
    }
}
