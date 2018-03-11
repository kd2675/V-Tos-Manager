namespace 암호화_복호화_프로그램.Forms
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.보기_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Cryptography_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.DES_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.TripleDES_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.AES_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.RC2_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.SEED_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ARIA_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.BlowFish_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.MD5_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.RIPEMD160_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.SHA_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.RSA_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ECDSA_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Steganography_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.OtherOption_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.RandomCode_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.CDKey_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Translator_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Advice_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramInfo_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.언어_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.English_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.Korean_Tsmi = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowPanel = new System.Windows.Forms.Panel();
            this.UserMenuPanel = new System.Windows.Forms.Panel();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // 보기_Tsmi
            // 
            this.보기_Tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cryptography_Tsmi,
            this.OtherOption_Tsmi});
            this.보기_Tsmi.Name = "보기_Tsmi";
            this.보기_Tsmi.Size = new System.Drawing.Size(43, 20);
            this.보기_Tsmi.Text = "보기";
            // 
            // Cryptography_Tsmi
            // 
            this.Cryptography_Tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DES_Tsmi,
            this.TripleDES_Tsmi,
            this.AES_Tsmi,
            this.RC2_Tsmi,
            this.SEED_Tsmi,
            this.ARIA_Tsmi,
            this.BlowFish_Tsmi,
            this.MD5_Tsmi,
            this.RIPEMD160_Tsmi,
            this.SHA_Tsmi,
            this.RSA_Tsmi,
            this.ECDSA_Tsmi,
            this.Steganography_Tsmi});
            this.Cryptography_Tsmi.Name = "Cryptography_Tsmi";
            this.Cryptography_Tsmi.Size = new System.Drawing.Size(154, 22);
            this.Cryptography_Tsmi.Text = "암호화하기";
            // 
            // DES_Tsmi
            // 
            this.DES_Tsmi.CheckOnClick = true;
            this.DES_Tsmi.Name = "DES_Tsmi";
            this.DES_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.DES_Tsmi.Text = "DES 암호화";
            this.DES_Tsmi.Click += new System.EventHandler(this.DES_Tsmi_Click);
            // 
            // TripleDES_Tsmi
            // 
            this.TripleDES_Tsmi.CheckOnClick = true;
            this.TripleDES_Tsmi.Name = "TripleDES_Tsmi";
            this.TripleDES_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.TripleDES_Tsmi.Text = "Triple DES 암호화";
            this.TripleDES_Tsmi.Click += new System.EventHandler(this.TripleDES_Tsmi_Click);
            // 
            // AES_Tsmi
            // 
            this.AES_Tsmi.CheckOnClick = true;
            this.AES_Tsmi.Name = "AES_Tsmi";
            this.AES_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.AES_Tsmi.Text = "AES 암호화";
            this.AES_Tsmi.Click += new System.EventHandler(this.AES_Tsmi_Click);
            // 
            // RC2_Tsmi
            // 
            this.RC2_Tsmi.CheckOnClick = true;
            this.RC2_Tsmi.Name = "RC2_Tsmi";
            this.RC2_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.RC2_Tsmi.Text = "RC2 암호화";
            this.RC2_Tsmi.Click += new System.EventHandler(this.RC2_Tsmi_Click);
            // 
            // SEED_Tsmi
            // 
            this.SEED_Tsmi.Name = "SEED_Tsmi";
            this.SEED_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.SEED_Tsmi.Text = "SEED 암호화";
            this.SEED_Tsmi.Click += new System.EventHandler(this.SEED_Tsmi_Click);
            // 
            // ARIA_Tsmi
            // 
            this.ARIA_Tsmi.Name = "ARIA_Tsmi";
            this.ARIA_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.ARIA_Tsmi.Text = "ARIA 암호화";
            this.ARIA_Tsmi.Click += new System.EventHandler(this.ARIA_Tsmi_Click);
            // 
            // BlowFish_Tsmi
            // 
            this.BlowFish_Tsmi.Name = "BlowFish_Tsmi";
            this.BlowFish_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.BlowFish_Tsmi.Text = "BlowFish 암호화";
            this.BlowFish_Tsmi.Click += new System.EventHandler(this.BlowFish_Tsmi_Click);
            // 
            // MD5_Tsmi
            // 
            this.MD5_Tsmi.CheckOnClick = true;
            this.MD5_Tsmi.Name = "MD5_Tsmi";
            this.MD5_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.MD5_Tsmi.Text = "MD5 암호화";
            this.MD5_Tsmi.Click += new System.EventHandler(this.MD5_Tsmi_Click);
            // 
            // RIPEMD160_Tsmi
            // 
            this.RIPEMD160_Tsmi.Name = "RIPEMD160_Tsmi";
            this.RIPEMD160_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.RIPEMD160_Tsmi.Text = "RIPEMD160 암호화";
            this.RIPEMD160_Tsmi.Click += new System.EventHandler(this.RIPEMD160_Tsmi_Click);
            // 
            // SHA_Tsmi
            // 
            this.SHA_Tsmi.CheckOnClick = true;
            this.SHA_Tsmi.Name = "SHA_Tsmi";
            this.SHA_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.SHA_Tsmi.Text = "SHA 암호화";
            this.SHA_Tsmi.Click += new System.EventHandler(this.SHA_Tsmi_Click);
            // 
            // RSA_Tsmi
            // 
            this.RSA_Tsmi.CheckOnClick = true;
            this.RSA_Tsmi.Name = "RSA_Tsmi";
            this.RSA_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.RSA_Tsmi.Text = "RSA 암호화";
            this.RSA_Tsmi.Click += new System.EventHandler(this.RSA_Tsmi_Click);
            // 
            // ECDSA_Tsmi
            // 
            this.ECDSA_Tsmi.CheckOnClick = true;
            this.ECDSA_Tsmi.Name = "ECDSA_Tsmi";
            this.ECDSA_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.ECDSA_Tsmi.Text = "ECDSA 암호화";
            this.ECDSA_Tsmi.Click += new System.EventHandler(this.ECDSA_Tsmi_Click);
            // 
            // Steganography_Tsmi
            // 
            this.Steganography_Tsmi.Name = "Steganography_Tsmi";
            this.Steganography_Tsmi.Size = new System.Drawing.Size(195, 22);
            this.Steganography_Tsmi.Text = "Steganography 암호화";
            this.Steganography_Tsmi.Click += new System.EventHandler(this.Steganography_Tsmi_Click);
            // 
            // OtherOption_Tsmi
            // 
            this.OtherOption_Tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandomCode_Tsmi,
            this.CDKey_Tsmi,
            this.Translator_Tsmi});
            this.OtherOption_Tsmi.Name = "OtherOption_Tsmi";
            this.OtherOption_Tsmi.Size = new System.Drawing.Size(154, 22);
            this.OtherOption_Tsmi.Text = "다른 옵션 보기";
            // 
            // RandomCode_Tsmi
            // 
            this.RandomCode_Tsmi.Name = "RandomCode_Tsmi";
            this.RandomCode_Tsmi.Size = new System.Drawing.Size(143, 22);
            this.RandomCode_Tsmi.Text = "랜덤 코드";
            this.RandomCode_Tsmi.Click += new System.EventHandler(this.RandomCode_Tsmi_Click);
            // 
            // CDKey_Tsmi
            // 
            this.CDKey_Tsmi.Name = "CDKey_Tsmi";
            this.CDKey_Tsmi.Size = new System.Drawing.Size(143, 22);
            this.CDKey_Tsmi.Text = "CD-Key 생성";
            this.CDKey_Tsmi.Click += new System.EventHandler(this.CDKey_Tsmi_Click);
            // 
            // Translator_Tsmi
            // 
            this.Translator_Tsmi.Name = "Translator_Tsmi";
            this.Translator_Tsmi.Size = new System.Drawing.Size(143, 22);
            this.Translator_Tsmi.Text = "번역기";
            this.Translator_Tsmi.Click += new System.EventHandler(this.Translator_Tsmi_Click);
            // 
            // 도움말_Tsmi
            // 
            this.도움말_Tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Advice_Tsmi,
            this.ProgramInfo_Tsmi});
            this.도움말_Tsmi.Name = "도움말_Tsmi";
            this.도움말_Tsmi.Size = new System.Drawing.Size(55, 20);
            this.도움말_Tsmi.Text = "도움말";
            // 
            // Advice_Tsmi
            // 
            this.Advice_Tsmi.Name = "Advice_Tsmi";
            this.Advice_Tsmi.Size = new System.Drawing.Size(150, 22);
            this.Advice_Tsmi.Text = "도움말 보기";
            this.Advice_Tsmi.Click += new System.EventHandler(this.Advice_Tsmi_Click);
            // 
            // ProgramInfo_Tsmi
            // 
            this.ProgramInfo_Tsmi.Name = "ProgramInfo_Tsmi";
            this.ProgramInfo_Tsmi.Size = new System.Drawing.Size(150, 22);
            this.ProgramInfo_Tsmi.Text = "프로그램 정보";
            this.ProgramInfo_Tsmi.Click += new System.EventHandler(this.ProgramInfo_Tsmi_Click);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.Info;
            this.MenuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.보기_Tsmi,
            this.도움말_Tsmi,
            this.언어_Tsmi});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(814, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "MenuBar";
            // 
            // 언어_Tsmi
            // 
            this.언어_Tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.English_Tsmi,
            this.Korean_Tsmi});
            this.언어_Tsmi.Name = "언어_Tsmi";
            this.언어_Tsmi.Size = new System.Drawing.Size(43, 20);
            this.언어_Tsmi.Text = "언어";
            // 
            // English_Tsmi
            // 
            this.English_Tsmi.CheckOnClick = true;
            this.English_Tsmi.Name = "English_Tsmi";
            this.English_Tsmi.Size = new System.Drawing.Size(155, 22);
            this.English_Tsmi.Text = "English(영어)";
            this.English_Tsmi.Click += new System.EventHandler(this.English_Tsmi_Click);
            // 
            // Korean_Tsmi
            // 
            this.Korean_Tsmi.CheckOnClick = true;
            this.Korean_Tsmi.Name = "Korean_Tsmi";
            this.Korean_Tsmi.Size = new System.Drawing.Size(155, 22);
            this.Korean_Tsmi.Text = "Korean(한국어)";
            this.Korean_Tsmi.Click += new System.EventHandler(this.Korean_Tsmi_Click);
            // 
            // WindowPanel
            // 
            this.WindowPanel.BackColor = System.Drawing.Color.Transparent;
            this.WindowPanel.Location = new System.Drawing.Point(220, 24);
            this.WindowPanel.Name = "WindowPanel";
            this.WindowPanel.Size = new System.Drawing.Size(600, 500);
            this.WindowPanel.TabIndex = 26;
            // 
            // UserMenuPanel
            // 
            this.UserMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.UserMenuPanel.Location = new System.Drawing.Point(0, 24);
            this.UserMenuPanel.Name = "UserMenuPanel";
            this.UserMenuPanel.Size = new System.Drawing.Size(220, 500);
            this.UserMenuPanel.TabIndex = 27;
            // 
            // MainForm
            // 
            this.BackgroundImage = global::암호화_복호화_프로그램.Properties.Resources.연두색_배경;
            this.ClientSize = new System.Drawing.Size(819, 523);
            this.Controls.Add(this.UserMenuPanel);
            this.Controls.Add(this.WindowPanel);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTOF Manager 2.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem 보기_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem 도움말_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Advice_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem ProgramInfo_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Cryptography_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem DES_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem TripleDES_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem AES_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem RC2_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem MD5_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem SHA_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem RSA_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem ECDSA_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem ARIA_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem SEED_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem RIPEMD160_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem BlowFish_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem 언어_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem English_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Korean_Tsmi;
        private System.Windows.Forms.Panel WindowPanel;
        private System.Windows.Forms.Panel UserMenuPanel;
        private System.Windows.Forms.ToolStripMenuItem OtherOption_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem RandomCode_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem CDKey_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Translator_Tsmi;
        private System.Windows.Forms.ToolStripMenuItem Steganography_Tsmi;
    }
}

