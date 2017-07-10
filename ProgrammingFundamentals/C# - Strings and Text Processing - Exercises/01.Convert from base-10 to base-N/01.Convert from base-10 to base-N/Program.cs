using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToList();

            long n = input[0];
            long number = input[1];

            string result = String.Empty;
            long reminder = 0;

            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    reminder = number % n;
                    number = number / n;
                    result = reminder.ToString() + result;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
