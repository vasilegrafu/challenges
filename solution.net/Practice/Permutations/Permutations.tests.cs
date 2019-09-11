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
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5 }, 120);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5, 6 }, 720);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5, 6, 7}, 5040);
            TestCorrectness(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4, 5, 6, 7, 8}, 40320);
        }

        //--------------------------------------------------------------------------------------------------------------------------------
        // TestGeneration
        //--------------------------------------------------------------------------------------------------------------------------------

        private bool ComparePermutations(int[] p1, int[] p2)
        {
            if(p1.Length != p2.Length)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < p1.Length; i++)
            {
                if(p1[i] != p2[i])
                {
                    return false;
                }
            }

            return true;
        }

        private void TestGeneration(Func<int[], IList<int[]>> generatePermutationsFunc, int[] a, IList<int[]> expectedPermutations)
        {
            IList<int[]> permutations = generatePermutationsFunc(a);
            for (int i = 0; i < permutations.Count(); i++)
            {
                ComparePermutations(permutations[i], expectedPermutations[i]);
            }
        }

        [TestCase()]
        public void TestGeneration()
        {
            TestGeneration(Permutations1.GeneratePermutations, new int[] { 1 }, 
                                                               new List<int[]> { new int[] { 1 } });
            TestGeneration(Permutations1.GeneratePermutations, new int[] { 1, 2 }, 
                                                               new List<int[]> { new int[] { 1, 2 },
                                                                                 new int[] { 2, 1 } });
            TestGeneration(Permutations1.GeneratePermutations, new int[] { 1, 2, 3 }, 
                                                               new List<int[]> { new int[] { 1, 2, 3 },
                                                                                 new int[] { 1, 3, 2 },
                                                                                 new int[] { 2, 1, 3 },
                                                                                 new int[] { 2, 3, 1 },
                                                                                 new int[] { 3, 2, 1 },
                                                                                 new int[] { 3, 1, 2 } });
            // TestGeneration(Permutations1.GeneratePermutations, new int[] { 1, 2, 3, 4 }, 
            //                                                    new List<int[]> { new int[] { 1, 2, 3, 4 },
            //                                                                      new int[] { 1, 2, 4, 3 },
            //                                                                      new int[] { 1, 3, 2, 4 },
            //                                                                      new int[] { 1, 3, 4, 2 },
            //                                                                      new int[] { 1, 4, 3, 2 },
            //                                                                      new int[] { 1, 4, 2, 3 } });
        }


        [TestCase()]
        public void PrintGeneration()
        {
            IList<int[]> permutations = Permutations1.GeneratePermutations(new int[] { 1, 2, 3 });
            for (int i = 0; i < permutations.Count(); i++)
            {
                Console.WriteLine(permutations[i].ToString());
            }
        }
            
    }
}
