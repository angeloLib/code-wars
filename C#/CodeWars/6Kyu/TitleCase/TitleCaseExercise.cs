/*
 * *
A string is considered to be in title case if each word in the string is either (a) capitalised (that is, only the first letter of the word is in upper case) or (b) considered to be an exception and put entirely into lower case unless it is the first word, which is always capitalised.

Write a function that will convert a string into title case, given an optional list of exceptions (minor words). The list of minor words will be given as a string with each word separated by a space. Your function should ignore the case of the minor words string -- it should behave in the same way even if the case of the minor word string is changed.

Arguments (Haskell)
First argument: space-delimited list of minor words that must always be lowercase except for the first word in the string.
Second argument: the original string to be converted.
Arguments (Other languages)
First argument (required): the original string to be converted.
Second argument (optional): space-delimited list of minor words that must always be lowercase except for the first word in the string. The JavaScript/CoffeeScript tests will pass undefined when this argument is unused.
 * */
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars._6Kyu
{
    public static class TitleCaseExercise
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            return string.IsNullOrEmpty(title) ?
                string.Empty :
                string.Join(" ", title.Split(' ').ToList().Select((word, index) => BuildTitle(word, index, minorWords)));
        }

        private static string BuildTitle(string word, int index, string minorWords)
        {
            return CheckIfInMinorWords(word, index, minorWords) ?
                word.ToLowerInvariant() : word.First().ToString().ToUpperInvariant() + word.Substring(1, word.Length - 1).ToLowerInvariant();
        }

        private static bool CheckIfInMinorWords(string word, int index, string minorWords)
        {
            return !string.IsNullOrEmpty(minorWords) 
                && minorWords.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Contains(word, StringComparer.OrdinalIgnoreCase) && index > 0;
        }
    }
}
