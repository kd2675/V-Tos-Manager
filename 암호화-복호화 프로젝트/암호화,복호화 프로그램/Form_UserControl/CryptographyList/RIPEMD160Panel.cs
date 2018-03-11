using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using RIPEMD160Cryptography;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class RIPEMD160Panel : UserControl
    {
        public RIPEMD160Panel()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (cbHMACMode.Checked)
            {
                tbToText.Text = HMACRIPEMD160Encryption.Encrypt(tbFromText.Text, tbHMACPassword.Text);
            }
            else
            {
                tbToText.Text = RIPEMD160Encryption.Encrypt(tbFromText.Text);
            }
        }

        private void HMACRIPEMD160ModeCheckBox_CheckedChanged(object sender, EventArgs e)
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
            if (cbHMACMode.Checked)
            {
                Task.Factory.StartNew(() =>
                {
                    ControlEnable(this.Controls, false);
                    Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => HMACRIPEMD160Encryption.Encrypt(file, tbHMACPassword.Text)));
                    task.Wait();
                    this.Invoke(new Action(() => tbResult.Text = task.Result));
                    this.Invoke(new Action(() => WarningNotice.Completed()));
                    ControlEnable(this.Controls, true);
                });
            }
            else
            {
                Task.Factory.StartNew(() =>
                {
                    ControlEnable(this.Controls, false);
                    Task<string> task = Task.Factory.StartNew<string>(new Func<string>(() => RIPEMD160Encryption.Encrypt(file)));
                    task.Wait();
                    this.Invoke(new Action(() => tbResult.Text = task.Result));
                    this.Invoke(new Action(() => WarningNotice.Completed()));
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
        public string gbHMACModePassword_Text { set => gbHMACMode.Text = value; }
        public string cbHMACMode_Text { set => cbHMACMode.Text = value; }
    }
}
