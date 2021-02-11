using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteboardEx_SD9
{
    public static class Primes
    {
        public static bool IsPrime(int input)
        {
            int maxRange = (int)Math.Sqrt(input);
            if (input == 1 || input == 0)
            {
                return false;
            }
            if (input == 2)
            {
                return true;
            }
            for(int n2 = 2;n2 < maxRange; n2++)
            {
                if(input % n2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int SumOfPrimes(int xNumber)
        {
            int sum = 0;

            for (int i = 2; i <= xNumber; i++)
            {
                sum += IsPrime(i) ? i : 0;
                /*
                if (IsPrime(i))
                {
                    sum += i;
                    continue;
                }
                */
            }

            return sum;
        }
    }
}
