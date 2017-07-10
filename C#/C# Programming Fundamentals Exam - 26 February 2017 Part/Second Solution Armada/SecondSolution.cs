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

    }
    class HornetArmada
    {
        static bool IsLegionToBePrinted(Dictionary<string, Dictionary<int, Soldiers>> legionData, string legionName, int activity, string soldierType, int count)
        {
            Dictionary<int, Soldiers> activitiesData = legionData[legionName];

            int lastActivity = 0;
            foreach (var activityData in activitiesData)
            {
                lastActivity = activityData;
            }

            if (lastActivity < activity)
            {
                activitiesData.Add(activity, new Soldiers() { Type = soldierType, Count = count });
            }
        }

        static void Main(string[] args)
        {
            var commandsCount = int.Parse(Console.ReadLine());
            var soldiers = new List<Soldiers>();
            
            var legions = new Dictionary<string, Dictionary<int, Soldiers>>();
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

                var addSoldiers =  new Soldiers
                {
                    Type = soldierType,
                    Count = count
                };

                if (!legions.ContainsKey(legionName))
                {
                    legions[legionName].Add(lastActivity,  new Soldiers());
                }
                legions[legionName][lastActivity].Type .Count

                if (lastActivity > prevousActivity)
                {

                }
            }

            var querie = Console.ReadLine().Split('\\');

            
        }
    }
}
