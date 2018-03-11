namespace 암호화_복호화_프로그램.Form_UserControl.ConvenienceFeaturesList
{
    partial class RandomPanel
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
            this.RandomNumberPanel = new System.Windows.Forms.Panel();
            this.lblMaximum = new System.Windows.Forms.Label();
            this.tbMaximum = new System.Windows.Forms.TextBox();
            this.lblRandomNumberResult = new System.Windows.Forms.Label();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.tbMinimum = new System.Windows.Forms.TextBox();
            this.tbRandomNumberResult = new System.Windows.Forms.RichTextBox();
            this.btnGetRandomNumber = new System.Windows.Forms.Button();
            this.RandomCodePanel = new System.Windows.Forms.Panel();
            this.btnSetDefault = new System.Windows.Forms.Button();
            this.lblInclude = new System.Windows.Forms.Label();
            this.tbInclude = new System.Windows.Forms.TextBox();
            this.lblRandomCodeResult = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbRandomCodeResult = new System.Windows.Forms.RichTextBox();
            this.btnGetRandomCode = new System.Windows.Forms.Button();
            this.RandomNumberPanel.SuspendLayout();
            this.RandomCodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RandomNumberPanel
            // 
            this.RandomNumberPanel.BackColor = System.Drawing.Color.LightPink;
            this.RandomNumberPanel.Controls.Add(this.lblMaximum);
            this.RandomNumberPanel.Controls.Add(this.tbMaximum);
            this.RandomNumberPanel.Controls.Add(this.lblRandomNumberResult);
            this.RandomNumberPanel.Controls.Add(this.lblMinimum);
            this.RandomNumberPanel.Controls.Add(this.tbMinimum);
            this.RandomNumberPanel.Controls.Add(this.tbRandomNumberResult);
            this.RandomNumberPanel.Controls.Add(this.btnGetRandomNumber);
            this.RandomNumberPanel.Location = new System.Drawing.Point(21, 247);
            this.RandomNumberPanel.Name = "RandomNumberPanel";
            this.RandomNumberPanel.Size = new System.Drawing.Size(548, 180);
            this.RandomNumberPanel.TabIndex = 1;
            // 
            // lblMaximum
            // 
            this.lblMaximum.AutoSize = true;
            this.lblMaximum.BackColor = System.Drawing.Color.Transparent;
            this.lblMaximum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblMaximum.Location = new System.Drawing.Point(18, 70);
            this.lblMaximum.Name = "lblMaximum";
            this.lblMaximum.Size = new System.Drawing.Size(94, 16);
            this.lblMaximum.TabIndex = 19;
            this.lblMaximum.Text = "최대 숫자 :";
            // 
            // tbMaximum
            // 
            this.tbMaximum.Location = new System.Drawing.Point(21, 89);
            this.tbMaximum.Name = "tbMaximum";
            this.tbMaximum.Size = new System.Drawing.Size(239, 21);
            this.tbMaximum.TabIndex = 1;
            // 
            // lblRandomNumberResult
            // 
            this.lblRandomNumberResult.AutoSize = true;
            this.lblRandomNumberResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRandomNumberResult.Location = new System.Drawing.Point(287, 20);
            this.lblRandomNumberResult.Name = "lblRandomNumberResult";
            this.lblRandomNumberResult.Size = new System.Drawing.Size(107, 15);
            this.lblRandomNumberResult.TabIndex = 17;
            this.lblRandomNumberResult.Text = "랜덤 숫자 결과";
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimum.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblMinimum.Location = new System.Drawing.Point(18, 19);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(94, 16);
            this.lblMinimum.TabIndex = 16;
            this.lblMinimum.Text = "최소 숫자 :";
            // 
            // tbMinimum
            // 
            this.tbMinimum.Location = new System.Drawing.Point(21, 38);
            this.tbMinimum.Name = "tbMinimum";
            this.tbMinimum.Size = new System.Drawing.Size(239, 21);
            this.tbMinimum.TabIndex = 0;
            // 
            // tbRandomNumberResult
            // 
            this.tbRandomNumberResult.Location = new System.Drawing.Point(290, 37);
            this.tbRandomNumberResult.Name = "tbRandomNumberResult";
            this.tbRandomNumberResult.ReadOnly = true;
            this.tbRandomNumberResult.Size = new System.Drawing.Size(241, 125);
            this.tbRandomNumberResult.TabIndex = 3;
            this.tbRandomNumberResult.Text = "";
            // 
            // btnGetRandomNumber
            // 
            this.btnGetRandomNumber.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGetRandomNumber.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetRandomNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRandomNumber.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGetRandomNumber.Location = new System.Drawing.Point(15, 130);
            this.btnGetRandomNumber.Name = "btnGetRandomNumber";
            this.btnGetRandomNumber.Size = new System.Drawing.Size(245, 32);
            this.btnGetRandomNumber.TabIndex = 2;
            this.btnGetRandomNumber.Text = "랜덤 난수 얻기";
            this.btnGetRandomNumber.UseVisualStyleBackColor = false;
            this.btnGetRandomNumber.Click += new System.EventHandler(this.RandomNumberButton_Click);
            // 
            // RandomCodePanel
            // 
            this.RandomCodePanel.BackColor = System.Drawing.Color.LightPink;
            this.RandomCodePanel.Controls.Add(this.btnSetDefault);
            this.RandomCodePanel.Controls.Add(this.lblInclude);
            this.RandomCodePanel.Controls.Add(this.tbInclude);
            this.RandomCodePanel.Controls.Add(this.lblRandomCodeResult);
            this.RandomCodePanel.Controls.Add(this.lblLength);
            this.RandomCodePanel.Controls.Add(this.tbLength);
            this.RandomCodePanel.Controls.Add(this.tbRandomCodeResult);
            this.RandomCodePanel.Controls.Add(this.btnGetRandomCode);
            this.RandomCodePanel.Location = new System.Drawing.Point(21, 26);
            this.RandomCodePanel.Name = "RandomCodePanel";
            this.RandomCodePanel.Size = new System.Drawing.Size(548, 205);
            this.RandomCodePanel.TabIndex = 0;
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSetDefault.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSetDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetDefault.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetDefault.Location = new System.Drawing.Point(21, 153);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(245, 31);
            this.btnSetDefault.TabIndex = 3;
            this.btnSetDefault.Text = "문자를 기본값으로 설정";
            this.btnSetDefault.UseVisualStyleBackColor = false;
            this.btnSetDefault.Click += new System.EventHandler(this.RandomCodeButton2_Click);
            // 
            // lblInclude
            // 
            this.lblInclude.AutoSize = true;
            this.lblInclude.BackColor = System.Drawing.Color.Transparent;
            this.lblInclude.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblInclude.Location = new System.Drawing.Point(16, 67);
            this.lblInclude.Name = "lblInclude";
            this.lblInclude.Size = new System.Drawing.Size(111, 16);
            this.lblInclude.TabIndex = 11;
            this.lblInclude.Text = "포함할 문자 :";
            // 
            // tbInclude
            // 
            this.tbInclude.Location = new System.Drawing.Point(21, 86);
            this.tbInclude.Name = "tbInclude";
            this.tbInclude.Size = new System.Drawing.Size(245, 21);
            this.tbInclude.TabIndex = 1;
            // 
            // lblRandomCodeResult
            // 
            this.lblRandomCodeResult.AutoSize = true;
            this.lblRandomCodeResult.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRandomCodeResult.Location = new System.Drawing.Point(287, 18);
            this.lblRandomCodeResult.Name = "lblRandomCodeResult";
            this.lblRandomCodeResult.Size = new System.Drawing.Size(107, 15);
            this.lblRandomCodeResult.TabIndex = 9;
            this.lblRandomCodeResult.Text = "랜덤 코드 결과";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.Transparent;
            this.lblLength.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.lblLength.Location = new System.Drawing.Point(16, 18);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(77, 16);
            this.lblLength.TabIndex = 6;
            this.lblLength.Text = "총 길이 :";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(19, 37);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(247, 21);
            this.tbLength.TabIndex = 0;
            // 
            // tbRandomCodeResult
            // 
            this.tbRandomCodeResult.Location = new System.Drawing.Point(290, 36);
            this.tbRandomCodeResult.Name = "tbRandomCodeResult";
            this.tbRandomCodeResult.ReadOnly = true;
            this.tbRandomCodeResult.Size = new System.Drawing.Size(240, 148);
            this.tbRandomCodeResult.TabIndex = 4;
            this.tbRandomCodeResult.Text = "";
            // 
            // btnGetRandomCode
            // 
            this.btnGetRandomCode.BackColor = System.Drawing.Color.Aquamarine;
            this.btnGetRandomCode.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGetRandomCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetRandomCode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnGetRandomCode.Location = new System.Drawing.Point(21, 115);
            this.btnGetRandomCode.Name = "btnGetRandomCode";
            this.btnGetRandomCode.Size = new System.Drawing.Size(245, 32);
            this.btnGetRandomCode.TabIndex = 2;
            this.btnGetRandomCode.Text = "랜덤 코드 얻기";
            this.btnGetRandomCode.UseVisualStyleBackColor = false;
            this.btnGetRandomCode.Click += new System.EventHandler(this.RandomCodeButton1_Click);
            // 
            // RandomPanel
            // 
            this.BackColor = System.Drawing.Color.HotPink;
            this.Controls.Add(this.RandomNumberPanel);
            this.Controls.Add(this.RandomCodePanel);
            this.Name = "RandomPanel";
            this.Size = new System.Drawing.Size(594, 457);
            this.RandomNumberPanel.ResumeLayout(false);
            this.RandomNumberPanel.PerformLayout();
            this.RandomCodePanel.ResumeLayout(false);
            this.RandomCodePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RandomNumberPanel;
        private System.Windows.Forms.Label lblMaximum;
        private System.Windows.Forms.TextBox tbMaximum;
        private System.Windows.Forms.Label lblRandomNumberResult;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.TextBox tbMinimum;
        private System.Windows.Forms.RichTextBox tbRandomNumberResult;
        private System.Windows.Forms.Button btnGetRandomNumber;
        private System.Windows.Forms.Panel RandomCodePanel;
        private System.Windows.Forms.Button btnSetDefault;
        private System.Windows.Forms.Label lblInclude;
        private System.Windows.Forms.TextBox tbInclude;
        private System.Windows.Forms.Label lblRandomCodeResult;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.RichTextBox tbRandomCodeResult;
        private System.Windows.Forms.Button btnGetRandomCode;
    }
}
