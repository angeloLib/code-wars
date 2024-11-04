using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace CodeWarsTests._8Kyu.EvensAndOdds
{


    [TestClass()]
    public class EvensAndOddsTest
    {
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual("10", CodeWars._8Kyu.EvenAndOdds.EvensAndOdds.EvensAndOddsConverter(2));
            Assert.AreEqual("d", CodeWars._8Kyu.EvenAndOdds.EvensAndOdds.EvensAndOddsConverter(13));
            Assert.AreEqual("2f", CodeWars._8Kyu.EvenAndOdds.EvensAndOdds.EvensAndOddsConverter(47));
            Assert.AreEqual("0", CodeWars._8Kyu.EvenAndOdds.EvensAndOdds.EvensAndOddsConverter(0));
            Assert.AreEqual("11001000000000", CodeWars._8Kyu.EvenAndOdds.EvensAndOdds.EvensAndOddsConverter(12800));
        }
    }
}