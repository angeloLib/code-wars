namespace CodeWars._6Kyu.SplitString
{
    public class SplitString
    {
        public static string[] Solution(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            int pairCount = (str.Length + 1) / 2;
            string[] result = new string[pairCount];

            for (int i = 0; i < pairCount; i++)
            {
                if (i == pairCount - 1 && str.Length % 2 != 0)
                {
                    result[i] = str.Substring(i * 2, 1) + "_";
                }
                else
                {
                    result[i] = str.Substring(i * 2, 2);
                }
            }

            return result;
        }
    }
}
