namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    partial class TripleDESPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripleDESPanel));
            this.lblResult = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.ArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbToText = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbFromText = new System.Windows.Forms.TextBox();
            this.lblIV = new System.Windows.Forms.Label();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTextTitle = new System.Windows.Forms.Label();
            this.lblFileTitle = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnFileSave2 = new System.Windows.Forms.Button();
            this.btnFileSave1 = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblProgressStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgressStatus = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(339, 223);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 15);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "결과";
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
            this.ArrowPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ArrowPictureBox.Image")));
            this.ArrowPictureBox.InitialImage = null;
            this.ArrowPictureBox.Location = new System.Drawing.Point(257, 257);
            this.ArrowPictureBox.Name = "ArrowPictureBox";
            this.ArrowPictureBox.Size = new System.Drawing.Size(77, 77);
            this.ArrowPictureBox.TabIndex = 7;
            this.ArrowPictureBox.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPassword.Location = new System.Drawing.Point(9, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 12);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "비밀키 입력";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 29);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(149, 21);
            this.tbPassword.TabIndex = 0;
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
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDecrypt.Location = new System.Drawing.Point(203, 383);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(170, 50);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "텍스트 복호화하기";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
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
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "텍스트 암호화하기";
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
            this.tbFromText.TabIndex = 5;
            // 
            // lblIV
            // 
            this.lblIV.AutoSize = true;
            this.lblIV.BackColor = System.Drawing.Color.Transparent;
            this.lblIV.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIV.Location = new System.Drawing.Point(9, 56);
            this.lblIV.Name = "lblIV";
            this.lblIV.Size = new System.Drawing.Size(68, 12);
            this.lblIV.TabIndex = 13;
            this.lblIV.Text = "IV (8글자)";
            this.lblIV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(12, 76);
            this.tbIV.MaxLength = 8;
            this.tbIV.Name = "tbIV";
            this.tbIV.Size = new System.Drawing.Size(149, 21);
            this.tbIV.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.tbIV);
            this.panel1.Controls.Add(this.lblIV);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Location = new System.Drawing.Point(393, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 114);
            this.panel1.TabIndex = 0;
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
            this.btnSelectFile.TabIndex = 2;
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
            this.tbPath.TabIndex = 1;
            // 
            // btnFileSave2
            // 
            this.btnFileSave2.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFileSave2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFileSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSave2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFileSave2.Location = new System.Drawing.Point(23, 126);
            this.btnFileSave2.Name = "btnFileSave2";
            this.btnFileSave2.Size = new System.Drawing.Size(341, 32);
            this.btnFileSave2.TabIndex = 4;
            this.btnFileSave2.Text = "암호화된 파일을 복호화하고 저장하기";
            this.btnFileSave2.UseVisualStyleBackColor = false;
            this.btnFileSave2.Click += new System.EventHandler(this.btnFileSave2_Click);
            // 
            // btnFileSave1
            // 
            this.btnFileSave1.BackColor = System.Drawing.Color.Aquamarine;
            this.btnFileSave1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFileSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileSave1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFileSave1.Location = new System.Drawing.Point(23, 88);
            this.btnFileSave1.Name = "btnFileSave1";
            this.btnFileSave1.Size = new System.Drawing.Size(245, 32);
            this.btnFileSave1.TabIndex = 3;
            this.btnFileSave1.Text = "파일을 암호화하고 저장하기";
            this.btnFileSave1.UseVisualStyleBackColor = false;
            this.btnFileSave1.Click += new System.EventHandler(this.btnFileSave1_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.Filter = "모든 파일 (*.*)|*.*";
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "모든 파일 (*.*)|*.*";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProgressStatus,
            this.pbProgressStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 478);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(600, 22);
            this.statusStrip.TabIndex = 33;
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
            // TripleDESPanel
            // 
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lblTextTitle);
            this.Controls.Add(this.lblFileTitle);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnFileSave2);
            this.Controls.Add(this.btnFileSave1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.ArrowPictureBox);
            this.Controls.Add(this.tbToText);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.tbFromText);
            this.Name = "TripleDESPanel";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.PictureBox ArrowPictureBox;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbToText;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbFromText;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTextTitle;
        private System.Windows.Forms.Label lblFileTitle;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnFileSave2;
        private System.Windows.Forms.Button btnFileSave1;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblProgressStatus;
        private System.Windows.Forms.ToolStripProgressBar pbProgressStatus;
    }
}
