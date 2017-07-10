using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumber
{
    class FibonacciNumber
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());

            if (IsPrimary(input))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }

        private static bool IsPrimary(long number)
        {
            if(number == 0)
            {
                return false;
            }
            if(number == 1)
            {
                return false;
            }
            if(number == 2)
            {
                return true;
            }

            
            bool result = true;
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {

                if (number % i == 0)
                {
                    result =  false;
                    break;
                }
 
            }
            return result;

        }
    }
}