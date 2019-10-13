using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Permutations
{
    
    public class __Main
    {
        //--------------------------------------------------------------------------------------------------------------------------------
        // TestCorrectness
        //--------------------------------------------------------------------------------------------------------------------------------

        private static void TestCorrectness(Func<int[], IList<int[]>> generatePermutationsFunc, int[] a, long expectedPermutationsCount)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            IList<int[]> permutations = generatePermutationsFunc(a);
            long permutationsCount = permutations.Count();
            Debug.Assert(permutationsCount == expectedPermutationsCount);

            sw.Stop();
            Console.WriteLine($"ElapsedMilliseconds for {generatePermutationsFunc.Method.DeclaringType.Name}: {sw.ElapsedMilliseconds}");
        }

        private static void TestCorrectness()
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
        // OutputGeneratedPermutations
        //--------------------------------------------------------------------------------------------------------------------------------

        private static void OutputGeneratedPermutations()
        {
            IList<int[]> permutations = Permutations1.GeneratePermutations(new int[] { 1, 2, 3, 4 });
            for (int i = 0; i < permutations.Count(); i++)
            {
                Console.Write(string.Join(", ", permutations[i]));
            }
        }


        //--------------------------------------------------------------------------------------------------------------------------------
        // Main
        //--------------------------------------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            TestCorrectness();
            OutputGeneratedPermutations();
        }           
    }
}
