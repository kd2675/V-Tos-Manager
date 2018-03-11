using System;
using System.Windows.Forms;
using ECDSACryptography;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class ECDSAPanel : UserControl
    {
        public ECDSAPanel()
        {
            InitializeComponent();
        }

        private void btnSignature_Click(object sender, EventArgs e)
        {
            (string result, string publicKey) = ECDSAEncryption.Encrypt(tbFromText.Text);
            tbToText.Text = result;
            tbPublicKey.Text = publicKey;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (ECDSAEncryption.Verify(tbBefore.Text, tbAfter.Text, tbKey.Text))
                {
                    StatusPictureBox.Image = global::암호화_복호화_프로그램.Properties.Resources.ok;
                }
                else
                {
                    StatusPictureBox.Image = global::암호화_복호화_프로그램.Properties.Resources.error;
                }
            }
            catch (Exception)
            {
                WarningNotice.WrongKey();
            }
        }

        public string lblInput_Text { set => lblInput.Text = value; }
        public string lblResult_Text { set => lblResult.Text = value; }
        public string lblPublicKey_Text { set => lblPublicKey.Text = value; }
        public string lblKey_Text { set => lblKey.Text = value; }
        public string lblBefore_Text { set => lblBefore.Text = value; }
        public string lblAfter_Text { set => lblAfter.Text = value; }
        public string btnSignature_Text { set => btnSignature.Text = value; }
        public string btnVerify_Text { set => btnVerify.Text = value; }
    }
}
