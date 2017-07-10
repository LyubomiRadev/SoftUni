using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string property = Console.ReadLine();
            double result = 0;
            switch (property.ToLower())
            {
                case "face":
                    result = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
                    Console.WriteLine("{0:F2}", result);
                    break;
                case "space":
                    result = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
                    Console.WriteLine("{0:F2}", result);
                    break;
                case "volume":
                    result = Math.Pow(cubeSide, 3);
                    Console.WriteLine("{0:F2}", result);
                    break;
                case "area":
                    result = 6 * Math.Pow(cubeSide, 2);
                    Console.WriteLine("{0:F2}", result);
                    break;
            }
        }
    }
}
