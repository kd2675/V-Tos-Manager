using System;
using System.Windows.Forms;
using RSACryptography;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class RSAPanel : UserControl
    {
        public RSAPanel()
        {
            InitializeComponent();
        }

        private void btnMakeKey_Click(object sender, EventArgs e)
        {
            (String publicKey, String privateKey) = RSAEncryption.GetKeys();
            tbPublicKey.Text = publicKey;
            tbPrivateKey.Text = privateKey;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                tbToText.Text = RSAEncryption.RSAEncrypt(tbFromText.Text, tbKey.Text);
            }
            catch (Exception)
            {
                WarningNotice.WrongKey();
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                tbToText.Text = RSAEncryption.RSADecrypt(tbFromText.Text, tbKey.Text);
            }
            catch (Exception)
            {
                WarningNotice.WrongKey();
            }
        }

        public string lblPublicKey_Text { set => lblPublicKey.Text = value; }
        public string lblPrivateKey_Text { set => lblPrivateKey.Text = value; }
        public string lblKey_Text { set => lblKey.Text = value; }
        public string lblInput_Text { set => lblInput.Text = value; }
        public string lblResult_Text { set => lblResult.Text = value; }
        public string btnMakeKey_Text { set => btnMakeKey.Text = value; }
        public string btnEncrypt_Text { set => btnEncrypt.Text = value; }
        public string btnDecrypt_Text { set => btnDecrypt.Text = value; }
    }
}
