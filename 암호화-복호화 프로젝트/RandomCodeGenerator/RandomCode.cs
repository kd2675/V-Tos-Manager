using System;
using System.Linq;

namespace RandomCodeGenerator
{
    public static class RandomCode
    {
        private static Random random = new Random();

        public static string GetRandomString(int length, string pattern) //랜덤 문자열 얻기
        {
            return new string(Enumerable.Repeat(pattern, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static int GetRandomNumber(int min, int max) //랜덤 숫자 얻기
        {
            try
            {
                return random.Next(min, max);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
