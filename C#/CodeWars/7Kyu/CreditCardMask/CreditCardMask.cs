/*
 * Usually when you buy something, you're asked whether your credit card number,
 * phone number or answer to your most secret question is still correct.
 * 
 * However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

Your task is to write a function maskify, which changes all but the last four characters into '#'.
*/

using System;
using System.Linq;
using System.Text;
using CodeWars._7Kyu.CreditCardMask;

namespace CodeWars._7Kyu.CreditCardMask
{
    public static class CreditCardMask
    {
        private const char replaceValue = '#';
        private const int lookupValue = 4;
        public static string Maskify(string cc)
        {
            int timesReplaceValue = (cc.Length - lookupValue);

            return cc.Length <= 4 ? cc : new string(
                cc.Substring(0, timesReplaceValue).Select(c => replaceValue).ToArray()) + cc.Substring(timesReplaceValue, (cc.Length) - (timesReplaceValue));
        }
    }
}
