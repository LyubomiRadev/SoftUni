using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07.Email_Statistics
{
    class EmailStatistics
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var info = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine();

                string pattern = @"^(?<username>[a-zA-Z]{5,})\@(?<domain>[a-z]{3,}\.(bg|com|org))$";
                Regex regex = new Regex(pattern);
                MatchCollection emails = Regex.Matches(input, pattern);

                foreach (Match email in emails)
                {

                    var user = email.Groups["username"].Value;
                    var domain = email.Groups["domain"].Value;

                    if (!info.ContainsKey(domain))
                    {
                        info[domain] = new HashSet<string>();

                    }
                    info[domain].Add(user);
                }
            }

            foreach(var item in info.OrderByDescending(match => match.Value.Count))
            {
                Console.WriteLine($"{item.Key}:");
                foreach(var user in item.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
