using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD5Cryptography;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class MD5Panel : UserControl
    {
        public MD5Panel()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (cbHMACMode.Checked)
            {
                tbToText.Text = HMACMD5Encryption.Encrypt(tbFromText.Text, tbHMAPassword.Text);
            }
            else
            {
                tbToText.Text = MD5Encryption.Encrypt(tbFromText.Text);
            }
        }

        private void HMACMD5ModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHMACMode.Checked)
            {
                tbHMAPassword.ReadOnly = false;
            }
            else
            {
                tbHMAPassword.ReadOnly = true;
                tbHMAPassword.Text = "";
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

        private void btnCheckResult_Click(object sender, EventArgs e)
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
            FileInfo file = new FileInfo(tbPath.Text);
            if (cbHMACMode.Checked)
            {
                Task.Factory.StartNew(() =>
                {
                    ControlEnable(this.Controls, false);
                    Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => HMACMD5Encryption.Encrypt(file, tbHMAPassword.Text)));
                    task.Wait();
                    this.Invoke(new Action(() => tbResult.Text = task.Result));
                    this.Invoke(new Action(() => WarningNotice.Save()));
                    ControlEnable(this.Controls, true);
                });
            }
            else
            {
                Task.Factory.StartNew(() => {
                    ControlEnable(this.Controls, false);
                    Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => MD5Encryption.Encrypt(file)));
                    task.Wait();
                    this.Invoke(new Action(() => tbResult.Text = task.Result));
                    this.Invoke(new Action(() => WarningNotice.Save()));
                    ControlEnable(this.Controls, true);
                });
            }
        }

        private void tbResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        public void ControlEnable(ControlCollection controls, bool enabled)
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Invoke(new Action(() => controls[i].Enabled = enabled));
            }
        }

        public string lblFileTitle_Text { set => lblFileTitle.Text = value; }
        public string lblTextTitle_Text { set => lblTextTitle.Text = value; }
        public string lblHMACPassword_Text { set => lblHMACPassword.Text = value; }
        public string lblInput_Text { set => lblInput.Text = value; }
        public string lblFileResult_Text { set => lblFileResult.Text = value; }
        public string lblTextResult_Text { set => lblTextResult.Text = value; }
        public string btnSelectFile_Text { set => btnSelectFile.Text = value; }
        public string btnCheckResult_Text { set => btnCheckResult.Text = value; }
        public string btnEncrypt_Text { set => btnEncrypt.Text = value; }
        public string gbHMACMode_Text { set => gbHMACMode.Text = value; }
        public string cbHMACMode_Text { set => cbHMACMode.Text = value; }
    }
}
