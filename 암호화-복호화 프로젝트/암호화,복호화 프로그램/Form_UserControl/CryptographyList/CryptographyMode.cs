using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 암호화_복호화_프로그램.Form_UserControl.CryptographyList
{
    public partial class CryptographyMode : UserControl
    {
        private CheckBox[] BoxList; //각각의 모드에 대한 메뉴를 모아둠
        public event EventHandler DESEvent;
        public event EventHandler TripleDESEvent;
        public event EventHandler AESEvent;
        public event EventHandler RC2Event;
        public event EventHandler SEEDEvent;
        public event EventHandler ARIAEvent;
        public event EventHandler BlowFishEvent;
        public event EventHandler MD5Event;
        public event EventHandler RIPEMD160Event;
        public event EventHandler SHAEvent;
        public event EventHandler RSAEvent;
        public event EventHandler ECDSAEvent;
        public event EventHandler SteganographyEvent;

        public CryptographyMode()
        {
            InitializeComponent();
            BoxList = new CheckBox[] { DESCheckBox, TripleDESCheckBox, AESCheckBox, RC2CheckBox, SEEDCheckBox, ARIACheckBox, BlowFishCheckBox, MD5CheckBox, RIPEMD160CheckBox, SHACheckBox, RSACheckBox, ECDSACheckBox, SteganographyCheckBox };
        }

        private void CheckBox_UnCheckedAll() //모든 체크박스 선택 해제
        {
            foreach (CheckBox box in BoxList)
                if (box.Checked) box.Checked = false;
        }

        internal void DESCheckBox_Click(object sender, EventArgs e) {
            CheckBox_UnCheckedAll();
            DESCheckBox.Checked = true;
            if (DESEvent != null) { this.DESEvent(this, e); }
        }

        internal void TripleDESCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            TripleDESCheckBox.Checked = true;
            if (TripleDESEvent != null) { this.TripleDESEvent(this, e); }
        }

        internal void AESCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            AESCheckBox.Checked = true;
            if (AESEvent != null) { this.AESEvent(this, e); }
        }

        internal void RC2CheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            RC2CheckBox.Checked = true;
            if (RC2Event != null) { this.RC2Event(this, e); }
        }

        internal void SEEDCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            SEEDCheckBox.Checked = true;
            if (SEEDEvent != null) { this.SEEDEvent(this, e); }
        }

        internal void ARIACheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            ARIACheckBox.Checked = true;
            if (ARIAEvent != null) { this.ARIAEvent(this, e); }
        }

        internal void BlowFishCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            BlowFishCheckBox.Checked = true;
            if (BlowFishEvent != null) { this.BlowFishEvent(this, e); }
        }

        internal void MD5CheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            MD5CheckBox.Checked = true;
            if (MD5Event != null) { this.MD5Event(this, e); }
        }

        internal void RIPEMD160CheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            RIPEMD160CheckBox.Checked = true;
            if (RIPEMD160Event != null) { this.RIPEMD160Event(this, e); }
        }

        internal void SHACheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            SHACheckBox.Checked = true;
            if (SHAEvent != null) { this.SHAEvent(this, e); }
        }

        internal void RSACheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            RSACheckBox.Checked = true;
            if (RSAEvent != null) { this.RSAEvent(this, e); }
        }

        internal void ECDSACheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            ECDSACheckBox.Checked = true;
            if (ECDSAEvent != null) { this.ECDSAEvent(this, e); }
        }


        internal void SteganographyCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox_UnCheckedAll();
            SteganographyCheckBox.Checked = true;
            if (SteganographyEvent != null) { this.SteganographyEvent(this, e); }
        }

        public string DESCheckBox_Text { set => DESCheckBox.Text = value; }
        public string TripleDESCheckBox_Text { set => TripleDESCheckBox.Text = value; }
        public string AESCheckBox_Text { set => AESCheckBox.Text = value; }
        public string RC2CheckBox_Text { set => RC2CheckBox.Text = value; }
        public string SEEDCheckBox_Text { set => SEEDCheckBox.Text = value; }
        public string ARIACheckBox_Text { set => ARIACheckBox.Text = value; }
        public string BlowFishCheckBox_Text { set => BlowFishCheckBox.Text = value; }
        public string MD5CheckBox_Text { set => MD5CheckBox.Text = value; }
        public string RIPEMD160CheckBox_Text { set => RIPEMD160CheckBox.Text = value; }
        public string SHACheckBox_Text { set => SHACheckBox.Text = value; }
        public string RSACheckBox_Text { set => RSACheckBox.Text = value; }
        public string ECDSACheckBox_Text { set => ECDSACheckBox.Text = value; }
        public string SteganographyCheckBox_Text { set => SteganographyCheckBox.Text = value; }
    }
}
