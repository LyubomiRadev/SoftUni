using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string unit = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double result = 0;

            switch (unit.ToLower())
            {
                case "miles":
                    result = amount * 1.6;
                    Console.WriteLine($"{amount} {unit} = {result:F2} kilometers");
                    break;
                case "inches":
                    result = amount * 2.54;
                    Console.WriteLine($"{amount} {unit} = {result:F2} centimeters");
                    break;
                case "feet":
                    result = amount * 30;
                    Console.WriteLine($"{amount} {unit} = {result:F2} centimeters");
                    break;
                case "yards":
                    result = amount * 0.91;
                    Console.WriteLine($"{amount} {unit} = {result:F2} meters");
                    break;
                case "gallons":
                    result = amount * 3.8;
                    Console.WriteLine($"{amount} {unit} = {result:F2} liters");
                    break;
            }
        }
    }
}
