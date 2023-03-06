using CodeWars._8Kyu.CubeChecker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars._8Kyu.CubeShape.Tests
{
    [TestClass()]
    public class CubeCheckerTests
    {
        [TestMethod]
        public void ShouldReturnFalse()
        {
            CubeCheck cube = new CubeCheck();
            Assert.AreEqual(true, cube.IsCube(1, 1));
            Assert.AreEqual(true, cube.IsCube(8, 2));
        }
        [TestMethod]
        public void ShouldReturnTrue()
        {
            CubeCheck cube = new CubeCheck();
            Assert.AreEqual(false, cube.IsCube(2, 1));
            Assert.AreEqual(false, cube.IsCube(6, 3));
            Assert.AreEqual(false, cube.IsCube(-8, -2));
            Assert.AreEqual(false, cube.IsCube(0, 0));
            Assert.AreEqual(false, cube.IsCube(200, 4));
        }
    }
}