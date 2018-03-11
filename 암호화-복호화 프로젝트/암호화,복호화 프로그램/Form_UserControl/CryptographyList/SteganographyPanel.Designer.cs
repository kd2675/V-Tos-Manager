namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    partial class SteganographyPanel
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
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInput = new System.Windows.Forms.Label();
            this.tbFromText = new System.Windows.Forms.TextBox();
            this.tbToText = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblFileTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIV = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblProgressStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgressStatus = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "mage Files (*.jpg; *.bmp; *.png)|*.jpg;*.jpeg; *.png; *.bmp";
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "PNG File (*.png) | *.png | Bitmap File (*.bmp) | *.bmp | Jpg File (*.jpeg) | *.jp" +
    "eg";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(21, 59);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(248, 190);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.Location = new System.Drawing.Point(306, 271);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(131, 50);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "암호화하기";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.btnDecrypt.Location = new System.Drawing.Point(443, 271);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(131, 50);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "복호화하기";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblIV);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbIV);
            this.panel1.Location = new System.Drawing.Point(306, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 112);
            this.panel1.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInput.Location = new System.Drawing.Point(303, 160);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(137, 15);
            this.lblInput.TabIndex = 10;
            this.lblInput.Text = "변환할 텍스트 입력";
            // 
            // tbFromText
            // 
            this.tbFromText.Location = new System.Drawing.Point(306, 178);
            this.tbFromText.Multiline = true;
            this.tbFromText.Name = "tbFromText";
            this.tbFromText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFromText.Size = new System.Drawing.Size(268, 87);
            this.tbFromText.TabIndex = 1;
            // 
            // tbToText
            // 
            this.tbToText.Location = new System.Drawing.Point(21, 343);
            this.tbToText.Multiline = true;
            this.tbToText.Name = "tbToText";
            this.tbToText.ReadOnly = true;
            this.tbToText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbToText.Size = new System.Drawing.Size(553, 121);
            this.tbToText.TabIndex = 11;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(27, 325);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 15);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "데이터";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(21, 255);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(248, 38);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "파일 불러오기";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lblFileTitle
            // 
            this.lblFileTitle.AutoSize = true;
            this.lblFileTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFileTitle.Location = new System.Drawing.Point(15, 22);
            this.lblFileTitle.Name = "lblFileTitle";
            this.lblFileTitle.Size = new System.Drawing.Size(64, 31);
            this.lblFileTitle.TabIndex = 29;
            this.lblFileTitle.Text = "파일";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(9, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(229, 12);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "비밀키 입력 (AES 방식 (16, 24, 32))";
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.BackColor = System.Drawing.Color.Transparent;
            this.lblIV.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lblIV.Location = new System.Drawing.Point(9, 56);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(75, 12);
            this.lblIV.TabIndex = 19;
            this.lblIV.Text = "IV (16글자)";
            this.lblIV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 29);
            this.tbPassword.MaxLength = 32;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(236, 21);
            this.tbPassword.TabIndex = 0;
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(12, 76);
            this.tbIV.MaxLength = 16;
            this.tbIV.Name = "tbIV";
            this.tbIV.Size = new System.Drawing.Size(236, 21);
            this.tbIV.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProgressStatus,
            this.pbProgressStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 478);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(600, 22);
            this.statusStrip.TabIndex = 34;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblProgressStatus
            // 
            this.lblProgressStatus.Name = "lblProgressStatus";
            this.lblProgressStatus.Size = new System.Drawing.Size(51, 17);
            this.lblProgressStatus.Text = "Status : ";
            // 
            // pbProgressStatus
            // 
            this.pbProgressStatus.Name = "pbProgressStatus";
            this.pbProgressStatus.Size = new System.Drawing.Size(500, 16);
            // 
            // SteganographyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblFileTitle);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbToText);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.tbFromText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.pbImage);
            this.Name = "SteganographyPanel";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox tbFromText;
        private System.Windows.Forms.TextBox tbToText;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblFileTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblProgressStatus;
        private System.Windows.Forms.ToolStripProgressBar pbProgressStatus;
    }
}
