using System;
using System.Runtime.CompilerServices;
using System.Threading;

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
            if (year % 4 != 0 || year < 0)
            {
                return false;
            }
            if (year % 100 != 0 || year <= 1581 || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
