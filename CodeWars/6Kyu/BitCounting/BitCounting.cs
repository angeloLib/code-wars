using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6Kyu
{
    public class BitCounting
    {
        public int CountBits(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException("n", "Input value must be an non negative integer.");
            return CountOnes(Convert.ToString(n, 2));
        }

        private int CountOnes(string s)
        {
            char[] chars = s.ToCharArray();
            int count = 0;
            foreach (char c in chars)
            {
                if (c == '1') count++;
            }
            return count;
        }
    }
}
