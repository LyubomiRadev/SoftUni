using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Date_Match
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = @"\b(?<day>[0-9]{2})([\.\-\/])(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})(,|)\b";
            MatchCollection results = Regex.Matches(input, pattern);
           
            foreach(Match result in results)
            {
                var day = result.Groups["day"].Value;
                var month = result.Groups["month"].Value;
                var year = result.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

            
        }
    }
}
