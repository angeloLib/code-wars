using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests._7Kyu.VowelCount
{
    [TestClass()]
    public class VowelCountTests
    {
        [TestMethod]
        public void TestCase1()
        {
            Assert.AreEqual(5, CodeWars._7Kyu.VowelCount.VowelCount.GetVowelCount("abracadabra"));
        }
    }
}