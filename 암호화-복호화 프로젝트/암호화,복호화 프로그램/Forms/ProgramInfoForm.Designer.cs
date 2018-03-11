namespace 암호화_복호화_프로그램.Forms
{
    partial class ProgramInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramInfoForm));
            this.lblDecodingProgram = new System.Windows.Forms.Label();
            this.lblProgramInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDecodingProgram
            // 
            this.lblDecodingProgram.AutoSize = true;
            this.lblDecodingProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDecodingProgram.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDecodingProgram.Location = new System.Drawing.Point(131, 36);
            this.lblDecodingProgram.Name = "lblDecodingProgram";
            this.lblDecodingProgram.Size = new System.Drawing.Size(204, 96);
            this.lblDecodingProgram.TabIndex = 1;
            this.lblDecodingProgram.Text = "Decoding\n Program";
            // 
            // lblProgramInfo
            // 
            this.lblProgramInfo.AutoSize = true;
            this.lblProgramInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProgramInfo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblProgramInfo.Location = new System.Drawing.Point(31, 152);
            this.lblProgramInfo.Name = "lblProgramInfo";
            this.lblProgramInfo.Size = new System.Drawing.Size(354, 140);
            this.lblProgramInfo.TabIndex = 2;
            this.lblProgramInfo.Text = "프로그램 이름: VTOF Manager\r\n(Various-types of function manager)\r\n버전: 2.15\r\n제작자: 김청호\r\n이" +
    "메일 주소: mokpo4550@gmail.com\r\n제작 날짜: 2017/12/27 오후 6시 47분\r\n마지막으로 업데이트된 날짜: 2018/03" +
    "/11 오후 07시 05분";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "닫기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProgramInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblProgramInfo);
            this.Controls.Add(this.lblDecodingProgram);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ProgramInfoForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "프로그램 정보";
            this.Load += new System.EventHandler(this.ProgramInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDecodingProgram;
        private System.Windows.Forms.Label lblProgramInfo;
        private System.Windows.Forms.Button button1;
    }
}