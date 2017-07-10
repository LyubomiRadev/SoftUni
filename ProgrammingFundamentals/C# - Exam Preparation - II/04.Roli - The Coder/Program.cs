using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Roli___The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var eventsInfo = new Dictionary<int, Dictionary<string, HashSet<string>>>();
            while (input.ToLower() != "time for code")
            {
                string pattern = @"(?<eventID>\d+)\s+#(?<eventName>\w+)(?<participents>\s+(?:\@\w+\s*)*)?";
                MatchCollection match = Regex.Matches(input, pattern);


                foreach (Match evnt in match)
                {
                    var eventId = int.Parse(evnt.Groups["eventID"].Value);
                    var eventName = evnt.Groups["eventName"].Value;
                    var names = evnt.Groups["participents"].Value.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var namesPattern = @"\w+";

                    if (!eventsInfo.ContainsKey(eventId))
                    {
                        eventsInfo[eventId] = new Dictionary<string, HashSet<string>>();

                        if(!eventsInfo[eventId].ContainsKey(eventName))
                        {
                            eventsInfo[eventId][eventName] = new HashSet<string>();
                        }
                    }
                    else
                    {
                        if (!eventsInfo[eventId].ContainsKey(eventName))
                        {
                            continue;
                        }
                    }

                    foreach (var participents in names)
                    {
                        eventsInfo[eventId][eventName].Add(participents);
                    }
                }

                input = Console.ReadLine();
            }
            
            var sortedEvents = new Dictionary<string, HashSet<string>>();
            

            foreach (var item in eventsInfo)
            {
                foreach (var value in item.Value)
                {
                    sortedEvents.Add(value.Key, value.Value);
                }
            }

            foreach (var outerkey in sortedEvents.OrderByDescending(a => a.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{outerkey.Key} - {outerkey.Value.Count}");
                Console.WriteLine($"{string.Join("\n", outerkey.Value.OrderBy(x => x))}");
            }
        }
    }
}
