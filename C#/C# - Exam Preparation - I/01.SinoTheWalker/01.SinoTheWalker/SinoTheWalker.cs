using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine();

            DateTime leave = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());

            var totalTime = (long)steps * secondsPerStep;

            var day = 24 * 60 * 60;
            totalTime = totalTime % day;

           leave= leave.AddSeconds(totalTime);

            Console.WriteLine("Time Arrival: {0}",leave.ToString("HH:mm:ss"));

        }
    }
}
