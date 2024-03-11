using System.Text.RegularExpressions;
namespace StaticEnumExtension;
internal static class Extension
{
    public static int Factorial(this int value)
    {
        int result = 1;
        for (var i = 1; i <= value; i++)
        {
            result *= i;
        }
        return result;
    }
    public static int MatchCount(this string word, string target)
    {
       return Regex.Count(target, @"\b{0}\b");
    }
}
