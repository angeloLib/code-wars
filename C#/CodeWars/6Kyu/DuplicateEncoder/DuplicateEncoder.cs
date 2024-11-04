using System.Collections.Generic;
namespace CodeWars._6Kyu.DuplicateEncoder
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
                else { dic.Add(letter, 1); }
            }
            foreach (var letter in word.ToCharArray())
            {
                int i = 0;
                if (dic.ContainsKey(char.ToLower(letter)))
                {
                    i = i + (dic.ContainsKey(letter) ? 1 : 0);
                }
                result = result + (i > 1 ? ")" : "(");
            }
            return result;
        }
    }
}
