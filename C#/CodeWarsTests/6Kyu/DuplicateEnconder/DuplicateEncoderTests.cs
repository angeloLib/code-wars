using CodeWars._6Kyu;
using CodeWars._6Kyu.DuplicateEncoder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests._6Kyu.DuplicateEnconder
{
    [TestClass()]
    public class DuplicateEncoderTests
    {
        [TestMethod()]
        public void BasicTests()
        {
            DuplicateEncoder duplicateEncoder = new DuplicateEncoder();
            Assert.AreEqual("(((", duplicateEncoder.DuplicateEncode("din"));
            Assert.AreEqual("()()()", duplicateEncoder.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", duplicateEncoder.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", duplicateEncoder.DuplicateEncode("(( @"));

            //din = todos os chars são diferentes = (((
            //recede = apenas os e's são iguais ()()()
            //success = repete os S, logo )())())
            //(( @ = logo  ))((  

        }
    }
}