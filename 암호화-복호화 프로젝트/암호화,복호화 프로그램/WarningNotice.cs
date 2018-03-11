using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 암호화_복호화_프로그램
{
    public static class WarningNotice
    {
        private static Language.LanguageNumber currentLanguage = Language.LanguageNumber.Korean;
        public static Language.LanguageNumber CurrentLanguage { set => currentLanguage = value; }

        public static void KeyLength(int length) //해당 키의 길이를 알림
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show($"The key length required for the operation must be {length} characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case Language.LanguageNumber.Korean: MessageBox.Show($"작업에 필요한 키의 길이는 {length}글자여야합니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        public static void KeyLength(params int[] length) //해당 키의 길이를 알림 (여러 개일 경우)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in length)
            {
                sb.Append(i);
                if (i != length[length.Length - 1])
                {
                    sb.Append(", ");
                }
            }
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show($"The key length required for the operation must be {sb} characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case Language.LanguageNumber.Korean: MessageBox.Show($"작업에 필요한 키의 길이는 {sb}글자여야합니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        public static void KeyLength(int minLength, int maxLength) //해당 키의 길이를 알림 (최소~최대까지)
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show($"The key length required for the operation should be {minLength} to {maxLength} characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case Language.LanguageNumber.Korean: MessageBox.Show($"작업에 필요한 키의 길이는 {minLength}~{maxLength}글자여야합니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        public static void IVLength(int length) //해당 IV의 길이를 알림
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show($"The IV length required for the operation must be {length} characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case Language.LanguageNumber.Korean: MessageBox.Show($"작업에 필요한 IV의 길이는 {length}글자여야합니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        public static void Null() //널값이거나 공백일 경우 경고를 알림
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("You can not enter spaces.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("공백은 입력할 수 없습니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        public static void NotNumber() //정수가 아닌 문자열을 입력했을 경우 경고를 알림
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("You can only enter integers in the total length field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("총 길이 칸에는 정수만 입력할 수 있습니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        public static void IsLongType() //Int 값이 나타낼 수 있는 최대 범위를 초과(Long 타입)했을경우 경고를 알림
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show($"Values exceeding {int.MaxValue} can not be entered.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case Language.LanguageNumber.Korean: MessageBox.Show($"{int.MaxValue}을 초과한 값은 입력할 수 없습니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        public static void MinAndMaxNumber() //최소 숫자가 최대 숫자보다 클 경우 경고를 알림
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("The minimum number can not be greater than the maximum number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("최소 숫자가 최대 숫자보다 클 수 없습니다.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        public static void WrongKey()
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("Invalid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("잘못된 값입니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }

        public static void InputString()
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("Please enter the file", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("파일 경로를 입력해주세요.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); break;
            }
        }

        public static void NotFound()
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("파일을 찾을 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }

        public static void Save()
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("File saved", "Notice", MessageBoxButtons.OK, MessageBoxIcon.None); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("파일이 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.None); break;
            }
        }

        public static void Completed()
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("The Operation Completed Successfully.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.None); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("작업이 성공적으로 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.None); break;
            }
        }

        public static void NoImage()
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("Image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("이미지를 찾을 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }

        public static void CantConvertImage()
        {
            switch (currentLanguage)
            {
                case Language.LanguageNumber.English: MessageBox.Show("You can not encrypt a string by its size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case Language.LanguageNumber.Korean: MessageBox.Show("해당 이미지의 크기로는 문자열을 암호화할 수 없습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
            }
        }
    }
}
