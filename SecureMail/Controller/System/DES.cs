using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
namespace SecureMail.Operations
{
    public static class DES
    {
        #region  For encrypt text
        public static string Encrypt(string plaintext, string pass)
        {
            try
            {
                using (TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider())
                {
                    var PassHash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
                    DES.Key = PassHash;
                    DES.Mode = CipherMode.ECB;
                    ICryptoTransform DESEncrypter = DES.CreateEncryptor();
                    var Data = Encoding.UTF8.GetBytes(plaintext);
                    return Convert.ToBase64String(DESEncrypter
                        .TransformFinalBlock(Data,0,Data.Length));
                }
            }
            catch (Exception)
            {
                return plaintext;
            }
        }
        public static string Decrypt(string encryptedText, string pass)
        {
            try
            {
                using (TripleDESCryptoServiceProvider DES = new TripleDESCryptoServiceProvider())
                {
                    var PassHash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
                    DES.Key = PassHash;
                    DES.Mode = CipherMode.ECB;
                    ICryptoTransform DESDecrypt = DES.CreateDecryptor();
                    var Data = Convert.FromBase64String(encryptedText);
                    return Encoding.UTF8.GetString(
                        DESDecrypt.TransformFinalBlock(Data,0,Data.Length));
                }
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }
        #endregion
        #region Fro Encrypt file
        public static string EncryptFile(string pathoffile, string pass)
        {
            try
            {
                using (DESCryptoServiceProvider DES = new DESCryptoServiceProvider())
                {
                    var PassHash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
                    DES.Key = PassHash;
                    DES.Mode = CipherMode.ECB;
                    ICryptoTransform DESEncrypt = DES.CreateEncryptor();
                    byte[] Data = File.ReadAllBytes(pathoffile);
                    return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Data,0,Data.Length));
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static byte[] DecryptFile(string EncryptedContent, string pass)
        {
            try
            {
                using (DESCryptoServiceProvider DES = new DESCryptoServiceProvider())
                {
                    var PassHash = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(pass));
                    DES.Key = PassHash;
                    DES.Mode = CipherMode.ECB;
                    ICryptoTransform DESDecrypt = DES.CreateDecryptor();
                    var Data = Convert.FromBase64String(EncryptedContent);
                    return DESDecrypt.TransformFinalBlock(Data,0,Data.Length);
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
