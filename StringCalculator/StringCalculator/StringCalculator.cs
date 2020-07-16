using System;
using System.Runtime.InteropServices;

namespace StringCalculatorService
{
    public class StringCalculator
    {
        public static int Add(string s)
        {
            int output = 0;
            if (s.Length == 0)
            {
                return 0;
            }
            
            string[] sarray = s.Split(",");
            bool checker = true;

            if (sarray.Length==2)
            {
                output = Int32.Parse(sarray[0]) + Int32.Parse(sarray[1]);
            }
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
            return output;
        }
    }
}
