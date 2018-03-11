namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    partial class RSAPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSAPanel));
            this.EncryptPanel = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.tbToText = new System.Windows.Forms.TextBox();
            this.tbFromText = new System.Windows.Forms.TextBox();
            this.ArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.KeyPanel = new System.Windows.Forms.Panel();
            this.tbPrivateKey = new System.Windows.Forms.TextBox();
            this.btnMakeKey = new System.Windows.Forms.Button();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.EncryptPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).BeginInit();
            this.KeyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptPanel
            // 
            this.EncryptPanel.BackColor = System.Drawing.Color.Moccasin;
            this.EncryptPanel.Controls.Add(this.lblResult);
            this.EncryptPanel.Controls.Add(this.lblInput);
            this.EncryptPanel.Controls.Add(this.tbToText);
            this.EncryptPanel.Controls.Add(this.tbFromText);
            this.EncryptPanel.Controls.Add(this.ArrowPictureBox);
            this.EncryptPanel.Controls.Add(this.lblKey);
            this.EncryptPanel.Controls.Add(this.tbKey);
            this.EncryptPanel.Controls.Add(this.btnDecrypt);
            this.EncryptPanel.Controls.Add(this.btnEncrypt);
            this.EncryptPanel.Location = new System.Drawing.Point(14, 173);
            this.EncryptPanel.Name = "EncryptPanel";
            this.EncryptPanel.Size = new System.Drawing.Size(560, 265);
            this.EncryptPanel.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(316, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 15);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "결과";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInput.Location = new System.Drawing.Point(20, 110);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(137, 15);
            this.lblInput.TabIndex = 14;
            this.lblInput.Text = "변환할 텍스트 입력";
            // 
            // tbToText
            // 
            this.tbToText.Location = new System.Drawing.Point(319, 132);
            this.tbToText.Multiline = true;
            this.tbToText.Name = "tbToText";
            this.tbToText.ReadOnly = true;
            this.tbToText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbToText.Size = new System.Drawing.Size(195, 115);
            this.tbToText.TabIndex = 2;
            // 
            // tbFromText
            // 
            this.tbFromText.Location = new System.Drawing.Point(23, 132);
            this.tbFromText.Multiline = true;
            this.tbFromText.Name = "tbFromText";
            this.tbFromText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFromText.Size = new System.Drawing.Size(195, 115);
            this.tbFromText.TabIndex = 1;
            // 
            // ArrowPictureBox
            // 
            this.ArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ArrowPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ArrowPictureBox.Image")));
            this.ArrowPictureBox.InitialImage = null;
            this.ArrowPictureBox.Location = new System.Drawing.Point(230, 147);
            this.ArrowPictureBox.Name = "ArrowPictureBox";
            this.ArrowPictureBox.Size = new System.Drawing.Size(77, 77);
            this.ArrowPictureBox.TabIndex = 7;
            this.ArrowPictureBox.TabStop = false;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.Color.Transparent;
            this.lblKey.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblKey.Location = new System.Drawing.Point(20, 8);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(83, 16);
            this.lblKey.TabIndex = 6;
            this.lblKey.Text = "키 입력 : ";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(23, 32);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKey.Size = new System.Drawing.Size(250, 62);
            this.tbKey.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDecrypt.Location = new System.Drawing.Point(418, 32);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(127, 62);
            this.btnDecrypt.TabIndex = 4;
            this.btnDecrypt.Text = "복호화하기\n[개인키필요]";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEncrypt.Location = new System.Drawing.Point(290, 32);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(122, 62);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "암호화하기\n[공개키필요]";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // KeyPanel
            // 
            this.KeyPanel.BackColor = System.Drawing.Color.Moccasin;
            this.KeyPanel.Controls.Add(this.tbPrivateKey);
            this.KeyPanel.Controls.Add(this.btnMakeKey);
            this.KeyPanel.Controls.Add(this.lblPrivateKey);
            this.KeyPanel.Controls.Add(this.lblPublicKey);
            this.KeyPanel.Controls.Add(this.tbPublicKey);
            this.KeyPanel.Location = new System.Drawing.Point(14, 18);
            this.KeyPanel.Name = "KeyPanel";
            this.KeyPanel.Size = new System.Drawing.Size(560, 132);
            this.KeyPanel.TabIndex = 0;
            // 
            // tbPrivateKey
            // 
            this.tbPrivateKey.Location = new System.Drawing.Point(218, 26);
            this.tbPrivateKey.Multiline = true;
            this.tbPrivateKey.Name = "tbPrivateKey";
            this.tbPrivateKey.ReadOnly = true;
            this.tbPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPrivateKey.Size = new System.Drawing.Size(185, 90);
            this.tbPrivateKey.TabIndex = 1;
            this.tbPrivateKey.TabStop = false;
            // 
            // btnMakeKey
            // 
            this.btnMakeKey.BackColor = System.Drawing.Color.Aquamarine;
            this.btnMakeKey.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMakeKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeKey.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMakeKey.Location = new System.Drawing.Point(418, 44);
            this.btnMakeKey.Name = "btnMakeKey";
            this.btnMakeKey.Size = new System.Drawing.Size(127, 50);
            this.btnMakeKey.TabIndex = 2;
            this.btnMakeKey.Text = "공개키/개인키\n만들기";
            this.btnMakeKey.UseVisualStyleBackColor = false;
            this.btnMakeKey.Click += new System.EventHandler(this.btnMakeKey_Click);
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrivateKey.Location = new System.Drawing.Point(215, 8);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(143, 15);
            this.lblPrivateKey.TabIndex = 9;
            this.lblPrivateKey.Text = "개인키 (Private Key)";
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPublicKey.Location = new System.Drawing.Point(11, 8);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(138, 15);
            this.lblPublicKey.TabIndex = 8;
            this.lblPublicKey.Text = "공개키 (Public Key)";
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(14, 26);
            this.tbPublicKey.Multiline = true;
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.ReadOnly = true;
            this.tbPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPublicKey.Size = new System.Drawing.Size(185, 90);
            this.tbPublicKey.TabIndex = 0;
            this.tbPublicKey.TabStop = false;
            // 
            // RSAPanel
            // 
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.EncryptPanel);
            this.Controls.Add(this.KeyPanel);
            this.Name = "RSAPanel";
            this.Size = new System.Drawing.Size(600, 500);
            this.EncryptPanel.ResumeLayout(false);
            this.EncryptPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).EndInit();
            this.KeyPanel.ResumeLayout(false);
            this.KeyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EncryptPanel;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox tbToText;
        private System.Windows.Forms.TextBox tbFromText;
        private System.Windows.Forms.PictureBox ArrowPictureBox;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Panel KeyPanel;
        private System.Windows.Forms.TextBox tbPrivateKey;
        private System.Windows.Forms.Button btnMakeKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.TextBox tbPublicKey;
    }
}
