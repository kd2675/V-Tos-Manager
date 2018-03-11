namespace 암호화_복호화_프로그램.Forms
{
    partial class AdviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdviceForm));
            this.Advice_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CryptographyCheckBox = new System.Windows.Forms.CheckBox();
            this.ConvenientOptionCheckBox = new System.Windows.Forms.CheckBox();
            this.WindowAdvicePanel = new System.Windows.Forms.Panel();
            this.Advice_FlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Advice_FlowLayoutPanel
            // 
            this.Advice_FlowLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Advice_FlowLayoutPanel.Controls.Add(this.CryptographyCheckBox);
            this.Advice_FlowLayoutPanel.Controls.Add(this.ConvenientOptionCheckBox);
            this.Advice_FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.Advice_FlowLayoutPanel.Name = "Advice_FlowLayoutPanel";
            this.Advice_FlowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 17, 0);
            this.Advice_FlowLayoutPanel.Size = new System.Drawing.Size(151, 430);
            this.Advice_FlowLayoutPanel.TabIndex = 13;
            // 
            // CryptographyCheckBox
            // 
            this.CryptographyCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.CryptographyCheckBox.AutoSize = true;
            this.CryptographyCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CryptographyCheckBox.Checked = true;
            this.CryptographyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CryptographyCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.CryptographyCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CryptographyCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CryptographyCheckBox.Location = new System.Drawing.Point(3, 3);
            this.CryptographyCheckBox.Name = "CryptographyCheckBox";
            this.CryptographyCheckBox.Size = new System.Drawing.Size(121, 33);
            this.CryptographyCheckBox.TabIndex = 2;
            this.CryptographyCheckBox.Text = "암호화 종류";
            this.CryptographyCheckBox.UseVisualStyleBackColor = false;
            this.CryptographyCheckBox.Click += new System.EventHandler(this.CryptographyCheckBox_Click);
            // 
            // ConvenientOptionCheckBox
            // 
            this.ConvenientOptionCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ConvenientOptionCheckBox.AutoSize = true;
            this.ConvenientOptionCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConvenientOptionCheckBox.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConvenientOptionCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvenientOptionCheckBox.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConvenientOptionCheckBox.Location = new System.Drawing.Point(3, 42);
            this.ConvenientOptionCheckBox.Name = "ConvenientOptionCheckBox";
            this.ConvenientOptionCheckBox.Size = new System.Drawing.Size(102, 33);
            this.ConvenientOptionCheckBox.TabIndex = 3;
            this.ConvenientOptionCheckBox.Text = "편의 기능";
            this.ConvenientOptionCheckBox.UseVisualStyleBackColor = false;
            this.ConvenientOptionCheckBox.Click += new System.EventHandler(this.ConvenienceCheckBox_Click);
            // 
            // WindowAdvicePanel
            // 
            this.WindowAdvicePanel.Location = new System.Drawing.Point(151, 0);
            this.WindowAdvicePanel.Name = "WindowAdvicePanel";
            this.WindowAdvicePanel.Size = new System.Drawing.Size(439, 430);
            this.WindowAdvicePanel.TabIndex = 14;
            // 
            // AdviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 430);
            this.Controls.Add(this.WindowAdvicePanel);
            this.Controls.Add(this.Advice_FlowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도움말";
            this.Load += new System.EventHandler(this.AdviceForm_Load);
            this.Advice_FlowLayoutPanel.ResumeLayout(false);
            this.Advice_FlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Advice_FlowLayoutPanel;
        private System.Windows.Forms.CheckBox CryptographyCheckBox;
        private System.Windows.Forms.CheckBox ConvenientOptionCheckBox;
        private System.Windows.Forms.Panel WindowAdvicePanel;
    }
}