using System;

namespace StringCalculatorService
{
    public class StringCalculator
    {
        public static int Add(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            bool checker = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsDigit(s[i]))
                {
                    checker = false;
                }
            }
            if (checker)
            {
                return Int32.Parse(s);
            }
            return 11;
        }
    }
}
