using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests._7Kyu.PasswordValidator
{
    [TestClass] // ✅ MSTest uses [TestClass]
    public class PasswordValidatorTests
    {
        [TestMethod] // ✅ Use [TestMethod] instead of [Test]
        public void TestValidPasswords()
        {
            DoTest("Abcd1234", true);
            DoTest("AbcdefGhijKlmnopQRsTuvwxyZ1234567890", true);
            DoTest("Ab1!@#$%^&*()-_+={}[]|:;?/>.<,", true);
            DoTest(" aA1----", true);
            DoTest("4aA1----", true);
        }

        [TestMethod]
        public void TestTooShortPasswords()
        {
            DoTest("Abcd123", false);
        }

        [TestMethod]
        public void TestMissingUppercaseLetters()
        {
            DoTest("abcd1234", false);
        }

        [TestMethod]
        public void TestMissingDigits()
        {
            DoTest("abcdABCD", false);
        }

        [TestMethod]
        public void TestMissingLowercaseLetters()
        {
            DoTest("ABCD1234", false);
        }

        [TestMethod]
        public void TestOnlySpecialCharacters()
        {
            DoTest("!@#$%^&*()-_+={}[]|:;?/>.<,", false);
        }

        [TestMethod]
        public void TestEmptyPassword()
        {
            DoTest("", false);
        }

        private void DoTest(string password, bool expected)
        {
            Assert.AreEqual(expected, CodeWars._7Kyu.PasswordValidator.PasswordValidator.Password(password),
                $"Expected {expected} for password \"{password}\".");
        }
    }
}
