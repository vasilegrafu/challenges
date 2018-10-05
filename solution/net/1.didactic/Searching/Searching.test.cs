using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Searching
{
    [TestFixture]
    public partial class SearchingTest
    {
        //----------------------------------------------------------------
        private static (int[], int[]) GenerateData(int N, int R)
        {
            int[] a = Enumerable.Range(0, N).Select((x) => 10 * x).ToArray();
            Random random = new Random(DateTime.Now.Millisecond);
            int minValue = -(int)(1.25 * a.Min());
            int maxValue = +(int)(1.25 * a.Max());
            int[] values = Enumerable.Repeat(0, R).Select((p) => random.Next(minValue, maxValue)).ToArray();
            return (a, values);
        }

        //----------------------------------------------------------------
        private void TestCorrectness(Func<int[], int, int> searchFunc, int N, int R)
        {
            (int[] a, int[] values) = GenerateData(N, R);
            foreach (int value in values)
            {
                int index = searchFunc(a, value);
                Assert.IsTrue(a.Contains(value) ? index >= 0 : index == -1);
            }
        }

        [TestCase()]
        public void TestCorrectness()
        {
            int N = (int)Math.Pow(10, 4);
            int R = (int)Math.Pow(10, 2);
            TestCorrectness(LinearSearch.Search, N, R);

            N = (int)Math.Pow(10, 4);
            R = (int)Math.Pow(10, 2);
            TestCorrectness(BinarySearch1.Search, N, R);
            TestCorrectness(BinarySearch2.Search, N, R);
        }

        //----------------------------------------------------------------
        private void TestPerformance(Func<int[], int, int> searchFunc, int N, int R)
        {
            (int[] a, int[] values) = GenerateData(N, R);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            foreach(int value in values)
            {
                searchFunc(a, value);
            }
            sw.Stop();
            TestContext.Progress.WriteLine(String.Format("ElapsedMilliseconds for {0}: {1}", searchFunc.Method.DeclaringType.Name, sw.ElapsedMilliseconds));
        }

        [TestCase()]
        public void TestPerformance()
        {
            int N = (int)Math.Pow(10, 4);
            int R = (int)Math.Pow(10, 4);
            TestPerformance(LinearSearch.Search, N, R);

            N = (int)Math.Pow(10, 4);
            R = (int)Math.Pow(10, 4);
            TestPerformance(BinarySearch1.Search, N, R);
            TestPerformance(BinarySearch2.Search, N, R);
        }
    }
}