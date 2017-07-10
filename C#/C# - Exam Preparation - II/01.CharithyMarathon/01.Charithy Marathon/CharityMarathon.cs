using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charithy_Marathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var marathonDuration = int.Parse(Console.ReadLine());
            var participents = int.Parse(Console.ReadLine());
            var runnerLaps = double.Parse(Console.ReadLine());
            var trackLength = double.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            var OverallTrackCapacity = trackCapacity * marathonDuration;
            if (participents > OverallTrackCapacity)
            {
                participents = OverallTrackCapacity;
            }

            var totalMeters = participents * runnerLaps * trackLength;
            var totalKilometers = totalMeters / 1000;
            var totalSum = totalKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {totalSum:F2}");
        }
    }
}
