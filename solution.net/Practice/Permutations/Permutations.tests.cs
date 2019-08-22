using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Permutations
{
    [TestFixture]
    public partial class PermutationsTest
    {
        private void TestCorrectness(Func<int[], IList<int[]>> generatePermutations, int[] a, long permutationsCount)
        {
            IList<int[]> permutations = generatePermutations(a);
            long permutationsCount2 = permutations.Count();
            Assert.IsTrue(permutationsCount2 == permutationsCount);
        }

        [TestCase()]
        public void TestCorrectness()
        {
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1 }, 1);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2 }, 2);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3 }, 6);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4 }, 24);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5 }, 120);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5, 6 }, 720);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5, 6, 7}, 5040);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5, 6, 7, 8}, 40320);
        }
    }
}
