using System.Text.RegularExpressions;

namespace App_17_Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Mi numbre es Nahu D. Bog y mi número de tel es (+55) 123-1234-2134 y mi código postal es 1872";
            string pattern = "[m|M]i";
            Regex rx = new(pattern);
            MatchCollection matches = rx.Matches(text);

            Console.WriteLine($"Number of occurences: {matches.Count}");
            foreach(Match match in matches) Console.WriteLine(match);
        }
    }
}