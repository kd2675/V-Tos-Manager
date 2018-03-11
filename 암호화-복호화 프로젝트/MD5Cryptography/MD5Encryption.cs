using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace MD5Cryptography
{
    public static class MD5Encryption
    {
        public static String Encrypt(String message)
        {
            string result;
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message)
        {
            String result;
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = md5.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
    public static class HMACMD5Encryption
    {
        public static String Encrypt(String message, String key)
        {
            String result;
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);

            using (HMACMD5 hmacMd5 = new HMACMD5(keyOfByte))
            {
                byte[] data = hmacMd5.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message, String key)
        {
            String result;
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);

            using (HMACMD5 hmacMd5 = new HMACMD5(keyOfByte))
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = hmacMd5.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
}
