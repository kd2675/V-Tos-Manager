namespace 암호화_복호화_프로그램.Form_UserControl.ConvenienceFeaturesList
{
    partial class ConvenienceFeaturesMode
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
            this.TranslatorCheckBox = new System.Windows.Forms.CheckBox();
            this.RandomCheckBox = new System.Windows.Forms.CheckBox();
            this.CDKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.CryptographyMode_TLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // CryptographyMode_TLP
            // 
            this.CryptographyMode_TLP.AutoScroll = true;
            this.CryptographyMode_TLP.BackColor = System.Drawing.SystemColors.Highlight;
            this.CryptographyMode_TLP.ColumnCount = 1;
            this.CryptographyMode_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CryptographyMode_TLP.Controls.Add(this.TranslatorCheckBox, 0, 2);
            this.CryptographyMode_TLP.Controls.Add(this.RandomCheckBox, 0, 0);
            this.CryptographyMode_TLP.Controls.Add(this.CDKeyCheckBox, 0, 1);
            this.CryptographyMode_TLP.Location = new System.Drawing.Point(0, 0);
            this.CryptographyMode_TLP.Name = "CryptographyMode_TLP";
            this.CryptographyMode_TLP.Padding = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this.CryptographyMode_TLP.RowCount = 3;
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CryptographyMode_TLP.Size = new System.Drawing.Size(220, 500);
            this.CryptographyMode_TLP.TabIndex = 2;
            // 
            // TranslatorCheckBox
            // 
            this.TranslatorCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.TranslatorCheckBox.AutoSize = true;
            this.TranslatorCheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.TranslatorCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.TranslatorCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranslatorCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TranslatorCheckBox.Location = new System.Drawing.Point(3, 81);
            this.TranslatorCheckBox.Name = "TranslatorCheckBox";
            this.TranslatorCheckBox.Size = new System.Drawing.Size(77, 33);
            this.TranslatorCheckBox.TabIndex = 2;
            this.TranslatorCheckBox.Text = "번역기";
            this.TranslatorCheckBox.UseVisualStyleBackColor = false;
            this.TranslatorCheckBox.Click += new System.EventHandler(this.TranslatorCheckBox_Click);
            // 
            // RandomCheckBox
            // 
            this.RandomCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RandomCheckBox.AutoSize = true;
            this.RandomCheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.RandomCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.RandomCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RandomCheckBox.Location = new System.Drawing.Point(3, 3);
            this.RandomCheckBox.Name = "RandomCheckBox";
            this.RandomCheckBox.Size = new System.Drawing.Size(102, 33);
            this.RandomCheckBox.TabIndex = 0;
            this.RandomCheckBox.Text = "랜덤 코드";
            this.RandomCheckBox.UseVisualStyleBackColor = false;
            this.RandomCheckBox.Click += new System.EventHandler(this.RandomCheckBox_Click);
            // 
            // CDKeyCheckBox
            // 
            this.CDKeyCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.CDKeyCheckBox.AutoSize = true;
            this.CDKeyCheckBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.CDKeyCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.CDKeyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CDKeyCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CDKeyCheckBox.Location = new System.Drawing.Point(3, 42);
            this.CDKeyCheckBox.Name = "CDKeyCheckBox";
            this.CDKeyCheckBox.Size = new System.Drawing.Size(117, 33);
            this.CDKeyCheckBox.TabIndex = 1;
            this.CDKeyCheckBox.Text = "CD 키 생성";
            this.CDKeyCheckBox.UseVisualStyleBackColor = false;
            this.CDKeyCheckBox.Click += new System.EventHandler(this.CDKeyCheckBox_Click);
            // 
            // ConvenienceFeaturesMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CryptographyMode_TLP);
            this.Name = "ConvenienceFeaturesMode";
            this.Size = new System.Drawing.Size(220, 500);
            this.CryptographyMode_TLP.ResumeLayout(false);
            this.CryptographyMode_TLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CryptographyMode_TLP;
        private System.Windows.Forms.CheckBox RandomCheckBox;
        private System.Windows.Forms.CheckBox CDKeyCheckBox;
        private System.Windows.Forms.CheckBox TranslatorCheckBox;
    }
}
