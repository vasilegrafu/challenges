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
                     .GroupBy((p) => p)
                     .ToDictionary((p) => p.Key, (e) => e.Count());

            int count = 0;
            if(D.ContainsKey(0))
            {
                count += 1;
            }
            for (int i = 1; i <= k/2; i++)
            {
                if(i == k - i)
                {
                    count++;
                    continue;
                }

                int count1 = 0;
                int count2 = 0;
                if(D.ContainsKey(i))
                {
                    count1 = D[i];
                }
                if(D.ContainsKey(k-i))
                {
                    count2 = D[k-i];
                }
                count += Math.Max(count1, count2);
            }
            return count;
        }

        [TestCase()]
        public void Main()
        {
            //int m = nonDivisibleSubset(7, new int[] { 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 });
            //int m = nonDivisibleSubset(5, new int[] { 770528134, 663501748, 384261537, 800309024, 103668401, 538539662, 385488901, 101262949, 557792122, 46058493 });
            int m = nonDivisibleSubset(1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Console.WriteLine(m);
        }
    }
}