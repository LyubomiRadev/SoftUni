using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _12.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (BigInteger i = 1; i <= n; i++)
            {
                result *= i;
                
            }
            Console.WriteLine(result);
        }
    }
}
