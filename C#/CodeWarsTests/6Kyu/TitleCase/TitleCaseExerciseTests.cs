using System.Collections.Generic;
using CodeWars._6Kyu;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests._6Kyu.TitleCase
{
    [TestClass]
    public class TitleCaseExerciseTests
    {
        public static IEnumerable<object[]> SampleTestCases()
        {
            yield return new object[] { "a clash of KINGS", "a an the of", "A Clash of Kings" };
            yield return new object[] { "The Walking Dead", "the", "The Walking Dead" };
            yield return new object[] { "THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows" };
            yield return new object[] { "First a of in", "an often into", "First A Of In" };
            yield return new object[] { "aBC deF Ghi", null, "Abc Def Ghi" };
        }

        [TestMethod]
        [DynamicData(nameof(SampleTestCases), DynamicDataSourceType.Method)]
        public void SampleTest(string sampleTitle, string sampleMinorWords, string expected)
        {
            Assert.AreEqual(expected, TitleCaseExercise.TitleCase(sampleTitle, sampleMinorWords));
        }

        [TestMethod]
        public void TestEmptyString()
        {
            Assert.AreEqual("", TitleCaseExercise.TitleCase(""));
        }

        [TestMethod]
        public void TestBasicTitleCase()
        {
            Assert.AreEqual("The Quick Brown Fox", TitleCaseExercise.TitleCase("the quick brown fox"));
        }
    }
}
