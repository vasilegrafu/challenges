using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace Searching
{
    [TestFixture]
    public partial class BinarySearchTest
    {
        public void Search_SearchValue(Func<int[], int, int> searchFunc)
        {
            int[] a = Enumerable.Range(0, (int)Math.Pow(10, 1)).Select((x) => 10*x).ToArray();
            int minValue = a.Min();
            int maxValue = a.Max();
            
            int value = 75;
            int index = searchFunc(a, value);
            if(value % 10 == 0)
            {
                Assert.IsTrue(index == value/10);
            }
            else
            {
                Assert.IsTrue(index == -1);
            }   
        }

        [TestCase()]
        public void Search_SearchValue()
        {
            Search_SearchValue(BinarySearch1.Search);
            Search_SearchValue(BinarySearch2.Search);
        }

        public void Search_SearchValues(Func<int[], int, int> searchFunc)
        {
            int[] a = Enumerable.Range(0, (int)Math.Pow(10, 4)).Select((x) => 10*x).ToArray();
            int minValue = a.Min();
            int maxValue = a.Max();
            
            Random random = new Random(DateTime.Now.Millisecond);
            int minRandomValue = -10000 + minValue;
            int maxRandomValue = maxValue + 10000;
            
            int N = (int)Math.Pow(10, 4);
            int n = 0;
            while(n <= N) 
            {
                n++;
                int value = random.Next(minRandomValue, maxRandomValue);
                int index = searchFunc(a, value);
                if(minValue <= value && value <= maxValue && value % 10 == 0)
                {
                    Assert.IsTrue(index == value/10);
                }
                else
                {
                    Assert.IsTrue(index == -1);
                }
                
            }
        }

        [TestCase()]
        public void Search_SearchValues()
        {
            Search_SearchValues(BinarySearch1.Search);
            Search_SearchValues(BinarySearch2.Search);
        }

        public void Search_ExecutionDuration(Func<int[], int, int> searchFunc)
        {
            int[] a = Enumerable.Range(0, (int)Math.Pow(10, 8)).Select((x) => 10*x).ToArray();
            int minValue = a.Min();
            int maxValue = a.Max();
            
            Random random = new Random(DateTime.Now.Millisecond);
            int minRandomValue = -10000 + minValue;
            int maxRandomValue = maxValue + 10000;

            int N = (int)Math.Pow(10, 5);
            int n = 0;

            List<int> values = new List<int>();
            n = 0;
            while(n <= N) 
            {
                n++;
                int value = random.Next(minRandomValue, maxRandomValue);
                values.Add(value);
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach(int value in values)
            {
                searchFunc(a, value);
            }

            sw.Stop();
            TestContext.Progress.WriteLine("ElapsedMilliseconds: " + sw.ElapsedMilliseconds);
        }

        [TestCase()]
        public void Search_ExecutionDuration()
        {
            Search_ExecutionDuration(BinarySearch1.Search);
            Search_ExecutionDuration(BinarySearch2.Search);
        }
    }

    

}