using CodeWars._6Kyu.MultipleOf3or5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class PlayingWithDigitsTest
    {
        [TestMethod()]
        public void BasicTests()
        {
            Assert.AreEqual(1, PlayingWithDigits.PlayingWithDigits.DigPow(89, 1));

        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(-1, PlayingWithDigits.PlayingWithDigits.DigPow(92, 1));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(51, PlayingWithDigits.PlayingWithDigits.DigPow(46288, 3));
        }
    }
}