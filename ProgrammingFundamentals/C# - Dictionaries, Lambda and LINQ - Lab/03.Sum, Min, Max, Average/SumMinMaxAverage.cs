using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum__Min__Max__Average
{
    class SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var numbers = new List<double>();
            for (int i = 0; i < input; i++)
            {
                double number= double.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            double min = numbers.Min();
            double max = numbers.Max();
            double sum = numbers.Sum();
            double average = numbers.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
