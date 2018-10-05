using System;
using System.Collections;
using System.Collections.Generic;

namespace CoinChange
{
    public partial class CoinChange3
    {
        private static long GetNumberOfWays(int[] c, int m, int n, Dictionary<string, long> computedWays) 
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

            long numberOfWays1 = 0;
            string computedWayId1 = String.Join(",", new int[] { m-1, n });
            if(!computedWays.ContainsKey(computedWayId1))
            {
                numberOfWays1 = GetNumberOfWays(c, m-1, n, computedWays);
                computedWays.Add(computedWayId1, numberOfWays1);
            }
            else
            {
                numberOfWays1 = computedWays[computedWayId1];
            }

            long numberOfWays2 = 0;
            string computedWayId2 = String.Join(",", new int[] { n, n-c[m-1] });
            if(!computedWays.ContainsKey(computedWayId2))
            {
                numberOfWays2 = GetNumberOfWays(c, m, n-c[m-1], computedWays);
                computedWays.Add(computedWayId2, numberOfWays2);
            }
            else
            {
                numberOfWays2 = computedWays[computedWayId2];
            }

            return numberOfWays1 + numberOfWays2;
        }
        
        public static long GetNumberOfWays(int[] c, int n) 
        {
            Array.Sort(c);

            Dictionary<string, long> computedWays = new Dictionary<string, long>();
            long numberOfWays = GetNumberOfWays(c, c.Length, n, computedWays);
            return numberOfWays;
        }
    }
}
