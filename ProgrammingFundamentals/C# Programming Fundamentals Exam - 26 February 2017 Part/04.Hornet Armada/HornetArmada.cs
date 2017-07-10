using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Hornet_Armada
{
    class Soldiers
    {
        public string Type { get; set; }

        public int Count { get; set; }

        public int LastActivity { get; set; }
    }
    class HornetArmada
    {
        static void Main(string[] args)
        {
            var commandsCount = int.Parse(Console.ReadLine());
            var soldiers = new List<Soldiers>();
            var legionWithActivity = new Dictionary<string, int>();
            var legionWithSoldiers = new Dictionary<string, Dictionary<string, int>>();
            var pattern = @"^(?<LActv>[0-9]+)\s+=\s+(?<LName>[\w!\?_\@]+)\s+->\s+(?<SType>[a-zA-Z]+):(?<count>\d+)$";
            var collectData = new Regex(pattern);

            for (int i = 0; i < commandsCount; i++)
            {
                var input = Console.ReadLine();
                var isMatch = collectData.Match(input);
                
                var legionName = isMatch.Groups["LName"].Value;
                var lastActivity = int.Parse(isMatch.Groups["LActv"].Value);
                var soldierType = isMatch.Groups["SType"].Value;
                var count = int.Parse(isMatch.Groups["count"].Value);

                if (!legionWithActivity.ContainsKey(legionName))
                {
                    legionWithActivity.Add(legionName, lastActivity);
                    legionWithSoldiers.Add(legionName, new Dictionary<string, int>());
                }

                if(lastActivity > legionWithActivity[legionName])
                {
                    legionWithActivity[legionName] = lastActivity;
                }

                if (!legionWithSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionWithSoldiers[legionName].Add(soldierType, 0);
                }

                legionWithSoldiers[legionName][soldierType] += count;
            }

            var querie = Console.ReadLine().Split('\\');

            if (querie.Length > 1)
            {
                int activity = int.Parse(querie[0]);
                var soldierType = querie[1];

                foreach (var item in legionWithSoldiers
                    .Where(legion => legion.Value.ContainsKey(soldierType))
                    .OrderByDescending(legion => legion.Value[soldierType]))
                {
                    if(legionWithActivity[item.Key] < activity)
                    {
                        Console.WriteLine($"{item.Key} -> {legionWithSoldiers[item.Key][soldierType]}");
                    }
                }
            }
            else
            {
                var soldierType = querie[0];
    
                foreach (var item in legionWithActivity.OrderByDescending(legion => legion.Value))
                {
                    if (legionWithSoldiers[item.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{item.Value} : {item.Key}");
                    }
                }
            }
        }
    }
}
