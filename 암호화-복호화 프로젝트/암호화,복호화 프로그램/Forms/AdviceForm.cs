using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 암호화_복호화_프로그램.Form_UserControl.AdviceList;

namespace 암호화_복호화_프로그램.Forms
{
    public partial class AdviceForm : Form
    {
        private CheckBox[] BoxList; //각각의 도움말 모드에 대한 메뉴를 모아둠
        public Dictionary<string, UserControl> PanelList; //각각의 도움말 패널을 모아둠

        public AdviceForm()
        {
            InitializeComponent();

            BoxList = new CheckBox[] { CryptographyCheckBox, ConvenientOptionCheckBox };

            PanelList = new Dictionary<string, UserControl>();
            PanelList.Add("EncryptionAdvice", new EncryptionAdvice());
            PanelList.Add("RandomCodeAdvice", new RandomCodeAdvice());

            WindowAdvicePanel.Controls.Add(PanelList["EncryptionAdvice"]);
        }

        private void AdviceForm_Load(object sender, EventArgs e)
        {
        }

        private void CheckBox_UnCheckedAll() //모든 체크박스 선택 해제
        {
            foreach (CheckBox box in BoxList)
                if (box.Checked) box.Checked = false;
        }

        private void CryptographyCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            CryptographyCheckBox.Checked = true;

            WindowAdvicePanel.Controls.Clear();
            WindowAdvicePanel.Controls.Add(PanelList["EncryptionAdvice"]);
            PanelList["EncryptionAdvice"].Focus();
        }

        private void ConvenienceCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            ConvenientOptionCheckBox.Checked = true;

            WindowAdvicePanel.Controls.Clear();
            WindowAdvicePanel.Controls.Add(PanelList["RandomCodeAdvice"]);
            PanelList["RandomCodeAdvice"].Focus();
        }

        public string CryptographyCheckBox_Text { set => CryptographyCheckBox.Text = value; }
        public string ConvenientOptionCheckBox_Text { set => ConvenientOptionCheckBox.Text = value; }
    }
}
