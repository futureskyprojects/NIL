using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
//using Org.Cerberus.Utils;
using System;
using System.IO;
using System.Text;

namespace SecureMail.Operations
{
    public class BlowFish
    {
        private readonly Encoding _encoding;
        private readonly IBlockCipher _blockCipher;
        private PaddedBufferedBlockCipher _cipher;
        private IBlockCipherPadding _padding;
        BlowFish()
        {

        }
        private static byte[] Salt = Encoding.ASCII.GetBytes("IATT & NGHIA");
        BlowFish(IBlockCipher blockCipher, Encoding encoding)
        {
            _blockCipher = blockCipher;
            _encoding = encoding;
        }

        #region Public Methods


        public static string Encrypt(string TextPlain, string Password)
        {
            try
            {
                Sha3Digest Sha3Digest = new Sha3Digest();
                Pkcs5S2ParametersGenerator gen = new Pkcs5S2ParametersGenerator(Sha3Digest);
                gen.Init(Encoding.UTF8.GetBytes(Password), Salt, 1000);
                KeyParameter param = (KeyParameter)gen.GenerateDerivedParameters(new BlowfishEngine().AlgorithmName, 256);

                BlowFish bcEngine = new BlowFish(new BlowfishEngine(), Encoding.UTF8);
                bcEngine.SetPadding(new Pkcs7Padding());
                return bcEngine.Encrypt(TextPlain, param);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string Decrypt(string TextEncripted, string Password)
        {
            try
            {
                Sha3Digest Sha3Digest = new Sha3Digest();
                Pkcs5S2ParametersGenerator gen = new Pkcs5S2ParametersGenerator(Sha3Digest);
                gen.Init(Encoding.UTF8.GetBytes(Password), Salt, 1000);
                KeyParameter param = (KeyParameter)gen.GenerateDerivedParameters(new BlowfishEngine().AlgorithmName, 256);

                BlowFish bcEngine = new BlowFish(new BlowfishEngine(), Encoding.UTF8);
                bcEngine.SetPadding(new Pkcs7Padding());
                return bcEngine.Decrypt(TextEncripted, param);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        #endregion

        #region Private Methods

        void SetPadding(IBlockCipherPadding padding)
        {
            if (padding != null)
                _padding = padding;
        }

        string Encrypt(string plain, ICipherParameters SetKeyParameter)
        {
            byte[] result = BouncyCastleCrypto(true, _encoding.GetBytes(plain), SetKeyParameter);
            return Convert.ToBase64String(result);
        }

        string Decrypt(string cipher, ICipherParameters SetKeyParameter)
        {
            byte[] result = BouncyCastleCrypto(false, Convert.FromBase64String(cipher), SetKeyParameter);
            return _encoding.GetString(result, 0, result.Length);
        }

        byte[] BouncyCastleCrypto(bool forEncrypt, byte[] input, ICipherParameters SetKeyParameter)
        {
            try
            {
                _cipher = _padding == null ?
                new PaddedBufferedBlockCipher(_blockCipher) : new PaddedBufferedBlockCipher(_blockCipher, _padding);

                _cipher.Init(forEncrypt, SetKeyParameter);

                byte[] ret = _cipher.DoFinal(input);
                return ret;

            }
            catch (CryptoException)
            {
                //
            }
            return null;
        }

        #endregion

        #region For encrypt file
        public static string EncryptFile(string FilePath, string Password)
        {
            string Data = Convert.ToBase64String(File.ReadAllBytes(FilePath));
            return Encrypt(Data, Password);
        }
        public static byte[] DecryptFile(string FileBase64Content, string Password)
        {
            string Data = Decrypt(FileBase64Content, Password);
            if (Data == string.Empty)
                return null;
            else
                return Convert.FromBase64String(Data);
        }
        #endregion
    }
}
