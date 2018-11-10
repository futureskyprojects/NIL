using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SecureMail.Operations
{
    public static class AES
    {
        #region For Encrypt Text
        public static string Encrypt(string plaintext, string pass)
        {
            try
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    var PassHash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
                    AES.Key = PassHash;
                    AES.Mode = CipherMode.ECB;
                    ICryptoTransform AESEncrypter = AES.CreateEncryptor();
                    var Data = Encoding.UTF8.GetBytes(plaintext);
                    return Convert.ToBase64String(AESEncrypter.TransformFinalBlock(Data, 0, Data.Length));

                }
            }
            catch (Exception)
            {
                return plaintext;
            }
        }

        public static string Decrypt(string encryptedtext, string pass)
        {
            try
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    var PassHash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
                    AES.Key = PassHash;
                    AES.Mode = CipherMode.ECB;
                    ICryptoTransform AESEncrypter = AES.CreateDecryptor();
                    var Data = Convert.FromBase64String(encryptedtext);
                    return Encoding.UTF8.GetString(AESEncrypter.TransformFinalBlock(Data, 0, Data.Length));
                }
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }
        #endregion
        #region For Encrypt File
        public static string EncryptFile(string PathOfFile, string pass)
        {
            try
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    var PassHash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
                    AES.Key = PassHash;
                    AES.Mode = CipherMode.ECB;
                    ICryptoTransform AESEncrypter = AES.CreateEncryptor();
                    byte[] Data = File.ReadAllBytes(PathOfFile);
                    return Convert.ToBase64String(AESEncrypter.TransformFinalBlock(Data, 0, Data.Length));

                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static byte[] DecryptFile(string encryptedcontent, string pass)
        {
            try
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    var PassHash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
                    AES.Key = PassHash;
                    AES.Mode = CipherMode.ECB;
                    ICryptoTransform AESEncrypter = AES.CreateDecryptor();
                    var Data = Convert.FromBase64String(encryptedcontent);
                    return AESEncrypter.TransformFinalBlock(Data, 0, Data.Length);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

    }
}
