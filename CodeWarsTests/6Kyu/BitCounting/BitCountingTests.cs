using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars._6Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class BitCountingTests
    {
        [TestMethod()]
        public void CountBitsTest()
        {
            BitCounting bitCounting = new BitCounting();
            Assert.AreEqual(0, bitCounting.CountBits(0));
            Assert.AreEqual(1, bitCounting.CountBits(4));
            Assert.AreEqual(3, bitCounting.CountBits(7));
            Assert.AreEqual(2, bitCounting.CountBits(9));
            Assert.AreEqual(2, bitCounting.CountBits(10));
        }
    }
}