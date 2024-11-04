using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests._6Kyu.BitCounting
{
    [TestClass()]
    public class BitCountingTests
    {
        [TestMethod()]
        public void CountBitsTest()
        {
            CodeWars._6Kyu.BitCounting.BitCounting bitCounting = new CodeWars._6Kyu.BitCounting.BitCounting();
            Assert.AreEqual(0, bitCounting.CountBits(0));
            Assert.AreEqual(1, bitCounting.CountBits(4));
            Assert.AreEqual(3, bitCounting.CountBits(7));
            Assert.AreEqual(2, bitCounting.CountBits(9));
            Assert.AreEqual(2, bitCounting.CountBits(10));
        }
    }
}