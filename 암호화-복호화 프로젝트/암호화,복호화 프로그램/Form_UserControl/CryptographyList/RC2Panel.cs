using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using RC2Cryptography;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class RC2Panel : UserControl
    {
        long fileSize = 0;

        public RC2Panel()
        {
            InitializeComponent();
            RC2Encryption.runEvent += SetProgressValue;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length != 8)
            {
                WarningNotice.KeyLength(8);
                return;
            }
            if (tbIV.Text.Length != 8)
            {
                WarningNotice.IVLength(8);
                return;
            }
            tbToText.Text = RC2Encryption.Encrypt(tbFromText.Text, tbPassword.Text, tbIV.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length != 8)
            {
                WarningNotice.KeyLength(8);
                return;
            }
            if (tbIV.Text.Length != 8)
            {
                WarningNotice.IVLength(8);
                return;
            }
            try
            {
                tbToText.Text = RC2Encryption.Decrypt(tbFromText.Text, tbPassword.Text, tbIV.Text);
            }
            catch (Exception)
            {
                WarningNotice.WrongKey();
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == ofdFile.ShowDialog())
            {
                tbPath.Text = ofdFile.FileName;
            }
            ofdFile.FileName = "";
        }

        private void btnFileSave1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPath.Text))
            {
                WarningNotice.InputString();
                return;
            }
            if (!File.Exists(tbPath.Text))
            {
                WarningNotice.NotFound();
                return;
            }
            if (tbPassword.Text.Length != 8)
            {
                WarningNotice.KeyLength(8);
                return;
            }
            if (tbIV.Text.Length != 8)
            {
                WarningNotice.IVLength(8);
                return;
            }
            if (DialogResult.OK == sfdFile.ShowDialog())
            {
                FileInfo file = new FileInfo(tbPath.Text);
                FileInfo result = new FileInfo(sfdFile.FileName);
                Task.Factory.StartNew(() => {
                    ControlEnable(this.Controls, false);
                    fileSize = file.Length;
                    RC2Encryption.Encrypt(file, result, tbPassword.Text, tbIV.Text);
                    this.Invoke(new Action(() => WarningNotice.Save()));
                    ControlEnable(this.Controls, true);
                });
            }
            sfdFile.FileName = "";
        }

        private void btnFileSave2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPath.Text))
            {
                WarningNotice.InputString();
                return;
            }
            if (!File.Exists(tbPath.Text))
            {
                WarningNotice.NotFound();
                return;
            }
            if (tbPassword.Text.Length != 8)
            {
                WarningNotice.KeyLength(8);
                return;
            }
            if (tbIV.Text.Length != 8)
            {
                WarningNotice.IVLength(8);
                return;
            }
            if (DialogResult.OK == sfdFile.ShowDialog())
            {
                FileInfo file = new FileInfo(tbPath.Text);
                FileInfo result = new FileInfo(sfdFile.FileName);
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        ControlEnable(this.Controls, false);
                        fileSize = file.Length;
                        RC2Encryption.Decrypt(file, result, tbPassword.Text, tbIV.Text);
                        this.Invoke(new Action(() => WarningNotice.Save()));
                    }
                    catch (Exception)
                    {
                        WarningNotice.WrongKey();
                    }
                    finally
                    {
                        ControlEnable(this.Controls, true);
                    }
                });
            }
            sfdFile.FileName = "";
        }

        public void ControlEnable(ControlCollection controls, bool enabled)
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Invoke(new Action(() => controls[i].Enabled = enabled));
            }
        }

        private void SetProgressValue(long num)
        {
            this.Invoke(new Action(() => pbProgressStatus.Value = (int)((double)num / fileSize * 100)));
        }

        public string lblFileTitle_Text { set => lblFileTitle.Text = value; }
        public string lblTextTitle_Text { set => lblTextTitle.Text = value; }
        public string lblPassword_Text { set => lblPassword.Text = value; }
        public string lblIV_Text { set => lblIV.Text = value; }
        public string lblInput_Text { set => lblInput.Text = value; }
        public string lblResult_Text { set => lblResult.Text = value; }
        public string btnSelectFile_Text { set => btnSelectFile.Text = value; }
        public string btnFileSave1_Text { set => btnFileSave1.Text = value; }
        public string btnFileSave2_Text { set => btnFileSave2.Text = value; }
        public string btnEncrypt_Text { set => btnEncrypt.Text = value; }
        public string btnDecrypt_Text { set => btnDecrypt.Text = value; }
    }
}
