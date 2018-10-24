using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Linq;
using System.IO;
using NUnit.Framework;

namespace Practice
{
    [TestFixture]
    public partial class Template1
    {
        int nonDivisibleSubset(int k, int[] S) {
            var D = S.Select((p) => p % k)
                     .OrderBy((p) => p)
                     .GroupBy((p) => p)
                     .ToDictionary((p) => p.Key, (e) => e.Count());

            List<int> keys = D.Keys.ToList();
            foreach(int s in keys)
            {
                if(D.ContainsKey(k-s))
                {
                    D[s]--;
                    D[k-s]--;
                }
            }

            List<HashSet<int>> hashSetList = new List<HashSet<int>>();

            for(int i = 0; i < S.Length - 1; i++)
            {
                HashSet<int> hashSet = new HashSet<int>();
                hashSet.Add(S[i]);

                for(int j = (i+1); j < S.Length; j++)
                {
                    if(hashSet.All((p) => (p + S[j]) % k != 0))
                    {
                        hashSet.Add(S[j]);
                    }
                }

                hashSetList.Add(hashSet);
            }
                       
            return hashSetList.Select((p) => p.Count()).Max();
        }

        [TestCase()]
        public void Main()
        {
            int m = nonDivisibleSubset(7, new int[] { 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 });
            //int m = nonDivisibleSubset(5, new int[] { 770528134, 663501748, 384261537, 800309024, 103668401, 538539662, 385488901, 101262949, 557792122, 46058493 });

            Console.WriteLine(m);
        }
    }
}