using System.Collections.Generic;
namespace CodeWars._7Kyu.VowelCount
{
    public abstract class VowelCount
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
