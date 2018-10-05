using System;
using System.Collections;
using System.Collections.Generic;

namespace CoinChange
{
    public partial class CoinChange2
    {
        private static long GetNumberOfWays(int[] c, int m, int n) 
        { 
            // When m <= 0 means we have no coins so nothing to change. We return zero. 
            if(m <= 0) 
            {
                return 0;
            }

            // When n = 0 we have a full combination of coins which fit into initial n.
            if(n == 0)  
            {
                return 1;
            }

            // When n = 0 we do not have a full combination of coins which fit into initial n. 
            if(n < 0) 
            {
                return 0;
            }

            // The bellow relation is  alittle tricky to be understood
            // 
            return GetNumberOfWays(c, m-1, n) + GetNumberOfWays(c, m, n-c[m-1]);
        }
        
        public static long GetNumberOfWays(int[] c, int n) 
        {
            Array.Sort(c);

            long numberOfWays = GetNumberOfWays(c, c.Length, n);
            return numberOfWays;
        }
    }
}
