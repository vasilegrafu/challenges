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
            TestCorrectness(CoinChange1.GetNumberOfWays, new int[] { 1 }, 1, 1);
            TestCorrectness(CoinChange1.GetNumberOfWays, new int[] { 1, 2 }, 2, 2);
            TestCorrectness(CoinChange1.GetNumberOfWays, new int[] { 1, 2, 3 }, 3, 3);
            TestCorrectness(CoinChange1.GetNumberOfWays, new int[] { 1, 2, 3, 4 }, 4, 5);

            TestCorrectness(CoinChange2.GetNumberOfWays, new int[] { 1 }, 1, 1);
            TestCorrectness(CoinChange2.GetNumberOfWays, new int[] { 1, 2 }, 2, 2);
            TestCorrectness(CoinChange2.GetNumberOfWays, new int[] { 1, 2, 3 }, 3, 3);
            TestCorrectness(CoinChange2.GetNumberOfWays, new int[] { 1, 2, 3, 4 }, 4, 5);
        }
    }
}
