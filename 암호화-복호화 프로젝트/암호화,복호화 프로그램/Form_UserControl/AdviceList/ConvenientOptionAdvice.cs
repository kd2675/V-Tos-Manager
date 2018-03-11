using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 암호화_복호화_프로그램.Form_UserControl.AdviceList
{
    public partial class RandomCodeAdvice : UserControl
    {
        public RandomCodeAdvice()
        {
            InitializeComponent();
        }

        private void RandomCodeAdvicePanel_MouseEnter(object sender, EventArgs e)
        {
            RandomCodeAdvicePanel.Focus();
        }

        public string RandomCodeTypeLabel_Text { set => RandomCodeTypeLabel.Text = value; }
        public string RandomNumberTypeLabel_Text { set => RandomNumberTypeLabel.Text = value; }
        public string CDKeyTypeLabel_Text { set => CDKeyTypeLabel.Text = value; }
        public string GoogleTranslatorTypeLabel_Text { set => GoogleTranslatorTypeLabel.Text = value; }

        public string RandomCodeInfoLabel_Text { set => RandomCodeInfoLabel.Text = value; }
        public string RandomNumberInfoLabel_Text { set => RandomNumberInfoLabel.Text = value; }
        public string CDKeyInfoLabel_Text { set => CDKeyInfoLabel.Text = value; }
        public string GoogleTranslatorInfoLabel_Text { set => GoogleTranslatorInfoLabel.Text = value; }
    }
}
