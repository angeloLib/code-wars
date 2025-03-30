using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests._6Kyu.Deadfish
{
    [TestClass()]
    public class DeadfishTests
    {
        public static IEnumerable<object[]> SampleTestCases()
        {
            yield return new object[] { "iiisdoso", new int[] { 8, 64 } };
            yield return new object[] { "iiisdosodddddiso", new int[] { 8, 64, 3600 } };
        }

        [TestMethod]
        [DynamicData(nameof(SampleTestCases), DynamicDataSourceType.Method)]
        public void SampleTest(string data, int[] expected)
        {
            CollectionAssert.AreEqual(expected, CodeWars._6Kyu.Deadfish.Deadfish.Parse(data));
        }
    }
}
