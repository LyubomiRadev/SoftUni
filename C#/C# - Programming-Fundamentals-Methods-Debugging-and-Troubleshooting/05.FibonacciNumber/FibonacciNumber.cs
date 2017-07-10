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
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine(PrintFibonaciNumber(i));
            }
        }

        private static int PrintFibonaciNumber(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
            }
            return a;
        }
    }
}
