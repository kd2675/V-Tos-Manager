using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using 암호화_복호화_프로그램.Form_UserControl.CryptographyList;
using 암호화_복호화_프로그램.Form_UserControl.ConvenienceFeaturesList;

namespace 암호화_복호화_프로그램.Forms
{
    public partial class MainForm : Form
    {
        [DllImport("DLL/*.dll")]
        public extern static uint EdsinitializeSDK();

        private Dictionary<string, UserControl> UserMenuList; //각각의 메뉴 패널을 모아둠
        private Dictionary<string, UserControl> PanelList; //각각의 암호화 패널을 모아둠
        private ToolStripMenuItem[] MenuItemList; //각각의 메뉴 상자를 모아둠
        private ToolStripMenuItem[] LanguageList; //각각의 언어 메뉴를 모아둠

        private AdviceForm adviceForm;
        private ProgramInfoForm programInfoForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddRefValue(); //객체 값 할당

            var versionFile = new FileInfo(@"version.txt");
            WriteFileOfVersion(versionFile);
            SetDefaultLanguage();
        }

        private void AddRefValue()
        {
            adviceForm = new AdviceForm();
            programInfoForm = new ProgramInfoForm();

            UserMenuList = new Dictionary<string, UserControl>();
            UserMenuList.Add("Cryptography", new CryptographyMode());
            UserMenuList.Add("Convenience", new ConvenienceFeaturesMode());
            UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);

            AddEventToCryptographyMenu(UserMenuList["Cryptography"]); //이 usercontrol에 이벤트 추가
            AddEventToConvenienceMenu(UserMenuList["Convenience"]); //이 usercontrol에 이벤트 추가

            PanelList = new Dictionary<string, UserControl>();
            PanelList.Add("DES", new DESPanel());
            PanelList.Add("TripleDES", new TripleDESPanel());
            PanelList.Add("AES", new AESPanel());
            PanelList.Add("RC2", new RC2Panel());
            PanelList.Add("SEED", new SEEDPanel());
            PanelList.Add("ARIA", new ARIAPanel());
            PanelList.Add("BlowFish", new BlowFishPanel());
            PanelList.Add("MD5", new MD5Panel());
            PanelList.Add("RIPEMD160", new RIPEMD160Panel());
            PanelList.Add("SHA", new SHAPanel());
            PanelList.Add("RSA", new RSAPanel());
            PanelList.Add("ECDSA", new ECDSAPanel());
            PanelList.Add("Steganography", new SteganographyPanel());
            PanelList.Add("Random", new RandomPanel());
            PanelList.Add("CDKey", new CDKeyPanel());
            PanelList.Add("Translator", new TranslatorPanel());

            MenuItemList = new ToolStripMenuItem[] { DES_Tsmi, TripleDES_Tsmi, AES_Tsmi, RC2_Tsmi, SEED_Tsmi, ARIA_Tsmi, BlowFish_Tsmi, MD5_Tsmi, RIPEMD160_Tsmi, SHA_Tsmi, RSA_Tsmi, ECDSA_Tsmi, Steganography_Tsmi, RandomCode_Tsmi, CDKey_Tsmi, Translator_Tsmi };
            LanguageList = new ToolStripMenuItem[] { Korean_Tsmi, English_Tsmi };
        }

        private void AddEventToCryptographyMenu(Control control)
        {
            CryptographyMode cryptographyMode = control as CryptographyMode;

            cryptographyMode.DESEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                DES_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["DES"]);
            };

            cryptographyMode.TripleDESEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                TripleDES_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["TripleDES"]);
            };

            cryptographyMode.AESEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                AES_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["AES"]);
            };

            cryptographyMode.RC2Event += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                RC2_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["RC2"]);
            };

            cryptographyMode.SEEDEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                SEED_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["SEED"]);
            };

            cryptographyMode.ARIAEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                ARIA_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["ARIA"]);
            };

            cryptographyMode.BlowFishEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                BlowFish_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["BlowFish"]);
            };

            cryptographyMode.MD5Event += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                MD5_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["MD5"]);
            };

            cryptographyMode.RIPEMD160Event += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                RIPEMD160_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["RIPEMD160"]);
            };

            cryptographyMode.SHAEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                SHA_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["SHA"]);
            };

            cryptographyMode.RSAEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                RSA_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["RSA"]);
            };

            cryptographyMode.ECDSAEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                ECDSA_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["ECDSA"]);
            };

            cryptographyMode.SteganographyEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                Steganography_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["Steganography"]);
            };
        }


        private void AddEventToConvenienceMenu(Control control)
        {
            ConvenienceFeaturesMode convenienceFeaturesMode = control as ConvenienceFeaturesMode;
            
            convenienceFeaturesMode.RandomEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                RandomCode_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["Random"]);
            };

            convenienceFeaturesMode.CDKeyEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                CDKey_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["CDKey"]);
            };

            convenienceFeaturesMode.TranslatorEvent += (sender, e) =>
            {
                MenuItemList_UnChekedAll();
                Translator_Tsmi.Checked = true;

                WindowPanel.Controls.Clear();
                WindowPanel.Controls.Add(PanelList["Translator"]);
            };
        }

        private void WriteFileOfVersion(FileInfo versionFile) //파일 버전 메모장에 쓰기
        {
            using (var sw = File.CreateText(versionFile.Name))
            {
                sw.WriteLine("=== [Korean] ===");
                sw.WriteLine(Language.ProgramInfoLanguage.GetProgramInfo(Language.LanguageNumber.Korean));
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine("=== [English] ===");
                sw.WriteLine(Language.ProgramInfoLanguage.GetProgramInfo(Language.LanguageNumber.English));
                /*
                string[] infoList1 = Language.ProgramInfoLanguage.GetProgramInfo(Language.LanguageNumber.Korean);
                foreach (string info in infoList1)
                {
                    sw.WriteLine(info);
                }
                sw.WriteLine();
                string[] infoList2 = Language.ProgramInfoLanguage.GetProgramInfo(Language.LanguageNumber.English);
                foreach (string info in infoList2)
                {
                    sw.WriteLine(info);
                }
                */
            }
        }

        private void SetDefaultLanguage() //기본 언어 설정하기 (LanguageMode.ini 파일에 저장되며, 파일이 없으면 생성하고, 있으면 파일에 저장된 Language 값을 불러온다.)
        {
            var languageFile = new FileInfo(@"LanguageMode.ini");

            if (languageFile.Exists)
            {
                Language.LanguageNumber readLanguage;

                using (var sr = File.OpenText(languageFile.Name))
                {
                    string tmp = sr.ReadLine();
                    readLanguage = (Language.LanguageNumber)Enum.Parse(typeof(Language.LanguageNumber), Regex.Split(tmp, " : ")[1]);
                }

                switch (readLanguage)
                {
                    case Language.LanguageNumber.English: English_Tsmi_Click(this, new EventArgs()); English_Tsmi.Checked = true; break;
                    case Language.LanguageNumber.Korean: Korean_Tsmi_Click(this, new EventArgs()); Korean_Tsmi.Checked = true; break;
                    default: English_Tsmi_Click(this, new EventArgs()); break;
                }

                WarningNotice.CurrentLanguage = readLanguage;
            }
            else
            {
                WarningNotice.CurrentLanguage = Language.LanguageNumber.Korean;

                using (var sw = File.CreateText(languageFile.Name))
                {
                    sw.WriteLine("Language : " + Language.LanguageNumber.Korean);
                    Korean_Tsmi.Checked = true;
                }

            }
        }

        private void SetDefaultLanguage(Language.LanguageNumber language) { //기본 언어 설정하기 (LanguageMode.ini 파일에 저장되며, 파일에 사용자 지정값을 넣어서 생성한다.)
            var languageFile = new FileInfo(@"LanguageMode.ini");
            WarningNotice.CurrentLanguage = language;

            using (var sw = File.CreateText(languageFile.Name))
            {
                sw.WriteLine("Language : " + language);
            }
        }

        private void MenuItemList_UnChekedAll() //모든 메뉴 체크박스 선택 해제
        {
            foreach (ToolStripMenuItem menuItem in MenuItemList)
                if (menuItem.Checked) menuItem.Checked = false;
        }

        private void LanguageList_UnCheckedAll() //모든 언어 체크박스 선택 해제
        {
            foreach (ToolStripMenuItem language in LanguageList)
                if (language.Checked) language.Checked = false;
        }

        private void DES_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).DESCheckBox_Click(sender, e);
        }

        private void TripleDES_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).TripleDESCheckBox_Click(sender, e);
        }

        private void AES_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).AESCheckBox_Click(sender, e);
        }

        private void RC2_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).RC2CheckBox_Click(sender, e);
        }

        private void SEED_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).SEEDCheckBox_Click(sender, e);
        }

        private void ARIA_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).ARIACheckBox_Click(sender, e);
        }

        private void BlowFish_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).BlowFishCheckBox_Click(sender, e);
        }

        private void MD5_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).MD5CheckBox_Click(sender, e);
        }

        private void RIPEMD160_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).RIPEMD160CheckBox_Click(sender, e);
        }

        private void SHA_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).SHACheckBox_Click(sender, e);
        }

        private void RSA_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).RSACheckBox_Click(sender, e);
        }

        private void ECDSA_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).ECDSACheckBox_Click(sender, e);
        }

        private void Steganography_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Cryptography"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Cryptography"]);
            }
            ((CryptographyMode)UserMenuList["Cryptography"]).SteganographyCheckBox_Click(sender, e);
        }

        private void RandomCode_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Convenience"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Convenience"]);
            }
            ((ConvenienceFeaturesMode)UserMenuList["Convenience"]).RandomCheckBox_Click(sender, e);
        }

        private void CDKey_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Convenience"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Convenience"]);
            }
            ((ConvenienceFeaturesMode)UserMenuList["Convenience"]).CDKeyCheckBox_Click(sender, e);
        }

        private void Translator_Tsmi_Click(object sender, EventArgs e)
        {
            if (UserMenuPanel.Controls["Convenience"] == null)
            {
                UserMenuPanel.Controls.Clear();
                UserMenuPanel.Controls.Add(UserMenuList["Convenience"]);
            }
            ((ConvenienceFeaturesMode)UserMenuList["Convenience"]).TranslatorCheckBox_Click(sender, e);
        }

        private void Advice_Tsmi_Click(object sender, EventArgs e)
        {
            adviceForm.ShowDialog();
        }

        private void ProgramInfo_Tsmi_Click(object sender, EventArgs e)
        {
            programInfoForm.ShowDialog();
        }

        private void English_Tsmi_Click(object sender, EventArgs e)
        {
            LanguageList_UnCheckedAll();
            English_Tsmi.Checked = true;
            
            Language.AESLanguage.ChangeLanguage(PanelList["AES"], Language.LanguageNumber.English);
            Language.ARIALanguage.ChangeLanguage(PanelList["ARIA"], Language.LanguageNumber.English);
            Language.BlowFishLanguage.ChangeLanguage(PanelList["BlowFish"], Language.LanguageNumber.English);
            Language.DESLanguage.ChangeLanguage(PanelList["DES"], Language.LanguageNumber.English);
            Language.ECDSALanguage.ChangeLanguage(PanelList["ECDSA"], Language.LanguageNumber.English);
            Language.MD5Language.ChangeLanguage(PanelList["MD5"], Language.LanguageNumber.English);
            Language.RC2Language.ChangeLanguage(PanelList["RC2"], Language.LanguageNumber.English);
            Language.RIPEMD160Language.ChangeLanguage(PanelList["RIPEMD160"], Language.LanguageNumber.English);
            Language.RSALanguage.ChangeLanguage(PanelList["RSA"], Language.LanguageNumber.English);
            Language.SEEDLanguage.ChangeLanguage(PanelList["SEED"], Language.LanguageNumber.English);
            Language.SHALanguage.ChangeLanguage(PanelList["SHA"], Language.LanguageNumber.English);
            Language.TripleDESLanguage.ChangeLanguage(PanelList["TripleDES"], Language.LanguageNumber.English);
            Language.SteganographyLanguage.ChangeLanguage(PanelList["Steganography"], Language.LanguageNumber.English);
            Language.RandomLanguage.ChangeLanguage(PanelList["Random"], Language.LanguageNumber.English);
            Language.TranslatorLanguage.ChangeLanguage(PanelList["Translator"], Language.LanguageNumber.English);
            Language.CryptographyModeLanguage.ChangeLanguage(UserMenuList["Cryptography"], Language.LanguageNumber.English);
            Language.OtherOptionModeLanguage.ChangeLanguage(UserMenuList["Convenience"], Language.LanguageNumber.English);
            Language.MenuBarLanguage.ChangeLanguage(MenuBar, Language.LanguageNumber.English);

            Language.AdviceLanguage.ChangeLanguage(adviceForm, Language.LanguageNumber.English);
            Language.AdviceLanguage.ChangeCryptographyAdviceLanguage(adviceForm.PanelList["EncryptionAdvice"], Language.LanguageNumber.English);
            Language.AdviceLanguage.ChangeConvenienceAdviceLanguage(adviceForm.PanelList["RandomCodeAdvice"], Language.LanguageNumber.English);
            Language.ProgramInfoLanguage.ChangeLanguage(programInfoForm, Language.LanguageNumber.English);
            Language.ProgramLanguage.ChangeLanguage(this, Language.LanguageNumber.English);

            WarningNotice.CurrentLanguage = Language.LanguageNumber.English;

            SetDefaultLanguage(Language.LanguageNumber.English);
        }

        private void Korean_Tsmi_Click(object sender, EventArgs e)
        {
            LanguageList_UnCheckedAll();
            Korean_Tsmi.Checked = true;
            
            Language.AESLanguage.ChangeLanguage(PanelList["AES"], Language.LanguageNumber.Korean);
            Language.ARIALanguage.ChangeLanguage(PanelList["ARIA"], Language.LanguageNumber.Korean);
            Language.BlowFishLanguage.ChangeLanguage(PanelList["BlowFish"], Language.LanguageNumber.Korean);
            Language.DESLanguage.ChangeLanguage(PanelList["DES"], Language.LanguageNumber.Korean);
            Language.ECDSALanguage.ChangeLanguage(PanelList["ECDSA"], Language.LanguageNumber.Korean);
            Language.MD5Language.ChangeLanguage(PanelList["MD5"], Language.LanguageNumber.Korean);
            Language.RC2Language.ChangeLanguage(PanelList["RC2"], Language.LanguageNumber.Korean);
            Language.RIPEMD160Language.ChangeLanguage(PanelList["RIPEMD160"], Language.LanguageNumber.Korean);
            Language.RSALanguage.ChangeLanguage(PanelList["RSA"], Language.LanguageNumber.Korean);
            Language.SEEDLanguage.ChangeLanguage(PanelList["SEED"], Language.LanguageNumber.Korean);
            Language.SHALanguage.ChangeLanguage(PanelList["SHA"], Language.LanguageNumber.Korean);
            Language.TripleDESLanguage.ChangeLanguage(PanelList["TripleDES"], Language.LanguageNumber.Korean);
            Language.SteganographyLanguage.ChangeLanguage(PanelList["Steganography"], Language.LanguageNumber.Korean);
            Language.RandomLanguage.ChangeLanguage(PanelList["Random"], Language.LanguageNumber.Korean);
            Language.TranslatorLanguage.ChangeLanguage(PanelList["Translator"], Language.LanguageNumber.Korean);
            Language.CryptographyModeLanguage.ChangeLanguage(UserMenuList["Cryptography"], Language.LanguageNumber.Korean);
            Language.OtherOptionModeLanguage.ChangeLanguage(UserMenuList["Convenience"], Language.LanguageNumber.Korean);
            Language.MenuBarLanguage.ChangeLanguage(MenuBar, Language.LanguageNumber.Korean);

            Language.AdviceLanguage.ChangeLanguage(adviceForm, Language.LanguageNumber.Korean);
            Language.AdviceLanguage.ChangeCryptographyAdviceLanguage(adviceForm.PanelList["EncryptionAdvice"], Language.LanguageNumber.Korean);
            Language.AdviceLanguage.ChangeConvenienceAdviceLanguage(adviceForm.PanelList["RandomCodeAdvice"], Language.LanguageNumber.Korean);
            Language.ProgramInfoLanguage.ChangeLanguage(programInfoForm, Language.LanguageNumber.Korean);
            Language.ProgramLanguage.ChangeLanguage(this, Language.LanguageNumber.Korean);

            WarningNotice.CurrentLanguage = Language.LanguageNumber.Korean;

            SetDefaultLanguage(Language.LanguageNumber.Korean);
        }
    }
}
