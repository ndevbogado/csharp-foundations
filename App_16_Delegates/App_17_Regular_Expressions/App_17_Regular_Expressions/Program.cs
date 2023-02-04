using System.Text.RegularExpressions;

namespace App_17_Regular_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "https://www.github.com/ndevbogado";
            string pattern = @"https?://(www.)?.*";
            Regex rx = new(pattern);
            MatchCollection matches = rx.Matches(text);

            Console.WriteLine($"Number of occurences: {matches.Count}");
            foreach(Match match in matches) Console.WriteLine(match);
        }
    }
}