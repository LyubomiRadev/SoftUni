using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            double bars = numberOfBeats / 4;
            bars = Math.Round(bars, 1);
            double minutes = 0;
            double seconds = 0;

            double betsPerScond = bpm / 60;
            numberOfBeats /= betsPerScond;

                minutes = numberOfBeats / 60;
                seconds = numberOfBeats % 60;


            minutes = Math.Floor(minutes);
            seconds = Math.Floor(seconds);
            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s");
        }
    }
}
