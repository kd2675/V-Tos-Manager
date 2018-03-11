using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace SHACryptography
{
    public static class SHA1Encryption
    {
        public static String Encrypt(String message)
        {
            string result;
            using (SHA1 sha1 = new SHA1CryptoServiceProvider())
            {
                byte[] data = sha1.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message)
        {
            String result;
            using (SHA1 sha1 = new SHA1CryptoServiceProvider())
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = sha1.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
    public static class SHA256Encryption
    {
        public static String Encrypt(String message)
        {
            string result;
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message)
        {
            String result;
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = sha256.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
    public static class SHA384Encryption
    {
        public static String Encrypt(String message)
        {
            string result;
            using (SHA384 sha384 = new SHA384CryptoServiceProvider())
            {
                byte[] data = sha384.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message)
        {
            String result;
            using (SHA384 sha384 = new SHA384CryptoServiceProvider())
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = sha384.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
    public class SHA512Encryption
    {
        public static String Encrypt(String message)
        {
            string result;
            using (SHA512 sha512 = new SHA512CryptoServiceProvider())
            {
                byte[] data = sha512.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message)
        {
            String result;
            using (SHA512 sha512 = new SHA512CryptoServiceProvider())
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = sha512.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
    public static class HMACSHA1Encryption
    {
        public static String Encrypt(String message, String key)
        {
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);
            String result;
            using (HMACSHA1 sha1 = new HMACSHA1(keyOfByte))
            {
                byte[] data = sha1.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message, String key)
        {
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);
            String result;
            using (HMACSHA1 sha1 = new HMACSHA1(keyOfByte))
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = sha1.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
    public static class HMACSHA256Encryption
    {
        public static String Encrypt(String message, String key)
        {
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);
            String result;
            using (HMACSHA256 sha256 = new HMACSHA256(keyOfByte))
            {
                byte[] data = sha256.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message, String key)
        {
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);
            String result;
            using (HMACSHA256 sha256 = new HMACSHA256(keyOfByte))
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = sha256.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
    public static class HMACSHA384Encryption
    {
        public static String Encrypt(String message, String key)
        {
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);
            String result;
            using (HMACSHA384 sha384 = new HMACSHA384(keyOfByte))
            {
                byte[] data = sha384.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message, String key)
        {
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);
            String result;
            using (HMACSHA384 sha384 = new HMACSHA384(keyOfByte))
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = sha384.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
    public static class HMACSHA512Encryption
    {
        public static String Encrypt(String message, String key)
        {
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);
            String result;
            using (HMACSHA512 sha512 = new HMACSHA512(keyOfByte))
            {
                byte[] data = sha512.ComputeHash(Encoding.UTF8.GetBytes(message));
                result = Convert.ToBase64String(data);
            }
            return result;
        }

        public static String Encrypt(FileInfo message, String key)
        {
            byte[] keyOfByte = Encoding.UTF8.GetBytes(key);
            String result;
            using (HMACSHA512 sha512 = new HMACSHA512(keyOfByte))
            {
                using (FileStream fs = new FileStream(message.FullName, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] data = sha512.ComputeHash(fs);
                    result = Convert.ToBase64String(data);
                }
            }
            return result;
        }
    }
}
