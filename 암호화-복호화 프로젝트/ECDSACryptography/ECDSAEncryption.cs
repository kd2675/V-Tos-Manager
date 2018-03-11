using System;
using System.Text;
using System.Security.Cryptography;

namespace ECDSACryptography
{
    public class ECDSAEncryption
    {
        public static (string, string) Encrypt(string message)
        {
            //ECDsaCng ecdsa = new ECDsaCng(): 임의의 키 쌍을 이용하여 초기화
            //ECDsaCng ecdsa = new ECDsaCng(CngKey): 해당 키를 사용하여 초기화
            byte[] keyByte;
            byte[] signature;
            using (ECDsaCng ecdsa = new ECDsaCng()) //키는 랜덤 생성
            {
                //ecdsa.HashAlgorithm = CngAlgorithm.Sha256;
                keyByte = ecdsa.Key.Export(CngKeyBlobFormat.EccPublicBlob); //공개키를 가져옴
                byte[] data = Encoding.UTF8.GetBytes(message); //메세지를 바이트 배열로 변환
                signature = ecdsa.SignData(data); //메시지 서명
            }
            return (Convert.ToBase64String(signature), Convert.ToBase64String(keyByte));
        }
        public static bool Verify(string message, string messageOfSign, string key)
        {
            bool isTF;
            using (ECDsaCng ecdsa = new ECDsaCng(CngKey.Import(Convert.FromBase64String(key), CngKeyBlobFormat.EccPublicBlob)))
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                byte[] signature = Convert.FromBase64String(messageOfSign);
                if (ecdsa.VerifyData(data, signature))
                {
                    isTF = true;
                }
                else
                {
                    isTF = false;
                }
            }
            return isTF;
        }
    }
}
