namespace 암호화_복호화_프로그램.Form_UserControl.ConvenienceFeaturesList
{
    partial class TranslatorPanel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFromLanguage = new System.Windows.Forms.Label();
            this.lblToLanguage = new System.Windows.Forms.Label();
            this.cbFromLanguage = new System.Windows.Forms.ComboBox();
            this.cbToLanguage = new System.Windows.Forms.ComboBox();
            this.tbBefore = new System.Windows.Forms.TextBox();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.lblFromText = new System.Windows.Forms.Label();
            this.lblToText = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.tmpLnk1 = new System.Windows.Forms.LinkLabel();
            this.gbUsedLanguages1 = new System.Windows.Forms.GroupBox();
            this.tmpLnk2 = new System.Windows.Forms.LinkLabel();
            this.gbUsedLanguages2 = new System.Windows.Forms.GroupBox();
            this.tmpLnk4 = new System.Windows.Forms.LinkLabel();
            this.tmpLnk3 = new System.Windows.Forms.LinkLabel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.gbUsedLanguages1.SuspendLayout();
            this.gbUsedLanguages2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFromLanguage
            // 
            this.lblFromLanguage.AutoSize = true;
            this.lblFromLanguage.Location = new System.Drawing.Point(209, 22);
            this.lblFromLanguage.Name = "lblFromLanguage";
            this.lblFromLanguage.Size = new System.Drawing.Size(69, 12);
            this.lblFromLanguage.TabIndex = 0;
            this.lblFromLanguage.Text = "원래 언어 : ";
            // 
            // lblToLanguage
            // 
            this.lblToLanguage.AutoSize = true;
            this.lblToLanguage.Location = new System.Drawing.Point(209, 60);
            this.lblToLanguage.Name = "lblToLanguage";
            this.lblToLanguage.Size = new System.Drawing.Size(81, 12);
            this.lblToLanguage.TabIndex = 1;
            this.lblToLanguage.Text = "번역할 언어 : ";
            // 
            // cbFromLanguage
            // 
            this.cbFromLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFromLanguage.FormattingEnabled = true;
            this.cbFromLanguage.Location = new System.Drawing.Point(211, 37);
            this.cbFromLanguage.Name = "cbFromLanguage";
            this.cbFromLanguage.Size = new System.Drawing.Size(121, 20);
            this.cbFromLanguage.TabIndex = 2;
            // 
            // cbToLanguage
            // 
            this.cbToLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbToLanguage.FormattingEnabled = true;
            this.cbToLanguage.Location = new System.Drawing.Point(211, 75);
            this.cbToLanguage.Name = "cbToLanguage";
            this.cbToLanguage.Size = new System.Drawing.Size(121, 20);
            this.cbToLanguage.TabIndex = 3;
            // 
            // tbBefore
            // 
            this.tbBefore.Location = new System.Drawing.Point(32, 149);
            this.tbBefore.Multiline = true;
            this.tbBefore.Name = "tbBefore";
            this.tbBefore.Size = new System.Drawing.Size(528, 123);
            this.tbBefore.TabIndex = 4;
            // 
            // tbAfter
            // 
            this.tbAfter.Location = new System.Drawing.Point(32, 296);
            this.tbAfter.Multiline = true;
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.Size = new System.Drawing.Size(528, 123);
            this.tbAfter.TabIndex = 5;
            // 
            // lblFromText
            // 
            this.lblFromText.AutoSize = true;
            this.lblFromText.Location = new System.Drawing.Point(30, 134);
            this.lblFromText.Name = "lblFromText";
            this.lblFromText.Size = new System.Drawing.Size(109, 12);
            this.lblFromText.TabIndex = 6;
            this.lblFromText.Text = "변환할 텍스트 입력";
            // 
            // lblToText
            // 
            this.lblToText.AutoSize = true;
            this.lblToText.Location = new System.Drawing.Point(30, 281);
            this.lblToText.Name = "lblToText";
            this.lblToText.Size = new System.Drawing.Size(29, 12);
            this.lblToText.TabIndex = 7;
            this.lblToText.Text = "결과";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(32, 53);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 56);
            this.btnTranslate.TabIndex = 8;
            this.btnTranslate.Text = "번역하기";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(113, 53);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 56);
            this.btnSpeak.TabIndex = 9;
            this.btnSpeak.Text = "음성 듣기";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.speakBtn_Click);
            // 
            // tmpLnk1
            // 
            this.tmpLnk1.AutoSize = true;
            this.tmpLnk1.Location = new System.Drawing.Point(6, 23);
            this.tmpLnk1.Name = "tmpLnk1";
            this.tmpLnk1.Size = new System.Drawing.Size(0, 12);
            this.tmpLnk1.TabIndex = 10;
            this.tmpLnk1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tmpLnk1_LinkClicked);
            // 
            // gbUsedLanguages1
            // 
            this.gbUsedLanguages1.Controls.Add(this.tmpLnk2);
            this.gbUsedLanguages1.Controls.Add(this.tmpLnk1);
            this.gbUsedLanguages1.Location = new System.Drawing.Point(354, 26);
            this.gbUsedLanguages1.Name = "gbUsedLanguages1";
            this.gbUsedLanguages1.Size = new System.Drawing.Size(206, 48);
            this.gbUsedLanguages1.TabIndex = 11;
            this.gbUsedLanguages1.TabStop = false;
            this.gbUsedLanguages1.Text = "최근에 사용된 원래 언어";
            // 
            // tmpLnk2
            // 
            this.tmpLnk2.AutoSize = true;
            this.tmpLnk2.Location = new System.Drawing.Point(73, 23);
            this.tmpLnk2.Name = "tmpLnk2";
            this.tmpLnk2.Size = new System.Drawing.Size(0, 12);
            this.tmpLnk2.TabIndex = 11;
            this.tmpLnk2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tmpLnk2_LinkClicked);
            // 
            // gbUsedLanguages2
            // 
            this.gbUsedLanguages2.Controls.Add(this.tmpLnk4);
            this.gbUsedLanguages2.Controls.Add(this.tmpLnk3);
            this.gbUsedLanguages2.Location = new System.Drawing.Point(354, 84);
            this.gbUsedLanguages2.Name = "gbUsedLanguages2";
            this.gbUsedLanguages2.Size = new System.Drawing.Size(206, 48);
            this.gbUsedLanguages2.TabIndex = 12;
            this.gbUsedLanguages2.TabStop = false;
            this.gbUsedLanguages2.Text = "최근에 사용된 번역 언어";
            // 
            // tmpLnk4
            // 
            this.tmpLnk4.AutoSize = true;
            this.tmpLnk4.Location = new System.Drawing.Point(73, 23);
            this.tmpLnk4.Name = "tmpLnk4";
            this.tmpLnk4.Size = new System.Drawing.Size(0, 12);
            this.tmpLnk4.TabIndex = 11;
            this.tmpLnk4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tmpLnk4_LinkClicked);
            // 
            // tmpLnk3
            // 
            this.tmpLnk3.AutoSize = true;
            this.tmpLnk3.Location = new System.Drawing.Point(6, 23);
            this.tmpLnk3.Name = "tmpLnk3";
            this.tmpLnk3.Size = new System.Drawing.Size(0, 12);
            this.tmpLnk3.TabIndex = 10;
            this.tmpLnk3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tmpLnk3_LinkClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(30, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 12);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "상태 : 정상";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(209, 107);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(81, 23);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "바꾸기";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(113, 22);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(77, 25);
            this.webBrowser.TabIndex = 15;
            this.webBrowser.Visible = false;
            // 
            // TranslatorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gbUsedLanguages2);
            this.Controls.Add(this.gbUsedLanguages1);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.lblToText);
            this.Controls.Add(this.lblFromText);
            this.Controls.Add(this.tbAfter);
            this.Controls.Add(this.tbBefore);
            this.Controls.Add(this.cbToLanguage);
            this.Controls.Add(this.cbFromLanguage);
            this.Controls.Add(this.lblToLanguage);
            this.Controls.Add(this.lblFromLanguage);
            this.Name = "TranslatorPanel";
            this.Size = new System.Drawing.Size(594, 457);
            this.Load += new System.EventHandler(this.TranslatorPanel_Load);
            this.gbUsedLanguages1.ResumeLayout(false);
            this.gbUsedLanguages1.PerformLayout();
            this.gbUsedLanguages2.ResumeLayout(false);
            this.gbUsedLanguages2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFromLanguage;
        private System.Windows.Forms.Label lblToLanguage;
        private System.Windows.Forms.ComboBox cbFromLanguage;
        private System.Windows.Forms.ComboBox cbToLanguage;
        private System.Windows.Forms.TextBox tbBefore;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.Label lblFromText;
        private System.Windows.Forms.Label lblToText;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.LinkLabel tmpLnk1;
        private System.Windows.Forms.GroupBox gbUsedLanguages1;
        private System.Windows.Forms.LinkLabel tmpLnk2;
        private System.Windows.Forms.GroupBox gbUsedLanguages2;
        private System.Windows.Forms.LinkLabel tmpLnk4;
        private System.Windows.Forms.LinkLabel tmpLnk3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}
