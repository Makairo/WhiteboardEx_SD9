using System;
using System.Collections.Generic;
using System.Text;

namespace WhiteboardEx_SD9
{
    public static class PrimeNumber
    {
        public static bool IsPrime(int input)
        {
            if (input == 1 || input == 0)
            {
                return false;
            }
            if (input == 2)
            {
                return true;
            }
            for(int n2 = 2;n2 < input-1; n2++)
            {
                if(input % n2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
