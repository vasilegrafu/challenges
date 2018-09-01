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
        public void Sort_SortArray(Action<int[]> sortFunc)
        {
            int[] a = new int[] { 1, 4, 7, 2, 3, 0, 9, 8, 5, 6 };
            int n = a.Length;
            int[] s = a.ToList().OrderBy((p) => p).ToArray();

            sortFunc(a);

            bool isSorted = true;
            for(int i = 0; i < n; i++)
            {
                if(a[i] != s[i])
                {
                    isSorted = false;
                }
            }

            Assert.IsTrue(isSorted);  
        }

        [TestCase()]
        public void Sort_SortArray()
        {
            Sort_SortArray(InsertionSort.Sort);
        }
    }

    

}