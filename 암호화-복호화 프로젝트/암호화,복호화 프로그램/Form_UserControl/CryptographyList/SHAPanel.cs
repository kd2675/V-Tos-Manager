using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHACryptography;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class SHAPanel : UserControl
    {
        public SHAPanel()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            switch (gbSHAMode.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked))
            {
                case RadioButton rb1 when rb1.Name == rdbtnSHA1.Name: tbToText.Text = (cbHMACMode.Checked) ? HMACSHA1Encryption.Encrypt(tbFromText.Text, tbHMACPassword.Text) : SHA1Encryption.Encrypt(tbFromText.Text); break;
                case RadioButton rb2 when rb2.Name == rdbtnSHA256.Name: tbToText.Text = (cbHMACMode.Checked) ? HMACSHA256Encryption.Encrypt(tbFromText.Text, tbHMACPassword.Text) : SHA256Encryption.Encrypt(tbFromText.Text); break;
                case RadioButton rb3 when rb3.Name == rdbtnSHA384.Name: tbToText.Text = (cbHMACMode.Checked) ? HMACSHA384Encryption.Encrypt(tbFromText.Text, tbHMACPassword.Text) : SHA384Encryption.Encrypt(tbFromText.Text); break;
                case RadioButton rb4 when rb4.Name == rdbtnSHA512.Name: tbToText.Text = (cbHMACMode.Checked) ? HMACSHA512Encryption.Encrypt(tbFromText.Text, tbHMACPassword.Text) : SHA512Encryption.Encrypt(tbFromText.Text); break;
            }
        }

        private void HMACSHAModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHMACMode.Checked)
            {
                tbHMACPassword.ReadOnly = false;
            }
            else
            {
                tbHMACPassword.ReadOnly = true;
                tbHMACPassword.Text = "";
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
            Task.Factory.StartNew(() =>
            {
                switch (gbSHAMode.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked))
                {
                    case RadioButton rb1 when rb1.Name == rdbtnSHA1.Name:
                        if (cbHMACMode.Checked)
                        {
                            ControlEnable(this.Controls, false);
                            Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => HMACSHA1Encryption.Encrypt(file, tbHMACPassword.Text)));
                            task.Wait();
                            this.Invoke(new Action(() => tbResult.Text = task.Result));
                            this.Invoke(new Action(() => WarningNotice.Completed()));
                            ControlEnable(this.Controls, true);
                        }
                        else
                        {
                            ControlEnable(this.Controls, false);
                            Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => SHA1Encryption.Encrypt(file)));
                            task.Wait();
                            this.Invoke(new Action(() => tbResult.Text = task.Result));
                            this.Invoke(new Action(() => WarningNotice.Completed()));
                            ControlEnable(this.Controls, true);
                        }
                        break;
                    case RadioButton rb2 when rb2.Name == rdbtnSHA256.Name:
                        if (cbHMACMode.Checked)
                        {
                            ControlEnable(this.Controls, false);
                            Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => HMACSHA256Encryption.Encrypt(file, tbHMACPassword.Text)));
                            task.Wait();
                            this.Invoke(new Action(() => tbResult.Text = task.Result));
                            this.Invoke(new Action(() => WarningNotice.Completed()));
                            ControlEnable(this.Controls, true);
                        }
                        else
                        {
                            ControlEnable(this.Controls, false);
                            Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => SHA256Encryption.Encrypt(file)));
                            task.Wait();
                            this.Invoke(new Action(() => tbResult.Text = task.Result));
                            this.Invoke(new Action(() => WarningNotice.Completed()));
                            ControlEnable(this.Controls, true);
                        }
                        break;
                    case RadioButton rb3 when rb3.Name == rdbtnSHA384.Name:
                        if (cbHMACMode.Checked)
                        {
                            ControlEnable(this.Controls, false);
                            Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => HMACSHA384Encryption.Encrypt(file, tbHMACPassword.Text)));
                            task.Wait();
                            this.Invoke(new Action(() => tbResult.Text = task.Result));
                            this.Invoke(new Action(() => WarningNotice.Completed()));
                            ControlEnable(this.Controls, true);
                        }
                        else
                        {
                            ControlEnable(this.Controls, false);
                            Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => SHA384Encryption.Encrypt(file)));
                            task.Wait();
                            this.Invoke(new Action(() => tbResult.Text = task.Result));
                            this.Invoke(new Action(() => WarningNotice.Completed()));
                            ControlEnable(this.Controls, true);
                        }
                        break;
                    case RadioButton rb4 when rb4.Name == rdbtnSHA512.Name:
                        if (cbHMACMode.Checked)
                        {
                            ControlEnable(this.Controls, false);
                            Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => HMACSHA512Encryption.Encrypt(file, tbHMACPassword.Text)));
                            task.Wait();
                            this.Invoke(new Action(() => tbResult.Text = task.Result));
                            this.Invoke(new Action(() => WarningNotice.Completed()));
                            ControlEnable(this.Controls, true);
                        }
                        else
                        {
                            ControlEnable(this.Controls, false);
                            Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => SHA512Encryption.Encrypt(file)));
                            task.Wait();
                            this.Invoke(new Action(() => tbResult.Text = task.Result));
                            this.Invoke(new Action(() => WarningNotice.Completed()));
                            ControlEnable(this.Controls, true);
                        }
                        break;
                }
            });
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

        public string gbSHAMode_Text { set => gbSHAMode.Text = value; }
        public string rdbtnSHA1_Text { set => rdbtnSHA1.Text = value; }
        public string rdbtnSHA256_Text { set => rdbtnSHA256.Text = value; }
        public string rdbtnSHA384_Text { set => rdbtnSHA384.Text = value; }
        public string rdbtnSHA512_Text { set => rdbtnSHA512.Text = value; }
    }
}
