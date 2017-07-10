using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingSystemHealth = int.Parse(Console.ReadLine());
            int currentSystemHealth = startingSystemHealth;
            var virusesNamesCount = new Dictionary<string, int>();
            bool canContinue = true;

            while (canContinue)
            {
                string virusName = Console.ReadLine();
                if (virusName == "end")
                {
                    Console.WriteLine($"Final Health: {currentSystemHealth}");
                    break;
                }
                if (!virusesNamesCount.ContainsKey(virusName))
                {
                    virusesNamesCount.Add(virusName, 1);
                }
                else
                {
                    virusesNamesCount[virusName] += 1;
                }
                

                int virusStrength = 0;
                int timeToDefeatVirus = 0;
                int minutesToDefeatVirus = 0;
                int secondsToDefeatVirus = 0;                                
                    
                for (int i = 0; i < virusName.Length; i++)
                {
                    virusStrength += (int)virusName[i];
                }

                virusStrength /= 3;
                virusStrength *= virusName.Length;

                if (virusesNamesCount[virusName] > 1)
                {
                    timeToDefeatVirus = (virusStrength ) / 3;
                }
                else
                {
                    timeToDefeatVirus = virusStrength ;
                   
                }
                minutesToDefeatVirus = timeToDefeatVirus / 60;
                secondsToDefeatVirus = timeToDefeatVirus % 60;
                
                currentSystemHealth -= timeToDefeatVirus;

                if (currentSystemHealth > 0)
                {
                    Console.WriteLine($"Virus {virusName}: {virusStrength / virusName.Length} => {timeToDefeatVirus} seconds");
                    Console.WriteLine($"{virusName} defeated in {minutesToDefeatVirus}m {secondsToDefeatVirus}s.");
                    Console.WriteLine($"Remaining health: {currentSystemHealth}");
                    currentSystemHealth += (int)(currentSystemHealth * 0.2);
                    if (currentSystemHealth > startingSystemHealth)
                    {
                        currentSystemHealth = startingSystemHealth;
                    }
                }
                else
                {
                    Console.WriteLine($"Virus {virusName}: {virusStrength / virusName.Length} => {timeToDefeatVirus} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }

            }
        }
    }
}
