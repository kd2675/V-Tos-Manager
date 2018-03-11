using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Resources;
using System.Windows.Forms;
using System.Globalization;
using 암호화_복호화_프로그램.Form_UserControl.AdviceList;
using 암호화_복호화_프로그램.Form_UserControl.CryptographyList;
using 암호화_복호화_프로그램.Form_UserControl.ConvenienceFeaturesList;

namespace 암호화_복호화_프로그램.Language
{
    public static class SetupLanguage
    {
        public static ResourceManager Languages = new ResourceManager("암호화_복호화_프로그램.Language.Language", typeof(암호화_복호화_프로그램.Forms.MainForm).Assembly);

        private static CultureInfo korean = new CultureInfo("ko-KR");
        private static CultureInfo english = new CultureInfo("en-US");

        public static void FindLanguage(LanguageNumber number)
        {
            switch (number)
            {
                case LanguageNumber.English: if (Thread.CurrentThread.CurrentUICulture != english) Thread.CurrentThread.CurrentUICulture = english; break;
                case LanguageNumber.Korean: if (Thread.CurrentThread.CurrentUICulture != korean) Thread.CurrentThread.CurrentUICulture = korean; break;
                default: break;
            }
        }
    }
    public static class AESLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var aesControl = control as AESPanel;

            aesControl.lblFileTitle_Text = SetupLanguage.Languages.GetString("FileTitle");
            aesControl.lblTextTitle_Text = SetupLanguage.Languages.GetString("TextTitle");
            aesControl.lblPassword_Text = SetupLanguage.Languages.GetString("InputKey_16_24_32");
            aesControl.lblIV_Text = SetupLanguage.Languages.GetString("InputIV_16");
            aesControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            aesControl.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            aesControl.btnSelectFile_Text = SetupLanguage.Languages.GetString("SelectFile");
            aesControl.btnFileSave1_Text = SetupLanguage.Languages.GetString("FileSave1");
            aesControl.btnFileSave2_Text = SetupLanguage.Languages.GetString("FileSave2");
            aesControl.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            aesControl.btnDecrypt_Text = SetupLanguage.Languages.GetString("Decryption");
        }
    }

    public static class ARIALanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var ariaControl = control as ARIAPanel;

            ariaControl.lblPassword_Text = SetupLanguage.Languages.GetString("InputKey_16_24_32_x");
            ariaControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            ariaControl.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            ariaControl.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            ariaControl.btnDecrypt_Text = SetupLanguage.Languages.GetString("Decryption");
        }
    }

    public static class BlowFishLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var blowfishControl = control as BlowFishPanel;

            blowfishControl.lblPassword_Text = SetupLanguage.Languages.GetString("InputKey_1_56_x");
            blowfishControl.lblIV_Text = SetupLanguage.Languages.GetString("InputIV_8_x");
            blowfishControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            blowfishControl.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            blowfishControl.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            blowfishControl.btnDecrypt_Text = SetupLanguage.Languages.GetString("Decryption");
        }
    }

    public static class DESLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var desControl = control as DESPanel;

            desControl.lblFileTitle_Text = SetupLanguage.Languages.GetString("FileTitle");
            desControl.lblTextTitle_Text = SetupLanguage.Languages.GetString("TextTitle");
            desControl.lblPassword_Text = SetupLanguage.Languages.GetString("InputKey_8");
            desControl.lblIV_Text = SetupLanguage.Languages.GetString("InputIV_8");
            desControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            desControl.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            desControl.btnSelectFile_Text = SetupLanguage.Languages.GetString("SelectFile");
            desControl.btnFileSave1_Text = SetupLanguage.Languages.GetString("FileSave1");
            desControl.btnFileSave2_Text = SetupLanguage.Languages.GetString("FileSave2");
            desControl.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            desControl.btnDecrypt_Text = SetupLanguage.Languages.GetString("Decryption");
        }
    }

    public static class ECDSALanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var ecdsaControl = control as ECDSAPanel;

            ecdsaControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Signature");
            ecdsaControl.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            ecdsaControl.lblPublicKey_Text = SetupLanguage.Languages.GetString("PublicKey");
            ecdsaControl.btnSignature_Text = SetupLanguage.Languages.GetString("Signature");

            ecdsaControl.lblKey_Text = SetupLanguage.Languages.GetString("Key");
            ecdsaControl.lblBefore_Text = SetupLanguage.Languages.GetString("DataBeforeSigning");
            ecdsaControl.lblAfter_Text = SetupLanguage.Languages.GetString("SignedData");
            ecdsaControl.btnVerify_Text = SetupLanguage.Languages.GetString("DataVerification");
        }
    }

    public static class MD5Language
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var md5Control = control as MD5Panel;

            md5Control.lblFileTitle_Text = SetupLanguage.Languages.GetString("FileTitle");
            md5Control.lblTextTitle_Text= SetupLanguage.Languages.GetString("TextTitle");
            md5Control.lblHMACPassword_Text = SetupLanguage.Languages.GetString("InputKey");
            md5Control.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            md5Control.lblFileResult_Text = SetupLanguage.Languages.GetString("Result_File");
            md5Control.lblTextResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            md5Control.btnSelectFile_Text = SetupLanguage.Languages.GetString("SelectFile");
            md5Control.btnCheckResult_Text = SetupLanguage.Languages.GetString("CheckResult");
            md5Control.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            md5Control.gbHMACMode_Text = SetupLanguage.Languages.GetString("HMACMode");
            md5Control.cbHMACMode_Text = SetupLanguage.Languages.GetString("HMACModeSetup");
        }
    }

    public static class RC2Language
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var rc2Control = control as RC2Panel;

            rc2Control.lblFileTitle_Text = SetupLanguage.Languages.GetString("FileTitle");
            rc2Control.lblTextTitle_Text = SetupLanguage.Languages.GetString("TextTitle");
            rc2Control.lblPassword_Text = SetupLanguage.Languages.GetString("InputKey_8");
            rc2Control.lblIV_Text = SetupLanguage.Languages.GetString("InputIV_8");
            rc2Control.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            rc2Control.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            rc2Control.btnSelectFile_Text = SetupLanguage.Languages.GetString("SelectFile");
            rc2Control.btnFileSave1_Text = SetupLanguage.Languages.GetString("FileSave1");
            rc2Control.btnFileSave2_Text = SetupLanguage.Languages.GetString("FileSave2");
            rc2Control.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            rc2Control.btnDecrypt_Text = SetupLanguage.Languages.GetString("Decryption");
        }
    }

    public static class RIPEMD160Language
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var ripemd160Control = control as RIPEMD160Panel;

            ripemd160Control.lblFileTitle_Text = SetupLanguage.Languages.GetString("FileTitle");
            ripemd160Control.lblTextTitle_Text = SetupLanguage.Languages.GetString("TextTitle");
            ripemd160Control.lblHMACPassword_Text = SetupLanguage.Languages.GetString("InputKey");
            ripemd160Control.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            ripemd160Control.lblFileResult_Text = SetupLanguage.Languages.GetString("Result_File");
            ripemd160Control.lblTextResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            ripemd160Control.btnSelectFile_Text = SetupLanguage.Languages.GetString("SelectFile");
            ripemd160Control.btnCheckResult_Text = SetupLanguage.Languages.GetString("CheckResult");
            ripemd160Control.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            ripemd160Control.gbHMACModePassword_Text = SetupLanguage.Languages.GetString("HMACMode");
            ripemd160Control.cbHMACMode_Text = SetupLanguage.Languages.GetString("HMACModeSetup");
        }
    }

    public static class RSALanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var rsaControl = control as RSAPanel;

            rsaControl.lblPublicKey_Text = SetupLanguage.Languages.GetString("PublicKey");
            rsaControl.lblPrivateKey_Text = SetupLanguage.Languages.GetString("PrivateKey");
            rsaControl.btnMakeKey_Text = SetupLanguage.Languages.GetString("MakeKey");

            rsaControl.lblKey_Text = SetupLanguage.Languages.GetString("Key");
            rsaControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            rsaControl.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            rsaControl.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption_NeedPublicKey");
            rsaControl.btnDecrypt_Text = SetupLanguage.Languages.GetString("Decryption_NeedPrivateKey");
        }
    }

    public static class SEEDLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var seedControl = control as SEEDPanel;

            seedControl.lblPassword_Text = SetupLanguage.Languages.GetString("InputKey_16_x");
            seedControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            seedControl.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            seedControl.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            seedControl.btnDecrypt_Text = SetupLanguage.Languages.GetString("Decryption");
        }
    }

    public static class SHALanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var shaControl = control as SHAPanel;

            shaControl.lblFileTitle_Text = SetupLanguage.Languages.GetString("FileTitle");
            shaControl.lblTextTitle_Text = SetupLanguage.Languages.GetString("TextTitle");
            shaControl.lblHMACPassword_Text = SetupLanguage.Languages.GetString("InputKey");
            shaControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            shaControl.lblFileResult_Text = SetupLanguage.Languages.GetString("Result_File");
            shaControl.lblTextResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            shaControl.btnSelectFile_Text = SetupLanguage.Languages.GetString("SelectFile");
            shaControl.btnCheckResult_Text = SetupLanguage.Languages.GetString("CheckResult");
            shaControl.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            shaControl.gbHMACMode_Text = SetupLanguage.Languages.GetString("HMACMode");
            shaControl.cbHMACMode_Text = SetupLanguage.Languages.GetString("HMACModeSetup");

            shaControl.gbSHAMode_Text = SetupLanguage.Languages.GetString("SHAMode");
            shaControl.rdbtnSHA1_Text = SetupLanguage.Languages.GetString("SHA1Setup");
            shaControl.rdbtnSHA256_Text = SetupLanguage.Languages.GetString("SHA256Setup");
            shaControl.rdbtnSHA384_Text = SetupLanguage.Languages.GetString("SHA384Setup");
            shaControl.rdbtnSHA512_Text = SetupLanguage.Languages.GetString("SHA512Setup");
        }
    }

    public static class TripleDESLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var tripledesControl = control as TripleDESPanel;

            tripledesControl.lblFileTitle_Text = SetupLanguage.Languages.GetString("FileTitle");
            tripledesControl.lblTextTitle_Text = SetupLanguage.Languages.GetString("TextTitle");
            tripledesControl.lblPassword_Text = SetupLanguage.Languages.GetString("InputKey");
            tripledesControl.lblIV_Text = SetupLanguage.Languages.GetString("InputIV_8");
            tripledesControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            tripledesControl.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            tripledesControl.btnSelectFile_Text = SetupLanguage.Languages.GetString("SelectFile");
            tripledesControl.btnFileSave1_Text = SetupLanguage.Languages.GetString("FileSave1");
            tripledesControl.btnFileSave2_Text = SetupLanguage.Languages.GetString("FileSave2");
            tripledesControl.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            tripledesControl.btnDecrypt_Text = SetupLanguage.Languages.GetString("Decryption");
        }
    }

    public static class SteganographyLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var steganographyControl = control as SteganographyPanel;

            steganographyControl.lblFileTitle_Text = SetupLanguage.Languages.GetString("FileTitle");
            steganographyControl.lblPassword_Text = SetupLanguage.Languages.GetString("InputKey");
            steganographyControl.lblIV_Text = SetupLanguage.Languages.GetString("InputIV_8");
            steganographyControl.lblInput_Text = SetupLanguage.Languages.GetString("Input_Convert");
            steganographyControl.lblResult_Text = SetupLanguage.Languages.GetString("Result_Text");
            steganographyControl.btnSelectFile_Text = SetupLanguage.Languages.GetString("SelectFile");
            steganographyControl.btnEncrypt_Text = SetupLanguage.Languages.GetString("Encryption");
            steganographyControl.btnDecrypt_Text = SetupLanguage.Languages.GetString("Decryption");
        }
    }

    public static class RandomLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var randomControl = control as RandomPanel;

            randomControl.lblLength_Text = SetupLanguage.Languages.GetString("Random_TotalLength");
            randomControl.lblInclude_Text = SetupLanguage.Languages.GetString("Random_CharToInclude");
            randomControl.lblRandomCodeResult_Text = SetupLanguage.Languages.GetString("Random_RandomCodeResult");
            randomControl.btnGetRandomCode_Text = SetupLanguage.Languages.GetString("Random_GetRandomCode");
            randomControl.btnSetDefault_Text = SetupLanguage.Languages.GetString("Random_DefaultChar");

            randomControl.lblMinimum1_Text = SetupLanguage.Languages.GetString("Random_MinimumValue");
            randomControl.lblMaximum_Text = SetupLanguage.Languages.GetString("Random_MaximumValue");
            randomControl.lblRandomNumberResult_Text = SetupLanguage.Languages.GetString("Random_RandomNumberResult");
            randomControl.btnGetRandomNumber_Text = SetupLanguage.Languages.GetString("Random_GetRandomNumber");
        }
    }

    public static class TranslatorLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var translatorControl = control as TranslatorPanel;

            translatorControl.translateStatus_Text = new string[]{
                SetupLanguage.Languages.GetString("Translator_Status1"),
                SetupLanguage.Languages.GetString("Translator_Status2"),
                SetupLanguage.Languages.GetString("Translator_Status3"),
                SetupLanguage.Languages.GetString("Translator_Status4"),
            };
            translatorControl.fromLanguageLbl_Text = SetupLanguage.Languages.GetString("Translator_FromLanguage");
            translatorControl.toLanguageLbl_Text = SetupLanguage.Languages.GetString("Translator_ToLanguage");
            translatorControl.fromTextLbl_Text = SetupLanguage.Languages.GetString("Translator_FromText");
            translatorControl.toTextLbl_Text = SetupLanguage.Languages.GetString("Translator_ToText");
            translatorControl.translateBtn_Text = SetupLanguage.Languages.GetString("Translator_Translate");
            translatorControl.speakBtn_Text = SetupLanguage.Languages.GetString("Translator_Speak");
            translatorControl.changeBtn_Text = SetupLanguage.Languages.GetString("Translator_Reverse");
            translatorControl.usedLanguages1_Text = SetupLanguage.Languages.GetString("Translator_UsedLanguage1");
            translatorControl.usedLanguages2_Text = SetupLanguage.Languages.GetString("Translator_UsedLanguage2");
        }
    }

    public static class CryptographyModeLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var cryptographyControl = control as CryptographyMode;

            cryptographyControl.AESCheckBox_Text = SetupLanguage.Languages.GetString("ModeName_AES");
            cryptographyControl.ARIACheckBox_Text = SetupLanguage.Languages.GetString("ModeName_ARIA");
            cryptographyControl.BlowFishCheckBox_Text = SetupLanguage.Languages.GetString("ModeName_BlowFish");
            cryptographyControl.DESCheckBox_Text = SetupLanguage.Languages.GetString("ModeName_DES");
            cryptographyControl.ECDSACheckBox_Text = SetupLanguage.Languages.GetString("ModeName_ECDSA");
            cryptographyControl.MD5CheckBox_Text = SetupLanguage.Languages.GetString("ModeName_MD5");
            cryptographyControl.RC2CheckBox_Text = SetupLanguage.Languages.GetString("ModeName_RC2");
            cryptographyControl.RIPEMD160CheckBox_Text = SetupLanguage.Languages.GetString("ModeName_RIPEMD160");
            cryptographyControl.RSACheckBox_Text = SetupLanguage.Languages.GetString("ModeName_RSA");
            cryptographyControl.SEEDCheckBox_Text = SetupLanguage.Languages.GetString("ModeName_SEED");
            cryptographyControl.SHACheckBox_Text = SetupLanguage.Languages.GetString("ModeName_SHA");
            cryptographyControl.TripleDESCheckBox_Text = SetupLanguage.Languages.GetString("ModeName_TripleDES");
            cryptographyControl.SteganographyCheckBox_Text = SetupLanguage.Languages.GetString("ModeName_Steganography");
        }
    }

    public static class OtherOptionModeLanguage
    {
        public static void ChangeLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var convenienceControl = control as ConvenienceFeaturesMode;

            convenienceControl.RandomCheckBox_Text = SetupLanguage.Languages.GetString("ModeName_Random");
            convenienceControl.CDKeyCheckBox_Text = SetupLanguage.Languages.GetString("ModeName_CDKey");
            convenienceControl.TranslatorCheckBox_Text = SetupLanguage.Languages.GetString("ModeName_Translator");
        }
    }

    public static class MenuBarLanguage
    {
        public static void ChangeLanguage(MenuStrip control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            control.Items["보기_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_View");
            control.Items["도움말_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_Help");
            control.Items["언어_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_Language");

            var viewList = (control.Items["보기_Tsmi"] as ToolStripMenuItem);
            var viewLists1 = (viewList.DropDownItems["Cryptography_Tsmi"] as ToolStripMenuItem);
            var viewLists2 = (viewList.DropDownItems["OtherOption_Tsmi"] as ToolStripMenuItem);

            viewList.DropDownItems["Cryptography_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_EncryptionList");
            viewLists1.DropDownItems["DES_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_DESEncryption");
            viewLists1.DropDownItems["TripleDES_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_TripleDESEncryption");
            viewLists1.DropDownItems["AES_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_AESEncryption");
            viewLists1.DropDownItems["RC2_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_RC2Encryption");
            viewLists1.DropDownItems["SEED_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_SEEDEncryption");
            viewLists1.DropDownItems["ARIA_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_ARIAEncryption");
            viewLists1.DropDownItems["BlowFish_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_BlowFishEncryption");
            viewLists1.DropDownItems["MD5_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_MD5Encryption");
            viewLists1.DropDownItems["RIPEMD160_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_RIPEMD160Encryption");
            viewLists1.DropDownItems["SHA_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_SHAEncryption");
            viewLists1.DropDownItems["RSA_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_RSAEncryption");
            viewLists1.DropDownItems["ECDSA_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_ECDSAEncryption");
            viewLists1.DropDownItems["Steganography_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_SteganographyEncryption");

            viewList.DropDownItems["OtherOption_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_OtherOptionList");
            viewLists2.DropDownItems["RandomCode_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_RandomCodeMode");
            viewLists2.DropDownItems["CDKey_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_CDKeyMode");
            viewLists2.DropDownItems["Translator_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_TranslatorMode");

            var helpList = (control.Items["도움말_Tsmi"] as ToolStripMenuItem);

            helpList.DropDownItems["Advice_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_ViewHelp");
            helpList.DropDownItems["ProgramInfo_Tsmi"].Text = SetupLanguage.Languages.GetString("MenuBar_ProgramInfo");
        }
    }

    public static class AdviceLanguage
    {
        public static void ChangeLanguage(Form form, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var adviceForm = form as Forms.AdviceForm;
            

            adviceForm.Text = SetupLanguage.Languages.GetString("Advice_ProgramName");
            adviceForm.CryptographyCheckBox_Text = SetupLanguage.Languages.GetString("Advice_EncryptionType");
            adviceForm.ConvenientOptionCheckBox_Text = SetupLanguage.Languages.GetString("Advice_ConvenientOptionType");
        }

        public static void ChangeCryptographyAdviceLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var adviceControl = control as EncryptionAdvice;

            adviceControl.EncryptionExplanation1_Text = SetupLanguage.Languages.GetString("Advice_Symmetric_Info");
            adviceControl.EncryptionExplanation2_Text = SetupLanguage.Languages.GetString("Advice_OneWay_Info");
            adviceControl.EncryptionExplanation3_Text = SetupLanguage.Languages.GetString("Advice_Asymmetric_Info");
            adviceControl.EncryptionExplanation4_Text = SetupLanguage.Languages.GetString("Advice_Steganography_Info");

            adviceControl.DESTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_DESType");
            adviceControl.DESInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_DESInfo");
            adviceControl.TripleDESTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_TripleDESType");
            adviceControl.TripleDESInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_TripleDESInfo");
            adviceControl.AESTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_AESType");
            adviceControl.AESInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_AESInfo");
            adviceControl.RC2TypeLabel_Text = SetupLanguage.Languages.GetString("Advice_RC2Type");
            adviceControl.RC2InfoLabel_Text = SetupLanguage.Languages.GetString("Advice_RC2Info");
            adviceControl.SEEDTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_SEEDType");
            adviceControl.SEEDInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_SEEDInfo");
            adviceControl.ARIATypeLabel_Text = SetupLanguage.Languages.GetString("Advice_ARIAType");
            adviceControl.ARIAInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_ARIAInfo");
            adviceControl.BlowFishTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_BlowFishType");
            adviceControl.BlowFishInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_BlowFishInfo");
            adviceControl.MD5TypeLabel_Text = SetupLanguage.Languages.GetString("Advice_MD5Type");
            adviceControl.MD5InfoLabel_Text = SetupLanguage.Languages.GetString("Advice_MD5Info");
            adviceControl.RIPEMD160TypeLabel_Text = SetupLanguage.Languages.GetString("Advice_RIPEMD160Type");
            adviceControl.RIPEMD160InfoLabel_Text = SetupLanguage.Languages.GetString("Advice_RIPEMD160Info");
            adviceControl.SHA1TypeLabel_Text = SetupLanguage.Languages.GetString("Advice_SHA1Type");
            adviceControl.SHA1InfoLabel_Text = SetupLanguage.Languages.GetString("Advice_SHA1Info");
            adviceControl.SHA2TypeLabel_Text = SetupLanguage.Languages.GetString("Advice_SHA2Type");
            adviceControl.SHA2InfoLabel_Text = SetupLanguage.Languages.GetString("Advice_SHA2Info");
            adviceControl.HMACTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_HMACType");
            adviceControl.HMACInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_HMACInfo");
            adviceControl.RSATypeLabel_Text = SetupLanguage.Languages.GetString("Advice_RSAType");
            adviceControl.RSAInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_RSAInfo");
            adviceControl.ECDSATypeLabel_Text = SetupLanguage.Languages.GetString("Advice_ECDSAType");
            adviceControl.ECDSAInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_ECDSAInfo");
            adviceControl.SteganographyTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_SteganographyType");
            adviceControl.SteganographyInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_SteganographyInfo");
        }

        public static void ChangeConvenienceAdviceLanguage(UserControl control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var adviceControl = control as RandomCodeAdvice;

            adviceControl.RandomCodeTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_RandomCodeType");
            adviceControl.RandomCodeInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_RandomCodeInfo");
            adviceControl.RandomNumberTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_RandomNumberType");
            adviceControl.RandomNumberInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_RandomNumberInfo");
            adviceControl.GoogleTranslatorTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_TranslatorType");
            adviceControl.GoogleTranslatorInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_TranslatorInfo");
            adviceControl.CDKeyTypeLabel_Text = SetupLanguage.Languages.GetString("Advice_CDKeyType");
            adviceControl.CDKeyInfoLabel_Text = SetupLanguage.Languages.GetString("Advice_CDKeyInfo");
        }
    }

    public static class ProgramInfoLanguage
    {
        public static void ChangeLanguage(Form form, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            var programinfoForm = form as Forms.ProgramInfoForm;

            programinfoForm.Text = SetupLanguage.Languages.GetString("ProgramInfo_ProgramName");
            programinfoForm.lblProgramInfo_Text = SetupLanguage.Languages.GetString("ProgramInfo_ProgramInfo");
        }

        public static string GetProgramInfo(LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            return SetupLanguage.Languages.GetString("ProgramInfo_ProgramVersionInfo");
        }
    }

    public static class ProgramLanguage
    {
        public static void ChangeLanguage(Form control, LanguageNumber number)
        {
            SetupLanguage.FindLanguage(number);
            control.Text = SetupLanguage.Languages.GetString("Program_ProgramName");
        }
    }
}