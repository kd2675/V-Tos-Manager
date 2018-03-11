namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    partial class MD5Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MD5Panel));
            this.lblHMACPassword = new System.Windows.Forms.Label();
            this.tbHMAPassword = new System.Windows.Forms.TextBox();
            this.gbHMACMode = new System.Windows.Forms.GroupBox();
            this.cbHMACMode = new System.Windows.Forms.CheckBox();
            this.lblTextResult = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.ArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.tbToText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbFromText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTextTitle = new System.Windows.Forms.Label();
            this.lblFileTitle = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnCheckResult = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lblFileResult = new System.Windows.Forms.Label();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.gbHMACMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHMACPassword
            // 
            this.lblHMACPassword.AutoSize = true;
            this.lblHMACPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblHMACPassword.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblHMACPassword.Location = new System.Drawing.Point(9, 9);
            this.lblHMACPassword.Name = "lblHMACPassword";
            this.lblHMACPassword.Size = new System.Drawing.Size(65, 16);
            this.lblHMACPassword.TabIndex = 12;
            this.lblHMACPassword.Text = "키 입력";
            this.lblHMACPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHMAPassword
            // 
            this.tbHMAPassword.Location = new System.Drawing.Point(12, 29);
            this.tbHMAPassword.Name = "tbHMAPassword";
            this.tbHMAPassword.ReadOnly = true;
            this.tbHMAPassword.Size = new System.Drawing.Size(149, 21);
            this.tbHMAPassword.TabIndex = 0;
            // 
            // gbHMACMode
            // 
            this.gbHMACMode.Controls.Add(this.cbHMACMode);
            this.gbHMACMode.Location = new System.Drawing.Point(393, 24);
            this.gbHMACMode.Name = "gbHMACMode";
            this.gbHMACMode.Size = new System.Drawing.Size(140, 50);
            this.gbHMACMode.TabIndex = 0;
            this.gbHMACMode.TabStop = false;
            this.gbHMACMode.Text = "HMAC 모드";
            // 
            // cbHMACMode
            // 
            this.cbHMACMode.AutoSize = true;
            this.cbHMACMode.Location = new System.Drawing.Point(10, 20);
            this.cbHMACMode.Name = "cbHMACMode";
            this.cbHMACMode.Size = new System.Drawing.Size(116, 16);
            this.cbHMACMode.TabIndex = 0;
            this.cbHMACMode.Text = "HMAC 모드 설정";
            this.cbHMACMode.UseVisualStyleBackColor = true;
            this.cbHMACMode.CheckedChanged += new System.EventHandler(this.HMACMD5ModeCheckBox_CheckedChanged);
            // 
            // lblTextResult
            // 
            this.lblTextResult.AutoSize = true;
            this.lblTextResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTextResult.Location = new System.Drawing.Point(339, 223);
            this.lblTextResult.Name = "lblTextResult";
            this.lblTextResult.Size = new System.Drawing.Size(37, 15);
            this.lblTextResult.TabIndex = 9;
            this.lblTextResult.Text = "결과";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInput.Location = new System.Drawing.Point(18, 223);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(137, 15);
            this.lblInput.TabIndex = 8;
            this.lblInput.Text = "변환할 텍스트 입력";
            // 
            // ArrowPictureBox
            // 
            this.ArrowPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ArrowPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ArrowPictureBox.BackgroundImage")));
            this.ArrowPictureBox.InitialImage = null;
            this.ArrowPictureBox.Location = new System.Drawing.Point(257, 257);
            this.ArrowPictureBox.Name = "ArrowPictureBox";
            this.ArrowPictureBox.Size = new System.Drawing.Size(77, 77);
            this.ArrowPictureBox.TabIndex = 7;
            this.ArrowPictureBox.TabStop = false;
            // 
            // tbToText
            // 
            this.tbToText.Location = new System.Drawing.Point(342, 241);
            this.tbToText.Multiline = true;
            this.tbToText.Name = "tbToText";
            this.tbToText.ReadOnly = true;
            this.tbToText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbToText.Size = new System.Drawing.Size(230, 122);
            this.tbToText.TabIndex = 8;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEncrypt.Location = new System.Drawing.Point(23, 383);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(170, 50);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "텍스트 변환하기";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbFromText
            // 
            this.tbFromText.Location = new System.Drawing.Point(21, 241);
            this.tbFromText.Multiline = true;
            this.tbFromText.Name = "tbFromText";
            this.tbFromText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFromText.Size = new System.Drawing.Size(230, 122);
            this.tbFromText.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tbHMAPassword);
            this.panel1.Controls.Add(this.lblHMACPassword);
            this.panel1.Location = new System.Drawing.Point(393, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 68);
            this.panel1.TabIndex = 1;
            // 
            // lblTextTitle
            // 
            this.lblTextTitle.AutoSize = true;
            this.lblTextTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTextTitle.Location = new System.Drawing.Point(17, 181);
            this.lblTextTitle.Name = "lblTextTitle";
            this.lblTextTitle.Size = new System.Drawing.Size(172, 31);
            this.lblTextTitle.TabIndex = 29;
            this.lblTextTitle.Text = "텍스트 암호화";
            // 
            // lblFileTitle
            // 
            this.lblFileTitle.AutoSize = true;
            this.lblFileTitle.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFileTitle.Location = new System.Drawing.Point(15, 22);
            this.lblFileTitle.Name = "lblFileTitle";
            this.lblFileTitle.Size = new System.Drawing.Size(147, 31);
            this.lblFileTitle.TabIndex = 28;
            this.lblFileTitle.Text = "파일 암호화";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(274, 61);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(92, 59);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "파일 불러오기";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(23, 61);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(245, 21);
            this.tbPath.TabIndex = 2;
            // 
            // btnCheckResult
            // 
            this.btnCheckResult.BackColor = System.Drawing.Color.Aquamarine;
            this.btnCheckResult.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckResult.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckResult.Location = new System.Drawing.Point(23, 88);
            this.btnCheckResult.Name = "btnCheckResult";
            this.btnCheckResult.Size = new System.Drawing.Size(245, 32);
            this.btnCheckResult.TabIndex = 4;
            this.btnCheckResult.Text = "변환 결과 확인";
            this.btnCheckResult.UseVisualStyleBackColor = false;
            this.btnCheckResult.Click += new System.EventHandler(this.btnCheckResult_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(68, 126);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(298, 21);
            this.tbResult.TabIndex = 5;
            this.tbResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbResult_KeyDown);
            // 
            // lblFileResult
            // 
            this.lblFileResult.AutoSize = true;
            this.lblFileResult.Location = new System.Drawing.Point(21, 129);
            this.lblFileResult.Name = "lblFileResult";
            this.lblFileResult.Size = new System.Drawing.Size(41, 12);
            this.lblFileResult.TabIndex = 31;
            this.lblFileResult.Text = "결과 : ";
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "모든 파일 (*.*)|*.*";
            // 
            // MD5Panel
            // 
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.lblFileResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.lblTextTitle);
            this.Controls.Add(this.lblFileTitle);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnCheckResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbHMACMode);
            this.Controls.Add(this.lblTextResult);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.ArrowPictureBox);
            this.Controls.Add(this.tbToText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbFromText);
            this.Name = "MD5Panel";
            this.Size = new System.Drawing.Size(600, 500);
            this.gbHMACMode.ResumeLayout(false);
            this.gbHMACMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHMACPassword;
        private System.Windows.Forms.TextBox tbHMAPassword;
        private System.Windows.Forms.GroupBox gbHMACMode;
        private System.Windows.Forms.CheckBox cbHMACMode;
        private System.Windows.Forms.Label lblTextResult;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.PictureBox ArrowPictureBox;
        private System.Windows.Forms.TextBox tbToText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbFromText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTextTitle;
        private System.Windows.Forms.Label lblFileTitle;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnCheckResult;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label lblFileResult;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}
