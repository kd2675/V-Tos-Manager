namespace 암호화_복호화_프로그램.Form_UserControl.AdviceList
{
    partial class RandomCodeAdvice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomCodeAdvice));
            this.RandomCodeAdvicePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RandomCodeExplanation = new System.Windows.Forms.FlowLayoutPanel();
            this.RandomCodeTypeLabel = new System.Windows.Forms.Label();
            this.RandomCodeInfoLabel = new System.Windows.Forms.Label();
            this.RandomNumberExplanation = new System.Windows.Forms.FlowLayoutPanel();
            this.RandomNumberTypeLabel = new System.Windows.Forms.Label();
            this.RandomNumberInfoLabel = new System.Windows.Forms.Label();
            this.CDKeyExplanation = new System.Windows.Forms.FlowLayoutPanel();
            this.CDKeyTypeLabel = new System.Windows.Forms.Label();
            this.CDKeyInfoLabel = new System.Windows.Forms.Label();
            this.GoogleTranslatorExplanation = new System.Windows.Forms.FlowLayoutPanel();
            this.GoogleTranslatorTypeLabel = new System.Windows.Forms.Label();
            this.GoogleTranslatorInfoLabel = new System.Windows.Forms.Label();
            this.RandomCodeAdvicePanel.SuspendLayout();
            this.RandomCodeExplanation.SuspendLayout();
            this.RandomNumberExplanation.SuspendLayout();
            this.CDKeyExplanation.SuspendLayout();
            this.GoogleTranslatorExplanation.SuspendLayout();
            this.SuspendLayout();
            // 
            // RandomCodeAdvicePanel
            // 
            this.RandomCodeAdvicePanel.AutoScroll = true;
            this.RandomCodeAdvicePanel.BackColor = System.Drawing.Color.Khaki;
            this.RandomCodeAdvicePanel.Controls.Add(this.RandomCodeExplanation);
            this.RandomCodeAdvicePanel.Controls.Add(this.RandomNumberExplanation);
            this.RandomCodeAdvicePanel.Controls.Add(this.CDKeyExplanation);
            this.RandomCodeAdvicePanel.Controls.Add(this.GoogleTranslatorExplanation);
            this.RandomCodeAdvicePanel.Location = new System.Drawing.Point(0, 0);
            this.RandomCodeAdvicePanel.Name = "RandomCodeAdvicePanel";
            this.RandomCodeAdvicePanel.Size = new System.Drawing.Size(439, 430);
            this.RandomCodeAdvicePanel.TabIndex = 13;
            this.RandomCodeAdvicePanel.MouseEnter += new System.EventHandler(this.RandomCodeAdvicePanel_MouseEnter);
            // 
            // RandomCodeExplanation
            // 
            this.RandomCodeExplanation.AutoSize = true;
            this.RandomCodeExplanation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RandomCodeExplanation.Controls.Add(this.RandomCodeTypeLabel);
            this.RandomCodeExplanation.Controls.Add(this.RandomCodeInfoLabel);
            this.RandomCodeExplanation.Location = new System.Drawing.Point(3, 3);
            this.RandomCodeExplanation.Name = "RandomCodeExplanation";
            this.RandomCodeExplanation.Size = new System.Drawing.Size(349, 117);
            this.RandomCodeExplanation.TabIndex = 8;
            // 
            // RandomCodeTypeLabel
            // 
            this.RandomCodeTypeLabel.AutoSize = true;
            this.RandomCodeTypeLabel.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RandomCodeTypeLabel.Location = new System.Drawing.Point(3, 5);
            this.RandomCodeTypeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.RandomCodeTypeLabel.Name = "RandomCodeTypeLabel";
            this.RandomCodeTypeLabel.Size = new System.Drawing.Size(92, 22);
            this.RandomCodeTypeLabel.TabIndex = 0;
            this.RandomCodeTypeLabel.Text = "랜덤 코드 :";
            // 
            // RandomCodeInfoLabel
            // 
            this.RandomCodeInfoLabel.AutoSize = true;
            this.RandomCodeInfoLabel.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RandomCodeInfoLabel.Location = new System.Drawing.Point(3, 32);
            this.RandomCodeInfoLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.RandomCodeInfoLabel.Name = "RandomCodeInfoLabel";
            this.RandomCodeInfoLabel.Size = new System.Drawing.Size(343, 85);
            this.RandomCodeInfoLabel.TabIndex = 2;
            this.RandomCodeInfoLabel.Text = "조건에 만족하는 랜덤 문자열을 생성하는 기능\r\n사용 방법 :\r\n1. 생성할 문자열의 총 길이를 입력한다.\r\n2. 문자열에 포함시킬 문자를 입력한다" +
    ".\r\n3. \"랜덤 코드 얻기\"로 조건에 맞는 랜덤 문자열을 생성한다.";
            // 
            // RandomNumberExplanation
            // 
            this.RandomNumberExplanation.AutoSize = true;
            this.RandomNumberExplanation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RandomNumberExplanation.Controls.Add(this.RandomNumberTypeLabel);
            this.RandomNumberExplanation.Controls.Add(this.RandomNumberInfoLabel);
            this.RandomNumberExplanation.Location = new System.Drawing.Point(3, 126);
            this.RandomNumberExplanation.Name = "RandomNumberExplanation";
            this.RandomNumberExplanation.Size = new System.Drawing.Size(369, 117);
            this.RandomNumberExplanation.TabIndex = 9;
            // 
            // RandomNumberTypeLabel
            // 
            this.RandomNumberTypeLabel.AutoSize = true;
            this.RandomNumberTypeLabel.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RandomNumberTypeLabel.Location = new System.Drawing.Point(3, 5);
            this.RandomNumberTypeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.RandomNumberTypeLabel.Name = "RandomNumberTypeLabel";
            this.RandomNumberTypeLabel.Size = new System.Drawing.Size(92, 22);
            this.RandomNumberTypeLabel.TabIndex = 0;
            this.RandomNumberTypeLabel.Text = "랜덤 난수 :";
            // 
            // RandomNumberInfoLabel
            // 
            this.RandomNumberInfoLabel.AutoSize = true;
            this.RandomNumberInfoLabel.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RandomNumberInfoLabel.Location = new System.Drawing.Point(3, 32);
            this.RandomNumberInfoLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.RandomNumberInfoLabel.Name = "RandomNumberInfoLabel";
            this.RandomNumberInfoLabel.Size = new System.Drawing.Size(363, 85);
            this.RandomNumberInfoLabel.TabIndex = 1;
            this.RandomNumberInfoLabel.Text = "최솟값 ~ 최대값 사이의 랜덤 숫자를 생성하는 기능\r\n사용 방법 :\r\n1. 최솟값을 입력한다.\r\n2. 최댓값을 입력한다.\r\n3. \"랜덤 난수 얻기" +
    "\"로 최솟값~최댓값 사이의 숫자를 생성한다.";
            // 
            // CDKeyExplanation
            // 
            this.CDKeyExplanation.AutoSize = true;
            this.CDKeyExplanation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CDKeyExplanation.Controls.Add(this.CDKeyTypeLabel);
            this.CDKeyExplanation.Controls.Add(this.CDKeyInfoLabel);
            this.CDKeyExplanation.Location = new System.Drawing.Point(3, 249);
            this.CDKeyExplanation.Name = "CDKeyExplanation";
            this.CDKeyExplanation.Size = new System.Drawing.Size(193, 27);
            this.CDKeyExplanation.TabIndex = 10;
            // 
            // CDKeyTypeLabel
            // 
            this.CDKeyTypeLabel.AutoSize = true;
            this.CDKeyTypeLabel.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CDKeyTypeLabel.Location = new System.Drawing.Point(3, 5);
            this.CDKeyTypeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.CDKeyTypeLabel.Name = "CDKeyTypeLabel";
            this.CDKeyTypeLabel.Size = new System.Drawing.Size(118, 22);
            this.CDKeyTypeLabel.TabIndex = 0;
            this.CDKeyTypeLabel.Text = "CD키 생성기 :";
            // 
            // CDKeyInfoLabel
            // 
            this.CDKeyInfoLabel.AutoSize = true;
            this.CDKeyInfoLabel.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CDKeyInfoLabel.Location = new System.Drawing.Point(127, 5);
            this.CDKeyInfoLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.CDKeyInfoLabel.Name = "CDKeyInfoLabel";
            this.CDKeyInfoLabel.Size = new System.Drawing.Size(63, 17);
            this.CDKeyInfoLabel.TabIndex = 1;
            this.CDKeyInfoLabel.Text = "추가 예정";
            // 
            // GoogleTranslatorExplanation
            // 
            this.GoogleTranslatorExplanation.AutoSize = true;
            this.GoogleTranslatorExplanation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GoogleTranslatorExplanation.Controls.Add(this.GoogleTranslatorTypeLabel);
            this.GoogleTranslatorExplanation.Controls.Add(this.GoogleTranslatorInfoLabel);
            this.GoogleTranslatorExplanation.Location = new System.Drawing.Point(3, 282);
            this.GoogleTranslatorExplanation.Name = "GoogleTranslatorExplanation";
            this.GoogleTranslatorExplanation.Size = new System.Drawing.Size(432, 185);
            this.GoogleTranslatorExplanation.TabIndex = 11;
            // 
            // GoogleTranslatorTypeLabel
            // 
            this.GoogleTranslatorTypeLabel.AutoSize = true;
            this.GoogleTranslatorTypeLabel.Font = new System.Drawing.Font("나눔바른고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GoogleTranslatorTypeLabel.Location = new System.Drawing.Point(3, 5);
            this.GoogleTranslatorTypeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.GoogleTranslatorTypeLabel.Name = "GoogleTranslatorTypeLabel";
            this.GoogleTranslatorTypeLabel.Size = new System.Drawing.Size(109, 22);
            this.GoogleTranslatorTypeLabel.TabIndex = 0;
            this.GoogleTranslatorTypeLabel.Text = "구글 번역기 :";
            // 
            // GoogleTranslatorInfoLabel
            // 
            this.GoogleTranslatorInfoLabel.AutoSize = true;
            this.GoogleTranslatorInfoLabel.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GoogleTranslatorInfoLabel.Location = new System.Drawing.Point(3, 32);
            this.GoogleTranslatorInfoLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.GoogleTranslatorInfoLabel.Name = "GoogleTranslatorInfoLabel";
            this.GoogleTranslatorInfoLabel.Size = new System.Drawing.Size(426, 153);
            this.GoogleTranslatorInfoLabel.TabIndex = 1;
            this.GoogleTranslatorInfoLabel.Text = resources.GetString("GoogleTranslatorInfoLabel.Text");
            // 
            // RandomCodeAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RandomCodeAdvicePanel);
            this.Name = "RandomCodeAdvice";
            this.Size = new System.Drawing.Size(439, 430);
            this.RandomCodeAdvicePanel.ResumeLayout(false);
            this.RandomCodeAdvicePanel.PerformLayout();
            this.RandomCodeExplanation.ResumeLayout(false);
            this.RandomCodeExplanation.PerformLayout();
            this.RandomNumberExplanation.ResumeLayout(false);
            this.RandomNumberExplanation.PerformLayout();
            this.CDKeyExplanation.ResumeLayout(false);
            this.CDKeyExplanation.PerformLayout();
            this.GoogleTranslatorExplanation.ResumeLayout(false);
            this.GoogleTranslatorExplanation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RandomCodeAdvicePanel;
        private System.Windows.Forms.FlowLayoutPanel RandomCodeExplanation;
        private System.Windows.Forms.Label RandomCodeTypeLabel;
        private System.Windows.Forms.FlowLayoutPanel RandomNumberExplanation;
        private System.Windows.Forms.Label RandomNumberTypeLabel;
        private System.Windows.Forms.Label RandomNumberInfoLabel;
        private System.Windows.Forms.Label RandomCodeInfoLabel;
        private System.Windows.Forms.FlowLayoutPanel CDKeyExplanation;
        private System.Windows.Forms.Label CDKeyTypeLabel;
        private System.Windows.Forms.Label CDKeyInfoLabel;
        private System.Windows.Forms.FlowLayoutPanel GoogleTranslatorExplanation;
        private System.Windows.Forms.Label GoogleTranslatorTypeLabel;
        private System.Windows.Forms.Label GoogleTranslatorInfoLabel;
    }
}
