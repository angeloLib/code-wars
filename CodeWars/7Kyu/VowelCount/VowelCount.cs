using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7Kyu.VowelCount
{
    public class VowelCount
    {
        private static List<char> vowels = new List<char>()
        {
            'a',
            'e',
            'i',
            'o',
            'u'
        };
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            foreach (char ch in str)
            {
                vowelCount += vowels.Contains(ch) ? 1 : 0;
            }
            return vowelCount;
        }
    }
}
