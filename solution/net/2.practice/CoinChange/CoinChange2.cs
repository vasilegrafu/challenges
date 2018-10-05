using System;
using System.Collections;
using System.Collections.Generic;

namespace CoinChange
{
    public partial class CoinChange2
    {
        private static long GetNumberOfWays(int n, int[] c, int m) 
        {        
            if(n == 0)
            {
                return 1;
            }
            if(n <= 0)
            {
                return 0;
            }

            if(m <= 0)
            {
                return 0;
            }

            return GetNumberOfWays(n, c, m-1) + GetNumberOfWays(n-c[m-1], c, m);
        }
        
        public static long GetNumberOfWays(int n, int[] c) 
        {
            Array.Sort(c);

            long numberOfWays = GetNumberOfWays(n, c, c.Length);
            return numberOfWays;
        }
    }
}
