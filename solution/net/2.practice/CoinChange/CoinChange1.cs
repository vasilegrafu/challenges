using System;
using System.Collections;
using System.Collections.Generic;

namespace CoinChange
{
    public partial class CoinChange1
    {
        private static long GetNumberOfWays(int n, int[] c, List<int> way, HashSet<string> computedWays) 
        {        
            if(n > 0)
            {
                long numberOfWays = 0;
                for(int i = 0; i < c.Length; i++)
                {
                    if(n - c[i] < 0)
                    {
                        break;
                    }

                    int index_of_ci = way.BinarySearch(c[i]);
                    if(index_of_ci < 0)
                    {
                        index_of_ci = ~index_of_ci;
                    }
                    way.Insert(index_of_ci, c[i]);

                    //TestContext.Progress.WriteLine(String.Join(",", way));

                    if(!computedWays.Contains(String.Join(",", way)))
                    {
                        numberOfWays += GetNumberOfWays(n - c[i], c, way, computedWays);
                    }

                    way.RemoveAt(index_of_ci);
                }
                return numberOfWays;
            }
            else if(n == 0)
            {
                computedWays.Add(String.Join(",", way));
                return 1;
            }
            else
            {
                computedWays.Add(String.Join(",", way));
                return 0;
            }
            
        }
        
        public static long GetNumberOfWays(int n, int[] c) 
        {
            Array.Sort(c);

            List<int> way = new List<int>();
            HashSet<string> computedWays = new HashSet<string>();
            long numberOfWays = GetNumberOfWays(n, c, way, computedWays);
            return numberOfWays;
        }
    }
}