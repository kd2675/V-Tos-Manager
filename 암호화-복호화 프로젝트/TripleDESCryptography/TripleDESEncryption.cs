using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace TripleDESCryptography
{
    public static class TripleDESEncryption
    {
        public delegate void ProgressEvent(long num);
        public static event ProgressEvent runEvent = null;

        public static String Encrypt(String message, String key, String IV)
        {
            byte[] pbyteKey;
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV); ;
            String strReturn;

            using (MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider())
            {
                pbyteKey = HashProvider.ComputeHash(Encoding.UTF8.GetBytes(key));
            }

            using (TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider())
            {
                TDESAlgorithm.Key = pbyteKey;
                TDESAlgorithm.Mode = CipherMode.CBC;
                TDESAlgorithm.Padding = PaddingMode.PKCS7;
                TDESAlgorithm.IV = pbyteIV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptStream = new CryptoStream(ms, TDESAlgorithm.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] data = Encoding.UTF8.GetBytes(message);
                        cryptStream.Write(data, 0, data.Length);
                    }
                    strReturn = Convert.ToBase64String(ms.ToArray());
                }
            }

            return strReturn;
        }

        public static String Decrypt(String message, String key, String IV)
        {
            
            byte[] pbyteKey;
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV); ;
            String strReturn;

            using (MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider())
            {
                pbyteKey = HashProvider.ComputeHash(Encoding.UTF8.GetBytes(key));
            }

            using (TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider())
            {
                TDESAlgorithm.Key = pbyteKey;
                TDESAlgorithm.Mode = CipherMode.CBC;
                TDESAlgorithm.Padding = PaddingMode.PKCS7;
                TDESAlgorithm.IV = pbyteIV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptStream = new CryptoStream(ms, TDESAlgorithm.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        byte[] data = Convert.FromBase64String(message);
                        cryptStream.Write(data, 0, data.Length);
                    }
                    strReturn = Encoding.UTF8.GetString(ms.GetBuffer()).Trim('\0');
                }
            }

            return strReturn;
        }

        public static void Encrypt(FileInfo readFileName, FileInfo writeFileName, String key, String IV)
        {
            long progress = 0;

            byte[] pbyteKey;
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV);

            using (MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider())
            {
                pbyteKey = HashProvider.ComputeHash(Encoding.UTF8.GetBytes(key));
            }

            using (TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider())
            {
                TDESAlgorithm.Mode = CipherMode.CBC;
                TDESAlgorithm.Padding = PaddingMode.PKCS7;
                TDESAlgorithm.Key = pbyteKey;
                TDESAlgorithm.IV = pbyteIV;

                using (FileStream fromFile = new FileStream(readFileName.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (FileStream toFile = new FileStream(writeFileName.FullName, FileMode.Create, FileAccess.Write))
                    {
                        using (CryptoStream cryptScream = new CryptoStream(toFile, TDESAlgorithm.CreateEncryptor(), CryptoStreamMode.Write))
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

            byte[] pbyteKey;
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV);

            using (MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider())
            {
                pbyteKey = HashProvider.ComputeHash(Encoding.UTF8.GetBytes(key));
            }

            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Mode = CipherMode.CBC;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            TDESAlgorithm.Key = pbyteKey;
            TDESAlgorithm.IV = pbyteIV;

            using (FileStream fromFile = new FileStream(readFileName.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (FileStream toFile = new FileStream(writeFileName.FullName, FileMode.Create, FileAccess.Write))
                {
                    using (CryptoStream cryptScream = new CryptoStream(fromFile, TDESAlgorithm.CreateDecryptor(), CryptoStreamMode.Read))
                    {
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
