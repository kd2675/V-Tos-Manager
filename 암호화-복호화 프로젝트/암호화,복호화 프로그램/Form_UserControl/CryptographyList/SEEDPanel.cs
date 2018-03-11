using System;
using System.Windows.Forms;
using SEEDCryptography;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class SEEDPanel : UserControl
    {
        public SEEDPanel()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length != 16)
            {
                WarningNotice.KeyLength(16);
                return;
            }
            tbToText.Text = SEEDEncryption.Encrypt(tbFromText.Text, tbPassword.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length != 16)
            {
                WarningNotice.KeyLength(16);
                return;
            }
            try
            {
                tbToText.Text = SEEDEncryption.Decrypt(tbFromText.Text, tbPassword.Text);
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
