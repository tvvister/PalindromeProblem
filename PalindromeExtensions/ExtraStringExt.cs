using System.Linq;
using PalindromeExtensions;
public static partial class StringExt
{
    public static bool IsPalindromeSimple(this string input)
    {
        var halfLetterCount = input.Count(x => x.IsLetter()) / 2;

        var leftHalfChars = input
            .Where(ch => ch.IsLetter())
            .Take(halfLetterCount);

        var rightHalfChars = input
            .Where(ch => ch.IsLetter())
            .Reverse()
            .Take(halfLetterCount);

        return leftHalfChars
            .Zip(rightHalfChars, (left, right) => left.ToLower() == right.ToLower())
            .All(x => x);
    }

}

