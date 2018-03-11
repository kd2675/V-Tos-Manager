using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 암호화_복호화_프로그램.Form_UserControl.ConvenienceFeaturesList
{
    public partial class ConvenienceFeaturesMode : UserControl
    {
        private CheckBox[] BoxList; //각각의 모드에 대한 메뉴를 모아둠
        public event EventHandler RandomEvent;
        public event EventHandler CDKeyEvent;
        public event EventHandler TranslatorEvent;

        public ConvenienceFeaturesMode()
        {
            InitializeComponent();
            BoxList = new CheckBox[] { RandomCheckBox, CDKeyCheckBox, TranslatorCheckBox };
        }

        private void CheckBox_UnCheckedAll() //모든 체크박스 선택 해제
        {
            foreach (CheckBox box in BoxList)
                if (box.Checked) box.Checked = false;
        }

        internal void RandomCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            RandomCheckBox.Checked = true;
            if (RandomEvent != null) { this.RandomEvent(this, e); }
        }

        internal void CDKeyCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            CDKeyCheckBox.Checked = true;
            if (CDKeyEvent != null) { this.CDKeyEvent(this, e); }
        }

        internal void TranslatorCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            TranslatorCheckBox.Checked = true;
            if (TranslatorEvent != null) { this.TranslatorEvent(this, e); }
        }

        public string RandomCheckBox_Text { set => RandomCheckBox.Text = value; }
        public string CDKeyCheckBox_Text { set => CDKeyCheckBox.Text = value; }
        public string TranslatorCheckBox_Text { set => TranslatorCheckBox.Text = value; }
    }
}
