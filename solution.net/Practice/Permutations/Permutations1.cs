
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Permutations
{
    public partial class Permutations1
    {
        private static void SwapValues(int[] a, int i, int j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }

        private static void GeneratePermutations(int[] a, int s, IList<int[]> permutations) 
        {
            if(s == (a.Length - 1))
            {
                int[] a2 = new int[a.Length];
                a.CopyTo(a2, 0);
                permutations.Add(a2);
                return;
            }

            for(int i = s; i <= (a.Length - 1); i++)
            {
                SwapValues(a, s, i);
                GeneratePermutations(a, s+1, permutations);
                SwapValues(a, s, i);
            }
        }

        public static IList<int[]> GeneratePermutations(int[] a) 
        {
            IList<int[]> permutations = new List<int[]>();
            GeneratePermutations(a, 0, permutations);
            return permutations;
        }
    }
}