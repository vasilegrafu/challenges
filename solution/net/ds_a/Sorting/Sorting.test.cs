using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Sorting
{
    [TestFixture]
    public partial class SortingTest
    {
        //----------------------------------------------------------------  
        private static int[] GenerateData(int N)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int minValue = -(int)Math.Pow(10, 8);
            int maxValue = +(int)Math.Pow(10, 8);
            int[] a = Enumerable.Repeat(0, N).Select((i, p) => random.Next(minValue, maxValue)).ToArray();
            return a;
        }

        private static bool IsSorted(int[] a)
        {
            bool isSorted = true;
            for (int i = 0; i < a.Length-1; i++)
            {
                if (a[i] > a[i+1])
                {
                    isSorted = false;
                }
            }
            return isSorted;
        }

        //----------------------------------------------------------------
        public void Sort_TestCorrectness(Action<int[]> sortFunc, int N, int C)
        {
            int c = 0;
            while(c <= C)
            {
                c++;
                int[] a = GenerateData(N);
                sortFunc(a);
                bool isSorted = IsSorted(a);
                Assert.IsTrue(isSorted);
            }
        }

        [TestCase()]
        public void Sort_TestCorrectness()
        {
            Sort_TestCorrectness(InsertionSort.Sort, (int)Math.Pow(10, 4), (int)Math.Pow(10, 2));
        }

        //----------------------------------------------------------------
        public void Sort_TestPerformance(Action<int[]> sortFunc, int N)
        {
            int[] a = GenerateData(N);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            sortFunc(a);
            sw.Stop();
            TestContext.Progress.WriteLine(String.Format("ElapsedMilliseconds for {0} and N={1}: {2}", sortFunc.Method.DeclaringType.Name, N, sw.ElapsedMilliseconds));
        }

        [TestCase()]
        public void Sort_TestPerformance()
        {
            Sort_TestPerformance(InsertionSort.Sort, 1*(int)Math.Pow(10, 3));
            Sort_TestPerformance(InsertionSort.Sort, 2*(int)Math.Pow(10, 3));
            Sort_TestPerformance(InsertionSort.Sort, 4*(int)Math.Pow(10, 3));
            Sort_TestPerformance(InsertionSort.Sort, 8*(int)Math.Pow(10, 3));
            Sort_TestPerformance(InsertionSort.Sort, 16*(int)Math.Pow(10, 3));
            Sort_TestPerformance(InsertionSort.Sort, 32*(int)Math.Pow(10, 3));
        }
    }
}