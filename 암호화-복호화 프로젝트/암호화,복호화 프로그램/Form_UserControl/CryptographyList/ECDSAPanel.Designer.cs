namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    partial class ECDSAPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ECDSAPanel));
            this.ECDSAVerifyPanel = new System.Windows.Forms.Panel();
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            this.lblAfter = new System.Windows.Forms.Label();
            this.tbAfter = new System.Windows.Forms.TextBox();
            this.lblBefore = new System.Windows.Forms.Label();
            this.tbBefore = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.ECDSASignaturePanel = new System.Windows.Forms.Panel();
            this.btnSignature = new System.Windows.Forms.Button();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.tbPublicKey = new System.Windows.Forms.TextBox();
            this.tbToText = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.ArrowPictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbFromText = new System.Windows.Forms.TextBox();
            this.ECDSAVerifyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
            this.ECDSASignaturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ECDSAVerifyPanel
            // 
            this.ECDSAVerifyPanel.BackColor = System.Drawing.Color.Moccasin;
            this.ECDSAVerifyPanel.Controls.Add(this.StatusPictureBox);
            this.ECDSAVerifyPanel.Controls.Add(this.lblAfter);
            this.ECDSAVerifyPanel.Controls.Add(this.tbAfter);
            this.ECDSAVerifyPanel.Controls.Add(this.lblBefore);
            this.ECDSAVerifyPanel.Controls.Add(this.tbBefore);
            this.ECDSAVerifyPanel.Controls.Add(this.lblKey);
            this.ECDSAVerifyPanel.Controls.Add(this.tbKey);
            this.ECDSAVerifyPanel.Controls.Add(this.btnVerify);
            this.ECDSAVerifyPanel.Location = new System.Drawing.Point(14, 239);
            this.ECDSAVerifyPanel.Name = "ECDSAVerifyPanel";
            this.ECDSAVerifyPanel.Size = new System.Drawing.Size(560, 199);
            this.ECDSAVerifyPanel.TabIndex = 1;
            // 
            // StatusPictureBox
            // 
            this.StatusPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StatusPictureBox.Image")));
            this.StatusPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("StatusPictureBox.InitialImage")));
            this.StatusPictureBox.Location = new System.Drawing.Point(479, 23);
            this.StatusPictureBox.Name = "StatusPictureBox";
            this.StatusPictureBox.Size = new System.Drawing.Size(62, 62);
            this.StatusPictureBox.TabIndex = 22;
            this.StatusPictureBox.TabStop = false;
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAfter.Location = new System.Drawing.Point(288, 89);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(107, 15);
            this.lblAfter.TabIndex = 21;
            this.lblAfter.Text = "서명 후 데이터";
            // 
            // tbAfter
            // 
            this.tbAfter.Location = new System.Drawing.Point(291, 107);
            this.tbAfter.Multiline = true;
            this.tbAfter.Name = "tbAfter";
            this.tbAfter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAfter.Size = new System.Drawing.Size(250, 75);
            this.tbAfter.TabIndex = 2;
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBefore.Location = new System.Drawing.Point(23, 89);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(107, 15);
            this.lblBefore.TabIndex = 20;
            this.lblBefore.Text = "서명 전 데이터";
            // 
            // tbBefore
            // 
            this.tbBefore.Location = new System.Drawing.Point(23, 107);
            this.tbBefore.Multiline = true;
            this.tbBefore.Name = "tbBefore";
            this.tbBefore.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBefore.Size = new System.Drawing.Size(250, 75);
            this.tbBefore.TabIndex = 1;
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
            this.tbKey.Size = new System.Drawing.Size(250, 50);
            this.tbKey.TabIndex = 0;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Aquamarine;
            this.btnVerify.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnVerify.Location = new System.Drawing.Point(291, 23);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(182, 62);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "데이터 검증하기";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // ECDSASignaturePanel
            // 
            this.ECDSASignaturePanel.BackColor = System.Drawing.Color.Moccasin;
            this.ECDSASignaturePanel.Controls.Add(this.btnSignature);
            this.ECDSASignaturePanel.Controls.Add(this.lblPublicKey);
            this.ECDSASignaturePanel.Controls.Add(this.lblResult);
            this.ECDSASignaturePanel.Controls.Add(this.tbPublicKey);
            this.ECDSASignaturePanel.Controls.Add(this.tbToText);
            this.ECDSASignaturePanel.Controls.Add(this.lblInput);
            this.ECDSASignaturePanel.Controls.Add(this.ArrowPictureBox1);
            this.ECDSASignaturePanel.Controls.Add(this.tbFromText);
            this.ECDSASignaturePanel.Location = new System.Drawing.Point(14, 18);
            this.ECDSASignaturePanel.Name = "ECDSASignaturePanel";
            this.ECDSASignaturePanel.Size = new System.Drawing.Size(560, 212);
            this.ECDSASignaturePanel.TabIndex = 0;
            // 
            // btnSignature
            // 
            this.btnSignature.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSignature.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignature.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSignature.Location = new System.Drawing.Point(404, 128);
            this.btnSignature.Name = "btnSignature";
            this.btnSignature.Size = new System.Drawing.Size(127, 60);
            this.btnSignature.TabIndex = 3;
            this.btnSignature.Text = "서명하기";
            this.btnSignature.UseVisualStyleBackColor = false;
            this.btnSignature.Click += new System.EventHandler(this.btnSignature_Click);
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPublicKey.Location = new System.Drawing.Point(23, 106);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(138, 15);
            this.lblPublicKey.TabIndex = 8;
            this.lblPublicKey.Text = "공개키 (Public Key)";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(333, 8);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 15);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "결과";
            // 
            // tbPublicKey
            // 
            this.tbPublicKey.Location = new System.Drawing.Point(23, 128);
            this.tbPublicKey.Multiline = true;
            this.tbPublicKey.Name = "tbPublicKey";
            this.tbPublicKey.ReadOnly = true;
            this.tbPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPublicKey.Size = new System.Drawing.Size(366, 60);
            this.tbPublicKey.TabIndex = 2;
            this.tbPublicKey.TabStop = false;
            // 
            // tbToText
            // 
            this.tbToText.Location = new System.Drawing.Point(333, 26);
            this.tbToText.Multiline = true;
            this.tbToText.Name = "tbToText";
            this.tbToText.ReadOnly = true;
            this.tbToText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbToText.Size = new System.Drawing.Size(208, 77);
            this.tbToText.TabIndex = 1;
            this.tbToText.TabStop = false;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInput.Location = new System.Drawing.Point(23, 8);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(137, 15);
            this.lblInput.TabIndex = 14;
            this.lblInput.Text = "서명할 텍스트 입력";
            // 
            // ArrowPictureBox1
            // 
            this.ArrowPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.ArrowPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("ArrowPictureBox1.Image")));
            this.ArrowPictureBox1.InitialImage = null;
            this.ArrowPictureBox1.Location = new System.Drawing.Point(244, 26);
            this.ArrowPictureBox1.Name = "ArrowPictureBox1";
            this.ArrowPictureBox1.Size = new System.Drawing.Size(77, 77);
            this.ArrowPictureBox1.TabIndex = 7;
            this.ArrowPictureBox1.TabStop = false;
            // 
            // tbFromText
            // 
            this.tbFromText.Location = new System.Drawing.Point(23, 26);
            this.tbFromText.Multiline = true;
            this.tbFromText.Name = "tbFromText";
            this.tbFromText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFromText.Size = new System.Drawing.Size(208, 77);
            this.tbFromText.TabIndex = 0;
            // 
            // ECDSAPanel
            // 
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.ECDSAVerifyPanel);
            this.Controls.Add(this.ECDSASignaturePanel);
            this.Name = "ECDSAPanel";
            this.Size = new System.Drawing.Size(600, 500);
            this.ECDSAVerifyPanel.ResumeLayout(false);
            this.ECDSAVerifyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            this.ECDSASignaturePanel.ResumeLayout(false);
            this.ECDSASignaturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ECDSAVerifyPanel;
        private System.Windows.Forms.PictureBox StatusPictureBox;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.TextBox tbAfter;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.TextBox tbBefore;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Panel ECDSASignaturePanel;
        private System.Windows.Forms.Button btnSignature;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox tbPublicKey;
        private System.Windows.Forms.TextBox tbToText;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.PictureBox ArrowPictureBox1;
        private System.Windows.Forms.TextBox tbFromText;
    }
}
