using CodeWars._6Kyu.MultipleOf3or5;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars._6Kyu.Tests
{
    [TestClass()]
    public class MultipleOfThreeOrFiveTests
    {
        [TestMethod()]
        public void BasicTests()
        {
            Assertion(expected: 23, input: 10);
            Assertion(expected: 78, input: 20);
            Assertion(expected: 9168, input: 200);
            Assertion(expected: 0, input: 0);
        }

        private static void Assertion(int expected, int input) =>
         Assert.AreEqual(
            expected,
            MultipleThreeOrFive.Solution(input),
            $"Value: {input}"
        );
    }
}