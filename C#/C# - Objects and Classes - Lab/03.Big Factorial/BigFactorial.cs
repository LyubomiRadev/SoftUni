using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Big_Factorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = input; i >= 2; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
