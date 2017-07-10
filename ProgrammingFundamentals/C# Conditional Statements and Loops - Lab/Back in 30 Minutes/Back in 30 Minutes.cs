using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_One
{
    class Program
    {
        static void Main(string[] args)
        {

            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if (minutes > 59)
            {
                minutes = minutes % 60;
                hours++;
            }
            if (hours > 23)
            {
                hours = hours % 24;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }

        }
    }
}
