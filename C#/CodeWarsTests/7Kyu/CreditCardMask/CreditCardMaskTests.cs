using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars._7Kyu.CreditCardMask;

namespace CodeWarsTests._7Kyu.MaskifyTests
{
    [TestClass]
    public class CreditCardMaskTests
    {
        [TestMethod]
        public void ExamplesTests()
        {
            Assert.AreEqual("############5616", CreditCardMask.Maskify("4556364607935616"));
            Assert.AreEqual("1", CreditCardMask.Maskify("1"));
            Assert.AreEqual("#1111", CreditCardMask.Maskify("11111"));
        }
    }
}
