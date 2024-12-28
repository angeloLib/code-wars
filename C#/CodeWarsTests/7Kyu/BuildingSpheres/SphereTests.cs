using CodeWars._7Kyu.BuildingSpheres;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests._7Kyu.BuildingSpheres
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public static void ExampleTest()
        {
            Sphere ball = new Sphere(2, 50);
            Assert.AreEqual(2.0, ball.GetRadius(), 0.00001, "Check radius");
            Assert.AreEqual(50.0, ball.GetMass(), 0.00001, "Check mass");
            Assert.AreEqual(33.51032, ball.GetVolume(), 0.00001, "Check volume");
            Assert.AreEqual(50.26548, ball.GetSurfaceArea(), 0.00001, "Check area");
            Assert.AreEqual(1.49208, ball.GetDensity(), 0.00001, "Check density");
        }
    }
}
