using System;
using System.Collections;
using System.Collections.Generic;

namespace CoinChange
{
    public partial class CoinChange3
    {
        private static long GetNumberOfWays(int[] c, int m, int n, Dictionary<string, long> computedNumberOfWays) 
        { 
            long numberOfWays = 0;
            string computedNumberOfWaysId = String.Join(",", new int[] { m, n });
            if(computedNumberOfWays.ContainsKey(computedNumberOfWaysId))
            {
                numberOfWays = computedNumberOfWays[computedNumberOfWaysId];
                return numberOfWays;
            }
            
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

            numberOfWays = GetNumberOfWays(c, m-1, n, computedNumberOfWays) + GetNumberOfWays(c, m, n-c[m-1], computedNumberOfWays);
            computedNumberOfWays.Add(computedNumberOfWaysId, numberOfWays);
            return numberOfWays;
        }
        
        public static long GetNumberOfWays(int[] c, int n) 
        {
            Array.Sort(c);

            Dictionary<string, long> computedNumberOfWays = new Dictionary<string, long>();
            long numberOfWays = GetNumberOfWays(c, c.Length, n, computedNumberOfWays);
            return numberOfWays;
        }
    }
}
