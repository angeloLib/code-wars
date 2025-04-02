using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars._6Kyu.Rotate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWarsTests._6Kyu.Rotate
{
    public class RotateExercicesTests
    {
        [TestClass]
        public class KataTest
        {
            public static IEnumerable<object[]> RotateTestCases()
            {
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, 1, new object[] { 5, 1, 2, 3, 4 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, 2, new object[] { 4, 5, 1, 2, 3 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, 3, new object[] { 3, 4, 5, 1, 2 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, 4, new object[] { 2, 3, 4, 5, 1 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, 5, new object[] { 1, 2, 3, 4, 5 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, 0, new object[] { 1, 2, 3, 4, 5 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, -1, new object[] { 2, 3, 4, 5, 1 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, -2, new object[] { 3, 4, 5, 1, 2 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, -3, new object[] { 4, 5, 1, 2, 3 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, -4, new object[] { 5, 1, 2, 3, 4 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, -5, new object[] { 1, 2, 3, 4, 5 } };
                yield return new object[] { new object[] { 'a', 'b', 'c' }, 1, new object[] { 'c', 'a', 'b' } };
                yield return new object[] { new object[] { 1.0, 2.0, 3.0 }, 1, new object[] { 3.0, 1.0, 2.0 } };
                yield return new object[] { new object[] { true, true, false }, 1, new object[] { false, true, true } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, 7, new object[] { 4, 5, 1, 2, 3 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, 11, new object[] { 5, 1, 2, 3, 4 } };
                yield return new object[] { new object[] { 1, 2, 3, 4, 5 }, 12478, new object[] { 3, 4, 5, 1, 2 } };
            }

            [TestMethod]
            [DynamicData(nameof(RotateTestCases), DynamicDataSourceType.Method)]
            public void RotateTest(object[] data, int rotation, object[] expected)
            {
                CollectionAssert.AreEqual(expected, RotateExercice.Rotate(data, rotation));
            }
        }
    }
}
