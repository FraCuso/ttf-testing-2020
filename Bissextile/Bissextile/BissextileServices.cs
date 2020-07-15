using System;
using System.Runtime.CompilerServices;

namespace Bissextile
{
    public class BissextileServices
    {
        public static bool IsBissextile(int year)
        {
            if (year == 0)
            {
                throw new InvalidOperationException();
            }
            if (year < 0)
            {
                return false;
            }
            if (year % 100 == 0)
            {
                return false;
            }
            if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
