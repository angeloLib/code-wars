using System;
using System.Linq;

namespace CodeWars._6Kyu.Rotate
{
    public static class RotateExercice
    {
        public static object[] Rotate(object[] array, int n)
        {
            if (array == null || array.Length == 0 || n == 0)
                return array;

            int length = array.Length;
            n = ((n % length) + length) % length;

            return array.Skip(length - n).Concat(array.Take(length - n)).ToArray();
        }
    }
}
