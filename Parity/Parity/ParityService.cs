using System;

namespace Parity.Library
{
    public class ParityService
    {
        public static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
