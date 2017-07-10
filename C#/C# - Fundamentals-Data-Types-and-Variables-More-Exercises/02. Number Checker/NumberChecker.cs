using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Number_Checker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            long output = 0;
            if (long.TryParse(number, out output))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
