using System;
using System.Text;
using System.Windows.Forms;
using ARIACryptography.Angelkum.Cipher;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class ARIAPanel : UserControl
    {
        public ARIAPanel()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length != 16 && tbPassword.Text.Length != 24 && tbPassword.Text.Length != 32)
            {
                WarningNotice.KeyLength(16, 24, 32);
                return;
            }
            ARIAEncryption aria = new ARIAEncryption(Encoding.UTF8.GetBytes(tbPassword.Text));
            tbToText.Text = aria.EncryptString(tbFromText.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length != 16 && tbPassword.Text.Length != 24 && tbPassword.Text.Length != 32)
            {
                WarningNotice.KeyLength(16, 24, 32);
                return;
            }
            try
            {
                ARIAEncryption aria = new ARIAEncryption(Encoding.UTF8.GetBytes(tbPassword.Text));
                tbToText.Text = aria.DecryptString(tbFromText.Text);
            }
            catch (Exception)
            {
                WarningNotice.WrongKey();
            }
        }

        public string lblPassword_Text { set => lblPassword.Text = value; }
        public string lblInput_Text { set => lblInput.Text = value; }
        public string lblResult_Text { set => lblResult.Text = value; }
        public string btnEncrypt_Text { set => btnEncrypt.Text = value; }
        public string btnDecrypt_Text { set => btnDecrypt.Text = value; }
    }
}
