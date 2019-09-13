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
        //--------------------------------------------------------------------------------------------------------------------------------
        // TestCorrectness
        //--------------------------------------------------------------------------------------------------------------------------------

        private void TestCorrectness(Func<int[], IList<int[]>> generatePermutationsFunc, int[] a, long expectedPermutationsCount)
        {
            IList<int[]> permutations = generatePermutationsFunc(a);
            long permutationsCount = permutations.Count();
            Assert.IsTrue(permutationsCount == expectedPermutationsCount);
        }

        [TestCase()]
        public void TestCorrectness()
        {
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1 }, 1);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2 }, 2);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3 }, 6);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4 }, 24);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5 }, 121);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5, 6 }, 720);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5, 6, 7}, 5040);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5, 6, 7, 8}, 40320);
        }

        //--------------------------------------------------------------------------------------------------------------------------------
        // OutputGeneratedPermutations
        //--------------------------------------------------------------------------------------------------------------------------------

        [TestCase()]
        public void OutputGeneratedPermutations()
        {
            IList<int[]> permutations = Permutations1.GeneratePermutations(new int[] { 1, 2, 3, 4 });
            for (int i = 0; i < permutations.Count(); i++)
            {
                TestContext.Progress.Write(string.Join(", ", permutations[i]));
            }
        }
            
    }
}
