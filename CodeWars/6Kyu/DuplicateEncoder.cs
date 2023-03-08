using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6Kyu
{
    public class DuplicateEncoder
    {
        public string DuplicateEncode(string word)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            string result = string.Empty;
            foreach (var letter in word.ToCharArray())
            {
                if (dic.ContainsKey(letter))
                {
                    dic[letter] = dic[letter] + 1;
                }
                else { dic.Add(char.ToLower(letter), 1); }
            }
            foreach (var letter in word.ToCharArray())
            {
                result = result + (dic[char.ToLower(letter)] > 1 ? ")" : "(");
            }
            return result;
        }
    }
}
