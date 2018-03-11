namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    partial class ARIAPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARIAPanel));
            this.lblResult = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.ArrowPictureBox = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbFromText = new System.Windows.Forms.TextBox();
            this.tbToText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(337, 81);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 15);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "결과";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInput.Location = new System.Drawing.Point(18, 81);
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
            this.ArrowPictureBox.Location = new System.Drawing.Point(259, 209);
            this.ArrowPictureBox.Name = "ArrowPictureBox";
            this.ArrowPictureBox.Size = new System.Drawing.Size(77, 77);
            this.ArrowPictureBox.TabIndex = 7;
            this.ArrowPictureBox.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(29, 23);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(129, 32);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "비밀키 입력 :\r\n(16,24,32글자) ";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(158, 28);
            this.tbPassword.MaxLength = 32;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(93, 21);
            this.tbPassword.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDecrypt.Location = new System.Drawing.Point(439, 10);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(131, 50);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "복호화하기";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEncrypt.Location = new System.Drawing.Point(287, 10);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(131, 50);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "암호화하기";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbFromText
            // 
            this.tbFromText.Location = new System.Drawing.Point(21, 99);
            this.tbFromText.Multiline = true;
            this.tbFromText.Name = "tbFromText";
            this.tbFromText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFromText.Size = new System.Drawing.Size(230, 311);
            this.tbFromText.TabIndex = 1;
            // 
            // tbToText
            // 
            this.tbToText.Location = new System.Drawing.Point(340, 99);
            this.tbToText.Multiline = true;
            this.tbToText.Name = "tbToText";
            this.tbToText.ReadOnly = true;
            this.tbToText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbToText.Size = new System.Drawing.Size(230, 311);
            this.tbToText.TabIndex = 4;
            // 
            // ARIAPanel
            // 
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.tbToText);
            this.Controls.Add(this.tbFromText);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.ArrowPictureBox);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "ARIAPanel";
            this.Size = new System.Drawing.Size(600, 500);
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.PictureBox ArrowPictureBox;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox tbFromText;
        private System.Windows.Forms.TextBox tbToText;
    }
}
