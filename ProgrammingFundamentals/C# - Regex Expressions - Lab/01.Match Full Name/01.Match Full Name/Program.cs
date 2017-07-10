using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = (@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            MatchCollection results = Regex.Matches(input, pattern);

            foreach(Match result in results)
            {
                Console.Write($"{result} ");
            }
        }
    }
}
