using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExtensions
{
    public static class CharExt
    {
        public static bool IsLetter(this char character)
        {
            return Char.IsLetter(character);
        }
        public static char ToLower(this char character)
        {
            return Char.ToLower(character);
        }

    }
}
