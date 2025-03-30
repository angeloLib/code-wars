using System;
using System.Collections.Generic;

namespace CodeWars._6Kyu.Deadfish
{
    public class Deadfish
    {
        public static int[] Parse(string data)
        {
            int value = 0;
            List<int> output = new List<int>(); 

            foreach (char command in data)
            {
                switch (command)
                {
                    case 'i': value++; break;
                    case 'd': value--; break;
                    case 's': value *= value; break;
                    case 'o': output.Add(value); break;
                    default: continue;
                }
            }

            return output.ToArray();
        }
    }
}
