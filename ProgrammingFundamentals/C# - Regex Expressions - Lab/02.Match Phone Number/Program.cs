using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inpupt = Console.ReadLine();

            string pattern = @"(\s|^)\+359 2 ([0-9]{3}) ([0-9]{4})\b|(\s|^)\+359-2-([0-9]{3})-([0-9]{4})\b";

            MatchCollection results = Regex.Matches(inpupt, pattern);

            var result = results.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", result));


        }
    }
}
