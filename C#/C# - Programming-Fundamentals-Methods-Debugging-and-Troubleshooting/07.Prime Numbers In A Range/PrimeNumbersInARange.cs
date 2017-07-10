using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Prime_Numbers_In_A_Range
{
    class PrimeNumbersInARange
    {
        private static double i;

        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            FindPrimeNumbers(start, end);

        }

        private static void FindPrimeNumbers(int start, int end)
        {
            var results = new List<int>();
            bool prime = true;
            for(int currentNumber = start; currentNumber <= end; currentNumber++)
            {
                for (int divider = 2 ; divider <= Math.Sqrt(currentNumber) ; divider++)
                {

                    if (currentNumber % divider  == 0)
                    {
                        prime = false;
                        break;                        
                    }

                }
                if (prime && currentNumber > 2)
                {
                    results.Add(currentNumber);
                }

                prime = true;
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
