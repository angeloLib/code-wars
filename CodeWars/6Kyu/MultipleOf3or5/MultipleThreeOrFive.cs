using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6Kyu.MultipleOf3or5
{
    public class MultipleThreeOrFive
    {
        public static int Solution(int value)
        {
            int sum = 0;
            if (value <= 0) return 0;
            for (int i = 1; i < value; i++)
            {
                sum += isMultiple(value - i);
            }
            return sum;
        }

        private static int isMultiple(int v)
        {
            return v % 3 == 0 || v % 5 == 0 ? v : 0;
        }
    }
}
