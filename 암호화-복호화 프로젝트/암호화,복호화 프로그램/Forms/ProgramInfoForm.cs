using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 암호화_복호화_프로그램.Forms
{
    public partial class ProgramInfoForm : Form
    {
        public ProgramInfoForm()
        {
            InitializeComponent();
        }

        private void ProgramInfoForm_Load(object sender, EventArgs e)
        {
            lblDecodingProgram.Font = Fonts.SetFonts(Properties.Resources.NanumGothic_ExtraBold, 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            lblProgramInfo.Font = Fonts.SetFonts(Properties.Resources.NanumGothic_Regular, 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string lblDecodingProgram_Text { set => lblDecodingProgram.Text = value; }
        public string lblProgramInfo_Text {
            set {
                try
                {
                    //위의 ProgramInfoForm_Load에서 글꼴을 변경하면 텍스트를 교체할 때 오류 발생
                    lblProgramInfo.Text = value;
                }
                catch(Exception)
                {
                    lblProgramInfo_Text = value;
                }
            }
        }
    }
}
