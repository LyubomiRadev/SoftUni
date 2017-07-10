using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            int chosenDistance = int.Parse(Console.ReadLine());
            double distancePer1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            int rests = chosenDistance / endurance;
            long seconds = rests * 5L;
            seconds+=(chosenDistance/100);
            var distance = (chosenDistance / 1000) * distancePer1000Flaps;
            

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{seconds} s.");
        }
    }
}
