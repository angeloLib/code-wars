using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6Kyu.PlayingWithDigits
{
    public class PlayingWithDigits
    {
        public static long DigPow(int n, int p)
        {
            string digits = n.ToString();
            long sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                int digit = int.Parse(digits[i].ToString());
                sum += (long)Math.Pow(digit, p + i);
            }

            if (sum % n == 0)
            {
                return sum / n;
            }
            else
            {
                return -1;
            }
        }
    }
}
