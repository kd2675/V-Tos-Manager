using System;
using System.Text;
using System.Windows.Forms;
using BlowFishCryptography;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class BlowFishPanel : UserControl
    {
        public BlowFishPanel()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbIV.Text.Length != 8)
            {
                WarningNotice.IVLength(8);
                return;
            }
            if (!(tbPassword.Text.Length > 0 && tbPassword.Text.Length <= 56))
            {
                WarningNotice.KeyLength(1, 56);
                return;
            }
            BlowFishEncryption blow = new BlowFishEncryption(Encoding.UTF8.GetBytes(tbPassword.Text));
            blow.IV = Encoding.UTF8.GetBytes(tbIV.Text);
            byte[] result = blow.Encrypt_CBC(Encoding.UTF8.GetBytes(tbFromText.Text));
            tbToText.Text = Convert.ToBase64String(result);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbIV.Text.Length != 8)
            {
                WarningNotice.IVLength(8);
            }
            if (!(tbPassword.Text.Length > 0 && tbPassword.Text.Length <= 56))
            {
                WarningNotice.KeyLength(1, 56);
                return;
            }
            try
            {
                BlowFishEncryption blow = new BlowFishEncryption(Encoding.UTF8.GetBytes(tbPassword.Text));
                blow.IV = Encoding.UTF8.GetBytes(tbIV.Text);
                byte[] result = blow.Decrypt_CBC(Convert.FromBase64String(tbFromText.Text));
                tbToText.Text = Encoding.UTF8.GetString(result);
            }
            catch (Exception)
            {
                WarningNotice.WrongKey();
            }
        }

        public string lblPassword_Text { set => lblPassword.Text = value; }
        public string lblIV_Text { set => lblIV.Text = value; }
        public string lblInput_Text { set => lblInput.Text = value; }
        public string lblResult_Text { set => lblResult.Text = value; }
        public string btnEncrypt_Text { set => btnEncrypt.Text = value; }
        public string btnDecrypt_Text { set => btnDecrypt.Text = value; }
    }
}
