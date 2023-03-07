using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars._7Kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7Kyu.Tests
{
    [TestClass()]
    public class ListFilltererTests
    {
        private ListFillterer _listFillterer;
        [TestMethod]
        public void GetIntegersFromList_MixedValues_ShouldPass_1()
        {
            _listFillterer = new ListFillterer();
            var list = new List<object>() { 1, 2, "a", "b" };
            var expected = new List<int>() { 1, 2 };
            var actual = _listFillterer.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void GetIntegersFromList_MixedValues_ShouldPass_2()
        {
            _listFillterer = new ListFillterer();
            var list = new List<object>() { 1, "a", "b", 0, 15 };
            var expected = new List<int>() { 1, 0, 15 };
            var actual = _listFillterer.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void GetIntegersFromList_MixedValues_ShouldPass_3()
        {
            _listFillterer = new ListFillterer();
            var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            var expected = new List<int>() { 1, 2, 123 };
            var actual = _listFillterer.GetIntegersFromList(list);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}