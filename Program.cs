using System;
using System.Collections.Generic;

Console.WriteLine(Palindrome.Checker.Check("mmop"));
Console.WriteLine(Palindrome.Checker.Check("kjjjhjjj"));

namespace Palindrome
{
    public static class Checker
    {
        private const string NOT_POSSIBLE = "not possible";

        public static string Check(string? input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return NOT_POSSIBLE;
            }

            List<char> singles = new();
            List<char> doubles = new();

            foreach (char c in input)
            {
                if (singles.Exists(s => s == c))
                {
                    singles.Remove(c);
                    doubles.Add(c);
                }
                else
                {
                    singles.Add(c);
                }
            }

            return (singles.Count > 2 || doubles.Count < 3)
                ? NOT_POSSIBLE
                : string.Join(string.Empty, singles.GetRange(0, singles.Count - 1));
        }
    }
}
