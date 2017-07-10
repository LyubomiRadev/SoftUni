using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03Nether_Realms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            var deamonNames = Regex.Split(Console.ReadLine(), @"\s*,\s*").ToList();
            deamonNames.Sort();
            var regex = @"(?<words>[a-zA-z]+)*(?<symbols>[\++\-+\*+\/+]*)(?<numbers>[0-9])*";
            var deamonsStats = new Dictionary<string, Dictionary<double, double>>();

            foreach (var deamon in deamonNames)
            {
                if (!deamonsStats.ContainsKey(deamon))
                {
                    deamonsStats[deamon] = new Dictionary<double, double>();
                }

                double deamonHealth = 0;
                double deamonDamage = 0;

                for (int i = 0; i < deamon.Length; i++)
                {
                    if (!Char.IsNumber(deamon[i]) && deamon[i] != '*' && deamon[i] != '/' && deamon[i] != '-' && deamon[i] != '+' && deamon[i] != '.')
                    {
                        deamonHealth += (int)deamon[i];
                    }                  
                }

                string numbersReg = @"[+-]?\d+(?:\.\d+)?";
                MatchCollection numbers = Regex.Matches(deamon, numbersReg);
                foreach(Match number in numbers)
                {
                    deamonDamage += double.Parse(number.ToString());
                }
                for (int i = 0; i < deamon.Length; i++)
                {
                    if(deamon[i] == '*')
                    {
                        deamonDamage *= 2;
                    }
                    if(deamon[i] == '/')
                    {
                        deamonDamage /= 2;
                    }
                }

                deamonsStats[deamon].Add(deamonHealth, deamonDamage);
                //MatchCollection letters = Regex.Matches(deamon, regex);
                //foreach(Match)
            }

            foreach(var deamon in deamonsStats)
            {
                var name = deamon.Key;
                var stats = deamon.Value;

                foreach(var stat in stats)
                {
                    var health = stat.Key;
                    var damage = stat.Value;

                    Console.WriteLine($"{name} - {health} health, {damage:F2} damage");
                }
                

            }
            
        }
    }
}
