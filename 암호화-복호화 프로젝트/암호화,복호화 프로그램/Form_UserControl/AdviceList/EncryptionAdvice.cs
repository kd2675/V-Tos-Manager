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
    public partial class EncryptionAdvice : UserControl
    {
        public EncryptionAdvice()
        {
            InitializeComponent();
        }

        private void EncryptionAdvicePanel_MouseEnter(object sender, EventArgs e)
        {
            EncryptionAdvicePanel.Focus();
        }

        public string EncryptionExplanation1_Text { set => EncryptionExplanation1.Text = value; }
        public string EncryptionExplanation2_Text { set => EncryptionExplanation2.Text = value; }
        public string EncryptionExplanation3_Text { set => EncryptionExplanation3.Text = value; }
        public string EncryptionExplanation4_Text { set => EncryptionExplanation4.Text = value; }

        public string DESTypeLabel_Text { set => DESTypeLabel.Text = value; }
        public string TripleDESTypeLabel_Text { set => TripleDESTypeLabel.Text = value; }
        public string AESTypeLabel_Text { set => AESTypeLabel.Text = value; }
        public string RC2TypeLabel_Text { set => RC2TypeLabel.Text = value; }
        public string SEEDTypeLabel_Text { set => SEEDTypeLabel.Text = value; }
        public string ARIATypeLabel_Text { set => ARIATypeLabel.Text = value; }
        public string BlowFishTypeLabel_Text { set => BlowFishTypeLabel.Text = value; }
        public string MD5TypeLabel_Text { set => MD5TypeLabel.Text = value; }
        public string RIPEMD160TypeLabel_Text { set => RIPEMD160TypeLabel.Text = value; }
        public string SHA1TypeLabel_Text { set => SHA1TypeLabel.Text = value; }
        public string SHA2TypeLabel_Text { set => SHA2TypeLabel.Text = value; }
        public string HMACTypeLabel_Text { set => HMACTypeLabel.Text = value; }
        public string RSATypeLabel_Text { set => RSATypeLabel.Text = value; }
        public string ECDSATypeLabel_Text { set => ECDSATypeLabel.Text = value; }
        public string SteganographyTypeLabel_Text { set => SteganographyTypeLabel.Text = value; }

        public string DESInfoLabel_Text { set => DESInfoLabel.Text = value; }
        public string TripleDESInfoLabel_Text { set => TripleDESInfoLabel.Text = value; }
        public string AESInfoLabel_Text { set => AESInfoLabel.Text = value; }
        public string RC2InfoLabel_Text { set => RC2InfoLabel.Text = value; }
        public string SEEDInfoLabel_Text { set => SEEDInfoLabel.Text = value; }
        public string ARIAInfoLabel_Text { set => ARIAInfoLabel.Text = value; }
        public string BlowFishInfoLabel_Text { set => BlowFishInfoLabel.Text = value; }
        public string MD5InfoLabel_Text { set => MD5InfoLabel.Text = value; }
        public string RIPEMD160InfoLabel_Text { set => RIPEMD160InfoLabel.Text = value; }
        public string SHA1InfoLabel_Text { set => SHA1InfoLabel.Text = value; }
        public string SHA2InfoLabel_Text { set => SHA2InfoLabel.Text = value; }
        public string HMACInfoLabel_Text { set => HMACInfoLabel.Text = value; }
        public string RSAInfoLabel_Text { set => RSAInfoLabel.Text = value; }
        public string ECDSAInfoLabel_Text { set => ECDSAInfoLabel.Text = value; }
        public string SteganographyInfoLabel_Text { set => SteganographyInfoLabel.Text = value; }
    }
}
