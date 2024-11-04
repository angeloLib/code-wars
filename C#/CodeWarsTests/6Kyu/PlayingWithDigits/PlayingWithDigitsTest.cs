using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests._6Kyu.PlayingWithDigits
{
    [TestClass()]
    public class PlayingWithDigitsTest
    {
        [TestMethod()]
        public void BasicTests()
        {
            Assert.AreEqual(1, CodeWars._6Kyu.PlayingWithDigits.PlayingWithDigits.DigPow(89, 1));

        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(-1, CodeWars._6Kyu.PlayingWithDigits.PlayingWithDigits.DigPow(92, 1));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(51, CodeWars._6Kyu.PlayingWithDigits.PlayingWithDigits.DigPow(46288, 3));
        }
    }
}