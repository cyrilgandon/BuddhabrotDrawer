using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuddhabrotDrawer;

namespace BuddhabrotDrawerTests
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void LogDistributionTest()
        {
            int count = 2;
            int max = 5;
            var a = Extensions.LogDistribution(count, max).ToList();
            Assert.AreEqual(count, a.Count);
            Assert.AreEqual(1, a[0]);
            Assert.AreEqual(max, a[a.Count - 1], 0.001);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LogDistributionTest_CountLowerThan1()
        {
            int count = 1;
            var a = Extensions.LogDistribution(count, 5).ToList();
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LogDistributionTest_MaxLowerThan0()
        {
            int max = 0;
            var a = Extensions.LogDistribution(2, max).ToList();
        }
    }
}
