using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace CoinChange
{
    [TestFixture]
    public partial class CoinChangeTest
    {
        private void TestCorrectness(Func<int[], int, long> getNumberOfWaysFunc, int[] c, int n, long numberOfWays)
        {
            long numberOfWays2 = getNumberOfWaysFunc(c, n);
            Assert.IsTrue(numberOfWays2 == numberOfWays);
        }

        [TestCase()]
        public void TestCorrectness()
        {
            // TestCorrectness(CoinChange1.GetNumberOfWays, new int[] { 1 }, 1, 1);
            // TestCorrectness(CoinChange1.GetNumberOfWays, new int[] { 1, 2 }, 2, 2);
            // TestCorrectness(CoinChange1.GetNumberOfWays, new int[] { 1, 2, 3 }, 3, 3);
            // TestCorrectness(CoinChange1.GetNumberOfWays, new int[] { 1, 2, 3, 4 }, 4, 5);

            // TestCorrectness(CoinChange2.GetNumberOfWays, new int[] { 1 }, 1, 1);
            // TestCorrectness(CoinChange2.GetNumberOfWays, new int[] { 1, 2 }, 2, 2);
            // TestCorrectness(CoinChange2.GetNumberOfWays, new int[] { 1, 2, 3 }, 3, 3);
            // TestCorrectness(CoinChange2.GetNumberOfWays, new int[] { 1, 2, 3, 4 }, 4, 5);

            // TestCorrectness(CoinChange3.GetNumberOfWays, new int[] { 1 }, 1, 1);
            // TestCorrectness(CoinChange3.GetNumberOfWays, new int[] { 1, 2 }, 2, 2);
            // TestCorrectness(CoinChange3.GetNumberOfWays, new int[] { 1, 2, 3 }, 3, 3);
            // TestCorrectness(CoinChange3.GetNumberOfWays, new int[] { 1, 2, 3, 4 }, 4, 5);

            // TestCorrectness(CoinChange3.GetNumberOfWays, new int[] { 2, 5, 3, 6 }, 10, 5);
            // TestCorrectness(CoinChange3.GetNumberOfWays, new int[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 }, 166, 96190959);

            TestCorrectness(CoinChange1.GetNumberOfWays, new int[] { 25, 10, 11, 29, 49, 31, 33, 39, 12, 36, 40, 22, 21, 16, 37, 8, 18, 4, 27, 17, 26, 32, 6, 38, 2, 30, 34 }, 75, 16694);
        }
    }
}
