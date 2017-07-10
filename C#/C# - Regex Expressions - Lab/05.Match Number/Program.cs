using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.Match_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            string pattern = @"(^|(?<=\s))-?[0-9]+(.[0-9]+)?($|(?=\s))";

            MatchCollection numbers = Regex.Matches(input, pattern);

            foreach(Match number in numbers)
            {
                Console.Write(number.Value+" ");
            }
        }
    }
}
