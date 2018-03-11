using System;
using System.Windows.Forms;
using RandomCodeGenerator;

namespace 암호화_복호화_프로그램.Form_UserControl.ConvenienceFeaturesList
{
    public partial class RandomPanel : UserControl
    {
        public RandomPanel()
        {
            InitializeComponent();
        }

        private void RandomCodeButton1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbLength.Text) || String.IsNullOrWhiteSpace(tbInclude.Text))
            {
                WarningNotice.Null();
                return;
            }
            if (!int.TryParse(tbLength.Text, out _))
            {
                if (long.TryParse(tbLength.Text, out _))
                {
                    WarningNotice.IsLongType();
                    return;
                }
                WarningNotice.NotNumber();
                return;
            }
            tbRandomCodeResult.Text = RandomCode.GetRandomString(int.Parse(tbLength.Text), tbInclude.Text);
        }

        private void RandomCodeButton2_Click(object sender, EventArgs e)
        {
            tbInclude.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        }

        private void RandomNumberButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbMinimum.Text) || String.IsNullOrWhiteSpace(tbMaximum.Text))
            {
                WarningNotice.Null();
                return;
            }
            if (!(int.TryParse(tbMinimum.Text, out _) && int.TryParse(tbMaximum.Text, out _)))
            {
                if (long.TryParse(tbMinimum.Text, out _) || long.TryParse(tbMaximum.Text, out _))
                {
                    WarningNotice.IsLongType();
                    return;
                }
                WarningNotice.NotNumber();
                return;
            }
            if (int.Parse(tbMinimum.Text) > int.Parse(tbMaximum.Text))
            {
                WarningNotice.MinAndMaxNumber();
            }
            tbRandomNumberResult.Text = RandomCode.GetRandomNumber(int.Parse(tbMinimum.Text), int.Parse(tbMaximum.Text)).ToString();
        }

        public string lblLength_Text { set => lblLength.Text = value; }
        public string lblInclude_Text { set => lblInclude.Text = value; }
        public string lblRandomCodeResult_Text { set => lblRandomCodeResult.Text = value; }
        public string btnGetRandomCode_Text { set => btnGetRandomCode.Text = value; }
        public string btnSetDefault_Text { set => btnSetDefault.Text = value; }

        public string lblMinimum1_Text { set => lblMinimum.Text = value; }
        public string lblMaximum_Text { set => lblMaximum.Text = value; }
        public string lblRandomNumberResult_Text { set => lblRandomNumberResult.Text = value; }
        public string btnGetRandomNumber_Text { set => btnGetRandomNumber.Text = value; }
    }
}
