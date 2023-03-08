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