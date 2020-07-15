using System;
using System.Collections.Generic;


namespace PrimeFactorsService
{
    public class PrimeFactors
    {
        public static List<int> Calculate(int x)
        {
            List<int> factors = new List<int>();
            if (x != 1)
            {
                factors.Add(x);
            }
            return factors;
        }
    }
}
