using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    public class __Main
    {
        //--------------------------------------------------------------------------------------------------------------------------------
        // Common
        //--------------------------------------------------------------------------------------------------------------------------------

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

        //--------------------------------------------------------------------------------------------------------------------------------
        // TestCorrectness
        //--------------------------------------------------------------------------------------------------------------------------------

        private static void TestCorrectness(Action<int[]> sortFunc, int N, int C)
        {
            int c = 0;
            while(c <= C)
            {
                c++;
                int[] a = GenerateData(N);
                sortFunc(a);
                bool isSorted = IsSorted(a);
                Debug.Assert(isSorted);
            }
        }

        private static void TestCorrectness()
        {
            int N = (int)Math.Pow(10, 3);
            int C = (int)Math.Pow(10, 2);
            TestCorrectness(BubbleSort.Sort, N, C);
            TestCorrectness(SelectionSort.Sort, N, C);
            TestCorrectness(InsertionSort.Sort, N, C);
            TestCorrectness(MergeSort1.Sort, N, C);
            TestCorrectness(MergeSort2.Sort, N, C);
        }


        //--------------------------------------------------------------------------------------------------------------------------------
        // TestPerformance
        //--------------------------------------------------------------------------------------------------------------------------------

        private static void TestPerformance(Action<int[]> sortFunc, int N)
        {
            int[] a = GenerateData(N);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            sortFunc(a);

            sw.Stop();
            Console.WriteLine(String.Format("ElapsedMilliseconds for {0} and N={1}: {2}", sortFunc.Method.DeclaringType.Name, N, sw.ElapsedMilliseconds));
        }

        private static void TestPerformance()
        {
            int C = 5;
            for(int i = 0; i <= C; i++) 
            {
                int N = (int)Math.Pow(2, i)*(int)Math.Pow(10, 3);
                TestPerformance(BubbleSort.Sort, N);
                TestPerformance(SelectionSort.Sort, N);
                TestPerformance(InsertionSort.Sort, N);  
                TestPerformance(MergeSort1.Sort, N);  
                TestPerformance(MergeSort2.Sort, N);
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------
        // Main
        //--------------------------------------------------------------------------------------------------------------------------------

        static void Main(string[] args)
        {
            TestCorrectness();
            TestPerformance();
        }   
    }
}