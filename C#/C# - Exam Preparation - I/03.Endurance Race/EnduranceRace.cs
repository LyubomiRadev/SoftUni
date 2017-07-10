using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Race
{
    class EnduranceRace
    {
        static void Main(string[] args)
        {
            var players = Console.ReadLine().Split().Where(a => a.Length > 0).ToList();
            double[] trackLayout = Console.ReadLine().Split().Where(a => a.Length > 0).Select(a =>double.Parse(a) * -1).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Where(a => a.Length>0).Select(int.Parse).ToArray();

            foreach(var checkpoint in checkpoints)
            {
                if(checkpoint >=0 && checkpoint < trackLayout.Length)
                {
                    trackLayout[checkpoint] *= -1;
                }
               
            }

            foreach(var player in players)
            {
                var fuel = (double)player[0];
                var index = 0;
                foreach (var number in trackLayout)
                {
                    
                    fuel += number;
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{player} - reached {index}");
                        break;
                    }
                    index++;
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{player} - fuel left {fuel:F2}");
                }
            }


            //var playersStatistics = new Dictionary<string, double>();

            //foreach(var player in players)
            //{
            //    if (!playersStatistics.ContainsKey(player))
            //    {
            //        playersStatistics.Add(player, (int)player[0]);
            //    }
            //}

            //foreach(var player in playersStatistics)
            //{
            //    var person = player.Key;
            //    var fuel = player.Value;
            //    for (int i = 0; i < checkpoints.Count() - 1; i++)
            //    {
            //        for (int j = 0; j < trackLayout.Count() - 1; j++)
            //        {
            //            if (checkpoints[i] == j)
            //            {
            //                playersStatistics[person] += trackLayout[j];
            //            }
            //            else
            //            {
            //                playersStatistics[person] -= trackLayout[j];
            //            }
            //            if (fuel <= 0)
            //            {
            //                Console.WriteLine($"{person} - reached 0");
            //                break;
            //            }
            //        }
            //    }

            //    Console.WriteLine($"{person} - fuel left {fuel:F2}");

            //}

        }
    }
}
