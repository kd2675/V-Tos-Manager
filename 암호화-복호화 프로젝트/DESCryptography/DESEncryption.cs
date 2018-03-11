using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace DESCryptography
{
    public static class DESEncryption
    {
        public delegate void ProgressEvent(long num);
        public static event ProgressEvent runEvent = null;

        public static String Encrypt(String message, String key, String IV)
        {
            byte[] pbyteKey = Encoding.UTF8.GetBytes(key);
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV);
            String strReturn;

            if (pbyteKey.Length != 8)
            {
                throw (new Exception("Invalid key. Key length must be 8 byte."));
            }

            using (DESCryptoServiceProvider desCSP = new DESCryptoServiceProvider())
            {
                desCSP.Mode = CipherMode.CBC;
                desCSP.Padding = PaddingMode.PKCS7;
                desCSP.Key = pbyteKey;
                desCSP.IV = pbyteIV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptStream = new CryptoStream(ms, desCSP.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        byte[] data = Encoding.UTF8.GetBytes(message.ToCharArray());
                        cryptStream.Write(data, 0, data.Length);
                    }
                    strReturn = Convert.ToBase64String(ms.ToArray());
                }
            }

            return strReturn;
        }

        // DES 알고리즘으로 암호화된 문자열을 받아서 복호화 한 후 암호화 이전의 원래 문자열을 Return 함
        public static String Decrypt(String message, String key, String IV)
        {
            byte[] pbyteKey = Encoding.UTF8.GetBytes(key);
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV);
            String strReturn;

            if (pbyteKey.Length != 8)
            {
                throw (new Exception("Invalid key. Key length must be 8 byte."));
            }

            using (DESCryptoServiceProvider desCSP = new DESCryptoServiceProvider())
            {
                desCSP.Mode = CipherMode.CBC;
                desCSP.Padding = PaddingMode.PKCS7;
                desCSP.Key = pbyteKey;
                desCSP.IV = pbyteIV;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptStream = new CryptoStream(ms, desCSP.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        message = message.Replace(" ", "+");
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

            byte[] pbyteKey = Encoding.UTF8.GetBytes(key);
            byte[] pbyteIV = Encoding.UTF8.GetBytes(IV);

            if (pbyteKey.Length != 8)
            {
                throw (new Exception("Invalid key. Key length must be 8 byte."));
            }

            using (DESCryptoServiceProvider desCsp = new DESCryptoServiceProvider())
            {
                desCsp.Mode = CipherMode.CBC;
                desCsp.Padding = PaddingMode.PKCS7;
                desCsp.Key = pbyteKey;
                desCsp.IV = pbyteIV;

                using (FileStream fromFile = new FileStream(readFileName.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (FileStream toFile = new FileStream(writeFileName.FullName, FileMode.Create, FileAccess.Write))
                    {
                        using (CryptoStream cryptScream = new CryptoStream(toFile, desCsp.CreateEncryptor(), CryptoStreamMode.Write))
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

            if (pbyteKey.Length != 8)
            {
                throw (new Exception("Invalid key. Key length must be 8 byte."));
            }

            using (DESCryptoServiceProvider desCsp = new DESCryptoServiceProvider())
            {
                desCsp.Mode = CipherMode.CBC;
                desCsp.Padding = PaddingMode.PKCS7;
                desCsp.Key = pbyteKey;
                desCsp.IV = pbyteIV;

                using (FileStream fromFile = new FileStream(readFileName.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (FileStream toFile = new FileStream(writeFileName.FullName, FileMode.Create, FileAccess.Write))
                    {
                        using (CryptoStream cryptScream = new CryptoStream(fromFile, desCsp.CreateDecryptor(), CryptoStreamMode.Read))
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
}
