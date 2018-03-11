using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RavSoft.GoogleTranslator;

namespace 암호화_복호화_프로그램.Form_UserControl.ConvenienceFeaturesList
{
    public partial class TranslatorPanel : UserControl
    {
        private string translationSpeakUrl; //음성 듣기 링크
        private List<string> list1;
        private List<string> list2;
        private string[] translateStatus;

        public TranslatorPanel()
        {
            InitializeComponent();
        }

        private void TranslatorPanel_Load(object sender, EventArgs e)
        {
            this.cbFromLanguage.Items.AddRange(Translator.Languages.ToArray());
            this.cbToLanguage.Items.AddRange(Translator.Languages.ToArray());
            this.cbFromLanguage.SelectedItem = "English";
            this.cbToLanguage.SelectedItem = "Korean";
            webBrowser = new WebBrowser();
            list1 = new List<string>(new string[] { "", "", "" });
            list2 = new List<string>(new string[] { "", "", "" });
            translateStatus = new string[] {
                "상태 : ", "상태 : 번역 중입니다...", "상태 : 번역 완료", "상태 : 오류 발생"
            };
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            Translator t = new Translator();

            this.tbAfter.Text = string.Empty;
            this.tbAfter.Update();
            this.translationSpeakUrl = null;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.lblStatus.Text = translateStatus[1];

                list1.RemoveAt(2);
                list2.RemoveAt(2);
                list1.Insert(0, (string)cbFromLanguage.SelectedItem);
                list2.Insert(0, (string)cbToLanguage.SelectedItem);
                tmpLnk1.Text = list1[0]; tmpLnk2.Text = list1[1]; tmpLnk3.Text = list2[0]; tmpLnk4.Text = list2[1];

                this.lblStatus.Update();
                this.tbAfter.Text = t.Translate(this.tbBefore.Text.Trim(), (string)this.cbFromLanguage.SelectedItem, (string)this.cbToLanguage.SelectedItem);
                this.lblStatus.Text = translateStatus[2];
                this.lblStatus.Update();

                if (t.Error == null)
                {
                    this.tbAfter.Update();
                    this.translationSpeakUrl = t.TranslationSpeechUrl;
                }
                else
                {
                    this.lblStatus.Text = translateStatus[3];
                    this.lblStatus.Update();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void speakBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.translationSpeakUrl))
            {
                this.webBrowser.Navigate(this.translationSpeakUrl);
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            string from = (string)this.cbFromLanguage.SelectedItem;
            string to = (string)this.cbToLanguage.SelectedItem;
            this.cbFromLanguage.SelectedItem = to;
            this.cbToLanguage.SelectedItem = from;

            this.tbBefore.Text = this.tbAfter.Text;
            this.tbAfter.Text = string.Empty;
            this.Update();
            this.translationSpeakUrl = string.Empty;

            this.lblStatus.Text = translateStatus[0];
            this.lblStatus.Update();
        }

        private void tmpLnk1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((string)this.cbFromLanguage.SelectedItem != "")
                this.cbFromLanguage.SelectedItem = tmpLnk1.Text;
        }

        private void tmpLnk2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((string)this.cbFromLanguage.SelectedItem != "")
                this.cbFromLanguage.SelectedItem = tmpLnk2.Text;
        }

        private void tmpLnk3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((string)this.cbFromLanguage.SelectedItem != "")
                this.cbToLanguage.SelectedItem = tmpLnk3.Text;
        }

        private void tmpLnk4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((string)this.cbFromLanguage.SelectedItem != "")
                this.cbToLanguage.SelectedItem = tmpLnk4.Text;
        }

        public string translateBtn_Text { set => btnTranslate.Text = value; }
        public string speakBtn_Text { set => btnSpeak.Text = value; }
        public string changeBtn_Text { set => btnChange.Text = value; }
        public string fromLanguageLbl_Text { set => lblFromLanguage.Text = value; }
        public string toLanguageLbl_Text { set => lblToLanguage.Text = value; }
        public string fromTextLbl_Text { set => lblFromText.Text = value; }
        public string toTextLbl_Text { set => lblToText.Text = value; }
        public string usedLanguages1_Text { set => gbUsedLanguages1.Text = value; }
        public string usedLanguages2_Text { set => gbUsedLanguages2.Text = value; }
        public string[] translateStatus_Text { set { translateStatus = value; lblStatus.Text = translateStatus[0]; } }
    }
}
