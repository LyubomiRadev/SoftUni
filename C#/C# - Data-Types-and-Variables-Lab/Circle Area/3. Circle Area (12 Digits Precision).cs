using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Circle_Area
{
    class Circle_Area
{
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double result = Math.PI * r * r;
            Console.WriteLine($"{result:F12}");
        }
    }
}
