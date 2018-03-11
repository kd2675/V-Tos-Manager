using System;
using System.Drawing;
using System.Windows.Forms;
using Steganography;
using System.Drawing.Imaging;
using AESCryptography;
using System.Threading.Tasks;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class SteganographyPanel : UserControl
    {
        long fileSize = 0;

        public SteganographyPanel()
        {
            InitializeComponent();
            SteganographyConvert.runEvent += SetProgressValue;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofdFile.FileName);
                pbImage.Image = image;
            }
            ofdFile.FileName = "";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                WarningNotice.NoImage();
                return;
            }
            if (tbPassword.Text.Length != 16 && tbPassword.Text.Length != 24 && tbPassword.Text.Length != 32)
            {
                WarningNotice.KeyLength(16, 24, 32);
                return;
            }
            if (tbIV.Text.Length != 16)
            {
                WarningNotice.IVLength(16);
                return;
            }
            Bitmap bitmap = (Bitmap)pbImage.Image;
            Bitmap result;

            if (sfdFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = sfdFile.FileName;
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        string hiddenText = AESEncryption.Encrypt(tbFromText.Text, tbPassword.Text, tbIV.Text);
                        ControlEnable(this.Controls, false);
                        fileSize = bitmap.Height;
                        result = SteganographyConvert.Encrypt(hiddenText, (Bitmap)bitmap.Clone());

                        switch (sfdFile.FilterIndex)
                        {
                            case 0: result.Save(fileName, ImageFormat.Png); break;
                            case 1: result.Save(fileName, ImageFormat.Bmp); break;
                            case 2: result.Save(fileName, ImageFormat.Jpeg); break;
                        }
                        this.Invoke(new Action(() => WarningNotice.Save()));
                    }
                    catch (SteganographySizeException ex)
                    {
                        this.Invoke(new Action(() => WarningNotice.CantConvertImage()));
                    }
                    finally
                    {
                        ControlEnable(this.Controls, true);
                    }
                });
            }
            sfdFile.FileName = "";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                WarningNotice.NoImage();
                return;
            }
            if (tbPassword.Text.Length != 16 && tbPassword.Text.Length != 24 && tbPassword.Text.Length != 32)
            {
                WarningNotice.KeyLength(16, 24, 32);
                return;
            }
            if (tbIV.Text.Length != 16)
            {
                WarningNotice.IVLength(16);
                return;
            }
            Bitmap bitmap = (Bitmap)pbImage.Image;

            Task.Factory.StartNew(() =>
            {
                ControlEnable(this.Controls, false);
                fileSize = bitmap.Height;
                string hiddenText = SteganographyConvert.Decrypt(bitmap);
                this.Invoke(new Action(() =>
                {
                    try
                    {
                        tbToText.Text = AESEncryption.Decrypt(hiddenText, tbPassword.Text, tbIV.Text);
                        WarningNotice.Completed();
                    }
                    catch (Exception)
                    {
                        this.Invoke(new Action(() => WarningNotice.WrongKey()));
                    }
                }));
                ControlEnable(this.Controls, true);
            });
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
        public string lblPassword_Text { set => lblPassword.Text = value; }
        public string lblIV_Text { set => lblIV.Text = value; }
        public string lblInput_Text { set => lblInput.Text = value; }
        public string lblResult_Text { set => lblResult.Text = value; }
        public string btnSelectFile_Text { set => btnSelectFile.Text = value; }
        public string btnEncrypt_Text { set => btnEncrypt.Text = value; }
        public string btnDecrypt_Text { set => btnDecrypt.Text = value; }
    }
}
