using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Master_Number
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            IsMasterNumber(number);
        }

        private static void IsMasterNumber(double number)
        {
            IsSymmetric(number);
            IsDevidedBySeven(number);
            HoldsEvenDigit( number);
        }

        private static bool HoldsEvenDigi(double number)
        {
            double lastDigit = number % 10;
            bool even = true;
            if (lastDigit % 2 == 0)
            {
                 even; 
            }
            else
            {
            number /= 10;
            }

            return even;
        }
    }
}
