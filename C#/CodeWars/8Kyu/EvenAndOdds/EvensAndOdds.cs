/*
This kata is about converting numbers to their binary or hexadecimal representation:

If a number is even, convert it to binary.
If a number is odd, convert it to hex.
Numbers will be positive. The hexadecimal string should be lowercased.
*/

using System;

namespace CodeWars._8Kyu.EvenAndOdds
{
    public static class EvensAndOdds
    {
        public static string EvensAndOddsConverter(int num)
        {
            return num % 2 == 0 ?  Convert.ToString(num, 2) : Convert.ToString(num, 16);
        }
    }
}