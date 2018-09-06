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
        public void Search_TestIsCorrect(Func<int[], int, int> searchFunc, int N, int R)
        {
            (int[] a, int[] values) = GenerateData(N, R);
            foreach (int value in values)
            {
                int index = searchFunc(a, value);
                Assert.IsTrue(a.Contains(value) ? index >= 0 : index == -1);
            }
        }

        [TestCase()]
        public void Search_SearchValues()
        {
            Search_TestIsCorrect(LinearSearch.Search, (int)Math.Pow(10, 4), (int)Math.Pow(10, 2));
            Search_TestIsCorrect(BinarySearch1.Search, (int)Math.Pow(10, 4), (int)Math.Pow(10, 2));
            Search_TestIsCorrect(BinarySearch2.Search, (int)Math.Pow(10, 4), (int)Math.Pow(10, 2));
        }

        //----------------------------------------------------------------
        public void Search_TestPerformance(Func<int[], int, int> searchFunc, int N, int R)
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
        public void Search_TestPerformance()
        {
            Search_TestPerformance(LinearSearch.Search, (int)Math.Pow(10, 4), (int)Math.Pow(10, 4));
            Search_TestPerformance(BinarySearch1.Search, (int)Math.Pow(10, 8), (int)Math.Pow(10, 5));
            Search_TestPerformance(BinarySearch2.Search, (int)Math.Pow(10, 8), (int)Math.Pow(10, 5));
        }
    }
}