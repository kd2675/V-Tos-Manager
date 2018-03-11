namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    partial class CryptographyMode
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
            this.CryptographyMode_TLP = new System.Windows.Forms.TableLayoutPanel();
            this.DESCheckBox = new System.Windows.Forms.CheckBox();
            this.TripleDESCheckBox = new System.Windows.Forms.CheckBox();
            this.AESCheckBox = new System.Windows.Forms.CheckBox();
            this.RC2CheckBox = new System.Windows.Forms.CheckBox();
            this.SEEDCheckBox = new System.Windows.Forms.CheckBox();
            this.ARIACheckBox = new System.Windows.Forms.CheckBox();
            this.BlowFishCheckBox = new System.Windows.Forms.CheckBox();
            this.MD5CheckBox = new System.Windows.Forms.CheckBox();
            this.RIPEMD160CheckBox = new System.Windows.Forms.CheckBox();
            this.SHACheckBox = new System.Windows.Forms.CheckBox();
            this.RSACheckBox = new System.Windows.Forms.CheckBox();
            this.ECDSACheckBox = new System.Windows.Forms.CheckBox();
            this.SteganographyCheckBox = new System.Windows.Forms.CheckBox();
            this.CryptographyMode_TLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // CryptographyMode_TLP
            // 
            this.CryptographyMode_TLP.AutoScroll = true;
            this.CryptographyMode_TLP.BackColor = System.Drawing.SystemColors.Highlight;
            this.CryptographyMode_TLP.ColumnCount = 1;
            this.CryptographyMode_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CryptographyMode_TLP.Controls.Add(this.SteganographyCheckBox, 0, 12);
            this.CryptographyMode_TLP.Controls.Add(this.DESCheckBox, 0, 0);
            this.CryptographyMode_TLP.Controls.Add(this.TripleDESCheckBox, 0, 1);
            this.CryptographyMode_TLP.Controls.Add(this.AESCheckBox, 0, 2);
            this.CryptographyMode_TLP.Controls.Add(this.RC2CheckBox, 0, 3);
            this.CryptographyMode_TLP.Controls.Add(this.SEEDCheckBox, 0, 4);
            this.CryptographyMode_TLP.Controls.Add(this.ARIACheckBox, 0, 5);
            this.CryptographyMode_TLP.Controls.Add(this.BlowFishCheckBox, 0, 6);
            this.CryptographyMode_TLP.Controls.Add(this.MD5CheckBox, 0, 7);
            this.CryptographyMode_TLP.Controls.Add(this.RIPEMD160CheckBox, 0, 8);
            this.CryptographyMode_TLP.Controls.Add(this.SHACheckBox, 0, 9);
            this.CryptographyMode_TLP.Controls.Add(this.RSACheckBox, 0, 10);
            this.CryptographyMode_TLP.Controls.Add(this.ECDSACheckBox, 0, 11);
            this.CryptographyMode_TLP.Location = new System.Drawing.Point(0, 0);
            this.CryptographyMode_TLP.Name = "CryptographyMode_TLP";
            this.CryptographyMode_TLP.Padding = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this.CryptographyMode_TLP.RowCount = 13;
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.Size = new System.Drawing.Size(220, 500);
            this.CryptographyMode_TLP.TabIndex = 1;
            // 
            // DESCheckBox
            // 
            this.DESCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.DESCheckBox.AutoSize = true;
            this.DESCheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.DESCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.DESCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DESCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DESCheckBox.Location = new System.Drawing.Point(3, 3);
            this.DESCheckBox.Name = "DESCheckBox";
            this.DESCheckBox.Size = new System.Drawing.Size(102, 33);
            this.DESCheckBox.TabIndex = 0;
            this.DESCheckBox.Text = "DES 모드";
            this.DESCheckBox.UseVisualStyleBackColor = false;
            this.DESCheckBox.Click += new System.EventHandler(this.DESCheckBox_Click);
            // 
            // TripleDESCheckBox
            // 
            this.TripleDESCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.TripleDESCheckBox.AutoSize = true;
            this.TripleDESCheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.TripleDESCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.TripleDESCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TripleDESCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TripleDESCheckBox.Location = new System.Drawing.Point(3, 42);
            this.TripleDESCheckBox.Name = "TripleDESCheckBox";
            this.TripleDESCheckBox.Size = new System.Drawing.Size(159, 33);
            this.TripleDESCheckBox.TabIndex = 1;
            this.TripleDESCheckBox.Text = "Triple DES 모드";
            this.TripleDESCheckBox.UseVisualStyleBackColor = false;
            this.TripleDESCheckBox.Click += new System.EventHandler(this.TripleDESCheckBox_Click);
            // 
            // AESCheckBox
            // 
            this.AESCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.AESCheckBox.AutoSize = true;
            this.AESCheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.AESCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.AESCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AESCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AESCheckBox.Location = new System.Drawing.Point(3, 81);
            this.AESCheckBox.Name = "AESCheckBox";
            this.AESCheckBox.Size = new System.Drawing.Size(102, 33);
            this.AESCheckBox.TabIndex = 2;
            this.AESCheckBox.Text = "AES 모드";
            this.AESCheckBox.UseVisualStyleBackColor = false;
            this.AESCheckBox.Click += new System.EventHandler(this.AESCheckBox_Click);
            // 
            // RC2CheckBox
            // 
            this.RC2CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RC2CheckBox.AutoSize = true;
            this.RC2CheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.RC2CheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.RC2CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RC2CheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RC2CheckBox.Location = new System.Drawing.Point(3, 120);
            this.RC2CheckBox.Name = "RC2CheckBox";
            this.RC2CheckBox.Size = new System.Drawing.Size(101, 33);
            this.RC2CheckBox.TabIndex = 3;
            this.RC2CheckBox.Text = "RC2 모드";
            this.RC2CheckBox.UseVisualStyleBackColor = false;
            this.RC2CheckBox.Click += new System.EventHandler(this.RC2CheckBox_Click);
            // 
            // SEEDCheckBox
            // 
            this.SEEDCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SEEDCheckBox.AutoSize = true;
            this.SEEDCheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.SEEDCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.SEEDCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SEEDCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SEEDCheckBox.Location = new System.Drawing.Point(3, 159);
            this.SEEDCheckBox.Name = "SEEDCheckBox";
            this.SEEDCheckBox.Size = new System.Drawing.Size(114, 33);
            this.SEEDCheckBox.TabIndex = 4;
            this.SEEDCheckBox.Text = "SEED 모드";
            this.SEEDCheckBox.UseVisualStyleBackColor = false;
            this.SEEDCheckBox.Click += new System.EventHandler(this.SEEDCheckBox_Click);
            // 
            // ARIACheckBox
            // 
            this.ARIACheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ARIACheckBox.AutoSize = true;
            this.ARIACheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.ARIACheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ARIACheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ARIACheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ARIACheckBox.Location = new System.Drawing.Point(3, 198);
            this.ARIACheckBox.Name = "ARIACheckBox";
            this.ARIACheckBox.Size = new System.Drawing.Size(111, 33);
            this.ARIACheckBox.TabIndex = 5;
            this.ARIACheckBox.Text = "ARIA 모드";
            this.ARIACheckBox.UseVisualStyleBackColor = false;
            this.ARIACheckBox.Click += new System.EventHandler(this.ARIACheckBox_Click);
            // 
            // BlowFishCheckBox
            // 
            this.BlowFishCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.BlowFishCheckBox.AutoSize = true;
            this.BlowFishCheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.BlowFishCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BlowFishCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlowFishCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BlowFishCheckBox.Location = new System.Drawing.Point(3, 237);
            this.BlowFishCheckBox.Name = "BlowFishCheckBox";
            this.BlowFishCheckBox.Size = new System.Drawing.Size(145, 33);
            this.BlowFishCheckBox.TabIndex = 6;
            this.BlowFishCheckBox.Text = "BlowFish 모드";
            this.BlowFishCheckBox.UseVisualStyleBackColor = false;
            this.BlowFishCheckBox.Click += new System.EventHandler(this.BlowFishCheckBox_Click);
            // 
            // MD5CheckBox
            // 
            this.MD5CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.MD5CheckBox.AutoSize = true;
            this.MD5CheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.MD5CheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.MD5CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MD5CheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MD5CheckBox.Location = new System.Drawing.Point(3, 276);
            this.MD5CheckBox.Name = "MD5CheckBox";
            this.MD5CheckBox.Size = new System.Drawing.Size(110, 33);
            this.MD5CheckBox.TabIndex = 7;
            this.MD5CheckBox.Text = "MD5 모드";
            this.MD5CheckBox.UseVisualStyleBackColor = false;
            this.MD5CheckBox.Click += new System.EventHandler(this.MD5CheckBox_Click);
            // 
            // RIPEMD160CheckBox
            // 
            this.RIPEMD160CheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RIPEMD160CheckBox.AutoSize = true;
            this.RIPEMD160CheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.RIPEMD160CheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.RIPEMD160CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RIPEMD160CheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RIPEMD160CheckBox.Location = new System.Drawing.Point(3, 315);
            this.RIPEMD160CheckBox.Name = "RIPEMD160CheckBox";
            this.RIPEMD160CheckBox.Size = new System.Drawing.Size(175, 33);
            this.RIPEMD160CheckBox.TabIndex = 8;
            this.RIPEMD160CheckBox.Text = "RIPEMD160 모드";
            this.RIPEMD160CheckBox.UseVisualStyleBackColor = false;
            this.RIPEMD160CheckBox.Click += new System.EventHandler(this.RIPEMD160CheckBox_Click);
            // 
            // SHACheckBox
            // 
            this.SHACheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SHACheckBox.AutoSize = true;
            this.SHACheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.SHACheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.SHACheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SHACheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SHACheckBox.Location = new System.Drawing.Point(3, 354);
            this.SHACheckBox.Name = "SHACheckBox";
            this.SHACheckBox.Size = new System.Drawing.Size(105, 33);
            this.SHACheckBox.TabIndex = 9;
            this.SHACheckBox.Text = "SHA 모드";
            this.SHACheckBox.UseVisualStyleBackColor = false;
            this.SHACheckBox.Click += new System.EventHandler(this.SHACheckBox_Click);
            // 
            // RSACheckBox
            // 
            this.RSACheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RSACheckBox.AutoSize = true;
            this.RSACheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.RSACheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.RSACheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RSACheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RSACheckBox.Location = new System.Drawing.Point(3, 393);
            this.RSACheckBox.Name = "RSACheckBox";
            this.RSACheckBox.Size = new System.Drawing.Size(102, 33);
            this.RSACheckBox.TabIndex = 10;
            this.RSACheckBox.Text = "RSA 모드";
            this.RSACheckBox.UseVisualStyleBackColor = false;
            this.RSACheckBox.Click += new System.EventHandler(this.RSACheckBox_Click);
            // 
            // ECDSACheckBox
            // 
            this.ECDSACheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ECDSACheckBox.AutoSize = true;
            this.ECDSACheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.ECDSACheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ECDSACheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ECDSACheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ECDSACheckBox.Location = new System.Drawing.Point(3, 432);
            this.ECDSACheckBox.Name = "ECDSACheckBox";
            this.ECDSACheckBox.Size = new System.Drawing.Size(130, 33);
            this.ECDSACheckBox.TabIndex = 11;
            this.ECDSACheckBox.Text = "ECDSA 모드";
            this.ECDSACheckBox.UseVisualStyleBackColor = false;
            this.ECDSACheckBox.Click += new System.EventHandler(this.ECDSACheckBox_Click);
            // 
            // SteganographyCheckBox
            // 
            this.SteganographyCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.SteganographyCheckBox.AutoSize = true;
            this.SteganographyCheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.SteganographyCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.SteganographyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SteganographyCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SteganographyCheckBox.Location = new System.Drawing.Point(3, 471);
            this.SteganographyCheckBox.Name = "SteganographyCheckBox";
            this.SteganographyCheckBox.Size = new System.Drawing.Size(153, 33);
            this.SteganographyCheckBox.TabIndex = 12;
            this.SteganographyCheckBox.Text = "스테가노그래피";
            this.SteganographyCheckBox.UseVisualStyleBackColor = false;
            this.SteganographyCheckBox.Click += new System.EventHandler(this.SteganographyCheckBox_Click);
            // 
            // CryptographyMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CryptographyMode_TLP);
            this.Name = "CryptographyMode";
            this.Size = new System.Drawing.Size(220, 500);
            this.CryptographyMode_TLP.ResumeLayout(false);
            this.CryptographyMode_TLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CryptographyMode_TLP;
        private System.Windows.Forms.CheckBox DESCheckBox;
        private System.Windows.Forms.CheckBox TripleDESCheckBox;
        private System.Windows.Forms.CheckBox AESCheckBox;
        private System.Windows.Forms.CheckBox RC2CheckBox;
        private System.Windows.Forms.CheckBox SEEDCheckBox;
        private System.Windows.Forms.CheckBox ARIACheckBox;
        private System.Windows.Forms.CheckBox BlowFishCheckBox;
        private System.Windows.Forms.CheckBox MD5CheckBox;
        private System.Windows.Forms.CheckBox RIPEMD160CheckBox;
        private System.Windows.Forms.CheckBox SHACheckBox;
        private System.Windows.Forms.CheckBox RSACheckBox;
        private System.Windows.Forms.CheckBox ECDSACheckBox;
        private System.Windows.Forms.CheckBox SteganographyCheckBox;
    }
}
