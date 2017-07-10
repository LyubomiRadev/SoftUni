using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            printTriangle(n);

        }

        private static void printTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                printLine(i);
            }

            for (int i = n-1; i >= 1 ; i--)
            {
                printLine(i);
            }
        }

        private static void printLine(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
