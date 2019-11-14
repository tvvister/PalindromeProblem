using System;
using System.Diagnostics;

namespace PalindromeProblem
{
    class Program
    {
        //Test alarm works only for debug build
        static void Main(string[] args)
        {
            var inputs = new[]
            {
                new {str = "abbba", result = true},
                new {str = "Nan", result = true},
                new {str = "SaaS", result = true},
                new {str = "", result = true},
                new {str = "a", result = true},
                new {str = ",", result = true},
                new {str = "a,", result = true},
                new {str = ",a", result = true},
                new {str = "a,a", result = true},
                new {str = "aa,a", result = true},
                new {str = "a,aa", result = true},
                new {str = "ab", result = false},
                new {str = "abba", result = true},
                new {str = "A?ba", result = true},
                new {str = "A man, a plan, a canal, Panama!", result = true},
                new {str = "A man, f a plan, a canal, Panama!", result = false},
                new {str = "A man, a plan, a canal, Panama!f", result = false},
            };

            foreach (var test in inputs)
            {
                var isPalindrome = test.str.IsPalindrome();
                var isPalindromeSimple = test.str.IsPalindromeSimple();
                if (isPalindrome != test.result || isPalindromeSimple != test.result)
                {
                    var message = new { isPalindrome, isPalindromeSimple, test.result }.ToString();
                    Debug.Assert(false, message);
                    Console.WriteLine(message);
                }
            }
        }
    }
}
