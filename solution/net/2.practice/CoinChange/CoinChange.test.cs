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
        private void TestCorrectness(Func<int, int[], long> getNumberOfWaysFunc, int n, int[] c, long numberOfWays)
        {
            long numberOfWays2 = getNumberOfWaysFunc(n, c);
            Assert.IsTrue(numberOfWays2 == numberOfWays);
        }

        [TestCase()]
        public void TestCorrectness()
        {
            // TestCorrectness(CoinChange1.GetNumberOfWays, 1, new int[] { 1 }, 1);
            // TestCorrectness(CoinChange1.GetNumberOfWays, 2, new int[] { 1, 2 }, 2);
            // TestCorrectness(CoinChange1.GetNumberOfWays, 3, new int[] { 1, 2, 3 }, 3);
            // TestCorrectness(CoinChange1.GetNumberOfWays, 4, new int[] { 1, 2, 3, 4 }, 5);

            TestCorrectness(CoinChange2.GetNumberOfWays, 1, new int[] { 1 }, 1);
            TestCorrectness(CoinChange2.GetNumberOfWays, 2, new int[] { 1, 2 }, 2);
            TestCorrectness(CoinChange2.GetNumberOfWays, 3, new int[] { 1, 2, 3 }, 3);
            TestCorrectness(CoinChange2.GetNumberOfWays, 4, new int[] { 1, 2, 3, 4 }, 5);
        }
    }
}
