using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            number = Math.Abs(number);

            int result = MultiplyOddEvens(number);
            Console.WriteLine(result);
        }

        private static int MultiplyOddEvens(int number)
        {
            
           int evenSum= GetEvenSum(number);
           int oddSum= GetOddSum(number);
            int result = evenSum*oddSum;
            return result ;
        }

        private static int GetEvenSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int GetOddSum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
