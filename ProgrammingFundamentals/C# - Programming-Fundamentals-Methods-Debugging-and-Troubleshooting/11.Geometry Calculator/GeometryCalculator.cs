using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            switch (figure.ToLower())
            {
                case "triangle":
                    {
                        double side = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        double result = (side * height)*0.5;
                        Console.WriteLine("{0:F2}", result);
                        break;
                    }
                case "square":
                    { 
                        double side = double.Parse(Console.ReadLine());
                        double result = Math.Pow(side,2);
                        Console.WriteLine("{0:F2}", result);
                        break;
                    }
                case "rectangle":
                    {
                        double width = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        double result = width * height;
                        Console.WriteLine("{0:F2}", result);
                        break;
                    }
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        double result = Math.PI *Math.Pow(radius,2);
                        Console.WriteLine("{0:F2}", result);
                        break;
                    }
            }

        }
    }
}
