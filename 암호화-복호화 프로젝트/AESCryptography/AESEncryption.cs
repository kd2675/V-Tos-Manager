using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace AESCryptography
{
    public static class AESEncryption
    {
        public delegate void ProgressEvent(long num);
        public static event ProgressEvent runEvent = null;

        public static String Encrypt(String message, String key, String IV)
        {
            byte[] pbyteKey = Encoding.UTF8.GetBytes(key);
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV);
            String strReturn;

            using (RijndaelManaged aes = new RijndaelManaged())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = pbyteKey;
                aes.IV = pbyteIV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptStream = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] data = Encoding.UTF8.GetBytes(message.ToCharArray());
                        cryptStream.Write(data, 0, data.Length);
                    }

                    strReturn = Convert.ToBase64String(ms.ToArray());
                }
            }

            return strReturn;
        }

        public static String Decrypt(String message, String key, String IV)
        {
            byte[] pbyteKey = Encoding.UTF8.GetBytes(key);
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV);
            String strReturn;

            using (RijndaelManaged aes = new RijndaelManaged())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = pbyteKey;
                aes.IV = pbyteIV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptStream = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        byte[] data = Convert.FromBase64String(message);
                        cryptStream.Write(data, 0, data.Length);
                    }

                    strReturn = Encoding.UTF8.GetString(ms.ToArray());
                }
            }

            return strReturn;
        }

        public static void Encrypt(FileInfo readFileName, FileInfo writeFileName, String key, String IV)
        {
            long progress = 0;

            byte[] pbyteKey = Encoding.UTF8.GetBytes(key);
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV);

            using (RijndaelManaged aes = new RijndaelManaged())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = pbyteKey;
                aes.IV = pbyteIV;

                using (FileStream fromFile = new FileStream(readFileName.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (FileStream toFile = new FileStream(writeFileName.FullName, FileMode.Create, FileAccess.Write))
                    {
                        using (CryptoStream cryptScream = new CryptoStream(toFile, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            byte[] buffer = new byte[1048576]; //1MB
                            int read;

                            while ((read = fromFile.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cryptScream.Write(buffer, 0, read);
                                progress += read;
                                runEvent?.Invoke(progress);
                            }
                        }
                    }
                }
            }
        }

        public static void Decrypt(FileInfo readFileName, FileInfo writeFileName, String key, String IV)
        {
            long progress = 0;

            byte[] pbyteKey = Encoding.UTF8.GetBytes(key);
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV);

            using (RijndaelManaged aes = new RijndaelManaged())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = pbyteKey;
                aes.IV = pbyteIV;

                using (FileStream fromFile = new FileStream(readFileName.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (FileStream toFile = new FileStream(writeFileName.FullName, FileMode.Create, FileAccess.Write))
                    {
                        using (CryptoStream cryptScream = new CryptoStream(fromFile, aes.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            string tmpFile = Path.GetTempFileName();
                            FileStream tmp = new FileStream(tmpFile, FileMode.Create, FileAccess.Write);

                            byte[] buffer = new byte[1048576]; //1MB
                            int read;

                            while ((read = cryptScream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                toFile.Write(buffer, 0, read);
                                progress += read;
                                runEvent?.Invoke(progress);
                            }
                        }
                    }
                }
            }
        }
    }
}
