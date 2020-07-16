using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace StringCalculatorService
{
    public class StringCalculator
    {
        public static int Add(string s)
        {
            string tmps = null;
            if (s.Length == 0)
            {
                return 0;
            }
            string[] separators = null;
            string separator = null;
            bool checker = true;
            if (!s.Contains(",") && !s.Contains("\n"))
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (!Char.IsDigit(s[i]))
                    {
                        checker = false;
                    }
                }
            }
            if (s.Contains("//"))
            {
                s = s.Replace(String.Format("//{0}\n", s[s.IndexOf('/') + 2]), "§");
                separator = "§";
            }
            if (String.IsNullOrEmpty(separator))
            {
                separators = new string[] { ",", "\n" };
            }
            else
            {
                separators = new string[] { ",", "\n", separator };
            }

            if (checker)
            {
                string[] sarray = null;
                sarray = s.Split(separators, StringSplitOptions.None);
                List<int> numbers = ConvertToInteger(sarray);
                return numbers.Sum();
            }
            return 0;

        }

        public static List<int> ConvertToInteger(string[] sarray)
        {
            List<int> numbers = new List<int>();
            foreach (string item in sarray)
            {
                numbers.Add(Int32.Parse(item));
            }
            return numbers;
        }
    }        
}