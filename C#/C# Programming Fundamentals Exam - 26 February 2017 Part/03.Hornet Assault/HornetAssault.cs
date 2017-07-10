using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornetsPower = Console.ReadLine().Split().Select(long.Parse).ToList();

            var outputBeehives = new List<long>();
            
            for (int i = 0; i < beehives.Count(); i++)
            {
                var currentHornetsPower = hornetsPower.Sum();
                var beehive = beehives[i];
                var result = beehive - currentHornetsPower;

                if (result >= 0)
                {
                    hornetsPower.RemoveAt(0);
                    beehive -= currentHornetsPower;
                    if(beehive > 0)
                    {
                        outputBeehives.Add(beehive);
                    }
                   
                }               
               
            }

            if (outputBeehives.Count() > 0)
            {
                Console.WriteLine(string.Join(" ",outputBeehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornetsPower));
            }
        }
    }
}
