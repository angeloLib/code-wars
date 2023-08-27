using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars._7Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars._7Kyu.VowelCount;

namespace CodeWars._7Kyu.Tests
{
    [TestClass()]
    public class VowelCountTests
    {
        [TestMethod]
        public void TestCase1()
        {
            Assert.AreEqual(5, VowelCount.VowelCount.GetVowelCount("abracadabra"));
        }
    }
}