using System;
using System.Text;
using System.Security.Cryptography;

namespace RSACryptography
{
    public static class RSAEncryption
    {
        public static (string pubKey, string priKey) GetKeys()
        {
            // 암호화 개체 생성
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            // 개인키 생성
            RSAParameters privateKey = RSA.Create().ExportParameters(true);
            rsa.ImportParameters(privateKey);
            string privateKeyText = rsa.ToXmlString(true);

            // 공개키 생성
            RSAParameters publicKey = new RSAParameters();
            publicKey.Modulus = privateKey.Modulus;
            publicKey.Exponent = privateKey.Exponent;
            rsa.ImportParameters(publicKey);
            string publicKeyText = rsa.ToXmlString(false);
            
            return (publicKeyText, privateKeyText);
        }

        // RSA 암호화 (공개키를 이용하여 내용을 암호화)
        public static string RSAEncrypt(string getValue, string pubKey)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(); //암호화
            rsa.FromXmlString(pubKey);

            //암호화할 문자열을 UFT8인코딩
            byte[] inbuf = (new UTF8Encoding()).GetBytes(getValue);

            //암호화
            byte[] encbuf = rsa.Encrypt(inbuf, false);

            //암호화된 문자열 Base64인코딩
            return Convert.ToBase64String(encbuf);
        }

        // RSA 복호화 (개인키를 이용하여 암호를 복호화)
        public static string RSADecrypt(string getValue, string priKey)
        {
            //RSA객체생성
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(); //복호화
            rsa.FromXmlString(priKey);

            //sValue문자열을 바이트배열로 변환
            byte[] srcbuf = Convert.FromBase64String(getValue);

            //바이트배열 복호화
            byte[] decbuf = rsa.Decrypt(srcbuf, false);

            //복호화 바이트배열을 문자열로 변환
            string sDec = (new UTF8Encoding()).GetString(decbuf, 0, decbuf.Length);
            return sDec;
        }
    }
}
