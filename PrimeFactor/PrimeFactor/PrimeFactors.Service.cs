using System;
using System.Collections.Generic;


namespace PrimeFactorsService
{
    public class PrimeFactors
    {
        public static List<int> Calculate(int x)
        {
            List<int> factors = new List<int>();
            if (x <= 0)
            {
                throw new InvalidOperationException();
            }
            int qq;
            int tmpx = x;
            if (tmpx % 2 != 0)
            {
                qq = (tmpx - 1) / 2;
            }
            else
            {
                qq = tmpx / 2;
            }
            int i = 2;
            
            while (i <= qq)
            {
                if (tmpx % i == 0)
                {
                    factors.Add(i);
                    tmpx = tmpx / i;
                    i = 2;
                }
                else
                {
                    i++;
                }
            }
            if (factors.Count == 0 && x!=1)
            {
                factors.Add(x);
            }
            
            return factors;
        }
    }
}
