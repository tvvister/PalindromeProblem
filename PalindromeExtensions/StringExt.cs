using System.Linq;
using PalindromeExtensions;
public  static partial class StringExt
{

    private static int InvalidIndex = -1;

    public static bool IsPalindrome(this string input)
    {
        var letterCount = input.Count(x => x.IsLetter());
        if (letterCount == 0 || letterCount == 1) return true;
        var leftIndex = 0;
        var rightIndex = input.Count() - 1;

        while (leftIndex <= rightIndex)
        {
            while (leftIndex < input.Count() && !input[leftIndex].IsLetter())
            {
                leftIndex++;
            }
            while (rightIndex > InvalidIndex && !input[rightIndex].IsLetter())
            {
                rightIndex--;
            }
            if (leftIndex != input.Count() && rightIndex != InvalidIndex)
            {
                if (input[rightIndex].ToLower() != input[leftIndex].ToLower())
                {
                    return false;
                }
            }
            leftIndex++;
            rightIndex--;
        }
        return true;
    }
}