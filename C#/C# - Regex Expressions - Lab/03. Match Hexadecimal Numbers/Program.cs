using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Match_Hexadecimal_Numbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = @"\b(0x)?([0-9A-F])+\b";

            MatchCollection results = Regex.Matches(input, pattern);
            var collection = new List<Match>();

            foreach(Match result in results)
            {
                collection.Add(result);
            }

            Console.WriteLine(string.Join(" ",collection));
        }
    }
}
