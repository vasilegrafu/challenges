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
            List<int> list = new List<int>();
            for(int i = 0; i < S.Length - 1; i++)
            {
                for(int j = (i+1); j < S.Length; j++)
                {
                    if((S[i] + S[j]) % k != 0)
                    {
                        list.Add(S[i]);
                        list.Add(S[j]);
                    }
                }
            }
            
            Console.WriteLine(String.Join(",", list.Distinct().ToArray()));
            
            return list.Distinct().Count();
        }

        [TestCase()]
        public void Main()
        {
            nonDivisibleSubset(7, new int[] { 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 });
        }
    }
}
