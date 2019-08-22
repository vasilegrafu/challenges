
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Permutations
{
    public partial class Permutations1
    {
        private static void GeneratePermutations(int[] a, int i, out IList<int[]> permutations) 
        {
            
        }

        public static IList<int[]> GeneratePermutations(int[] a) 
        {
            IList<int[]> permutations = new List<int[]>();
            GeneratePermutations(a, 0, out permutations);

        }
    }
}