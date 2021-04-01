using System.Collections.Generic;
using System.Linq;

namespace CSharpTest
{
    public static class LetterCounter
    {
        public static Dictionary<char, int> CountNumbers(this string str)
        {
            return str.ToCharArray()
                .Where(char.IsNumber)
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());
        }
    }
}