using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace RIPEMD160Cryptography
{
    public static class RIPEMD160Encryption
    {
        public static String Encrypt(String message)
        {
            string result;
            using (RIPEMD160 md5 = new RIPEMD160Managed())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message)
        {
            String result;
            using (RIPEMD160 md5 = new RIPEMD160Managed())
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
    public static class HMACRIPEMD160Encryption
    {
        public static String Encrypt(String message, String key)
        {
            String result;
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);

            using (HMACRIPEMD160 hmacMd5 = new HMACRIPEMD160(keyOfByte))
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

            using (HMACRIPEMD160 hmacMd5 = new HMACRIPEMD160(keyOfByte))
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
