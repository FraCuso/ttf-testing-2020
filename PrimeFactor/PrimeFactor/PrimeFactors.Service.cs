using System;
using System.Collections.Generic;


namespace PrimeFactorsService
{
    public class PrimeFactors
    {
        public static List<int> Calculate(int x)
        {
            List<int> factors = new List<int>();
            if (x%2 == 0)
            {
                factors.Add(2);
            }
            if (x%3 == 0)
            {
                factors.Add(3);
            }
            return factors;
        }
    }
}
