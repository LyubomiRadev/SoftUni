using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.Key_Replacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            var keys = Console.ReadLine();
            var start = "";
            var end = "";

            var startEndPattern = new Regex(@"^(?<start>[a-zA-z0-9]+)[\|<\\]\w+[\|<\\](?<end>[a-zA-z0-9]+)");
            var doesMatch = startEndPattern.Match(keys);
            if (doesMatch.Success)
            {
                start = doesMatch.Groups["start"].Value;
                end = doesMatch.Groups["end"].Value;

            }

            var text = Console.ReadLine();

            string extractPattern = $"{start}(?<extract>[A-Za-z0-9]*?){end}";

            var match = Regex.Matches(text, extractPattern);
            var results = new List<string>();

            foreach (Match item in match)
            {
                results.Add(item.Groups["extract"].Value);
            }

            if(results.Count() != 0)
            {
                Console.WriteLine(string.Join("",results));
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
