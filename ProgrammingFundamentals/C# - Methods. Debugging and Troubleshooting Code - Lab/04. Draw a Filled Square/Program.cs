using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            printFigure(n);
        }
        /// <summary>
        /// Draw a filled square
        /// </summary>
        /// <param name="n">shows the size of the figure(height=n, width = n*2)</param>
        private static void printFigure(int n)
        {
            printTopBottom(n);
            bodyTimes(n);
            printTopBottom(n);
        }

        static void printTopBottom(int n)
        {
            string topBottom = new string('-', n * 2);
            Console.WriteLine(topBottom);
        }

        static void printBody(int n)
        {
            string body = string.Empty;
            body += "-";
            for (int i = 1; i <= n-1; i++)
            {
                body += @"\/";
                
            }
            body += "-";
            Console.WriteLine(body);
        }

        static void bodyTimes(int n)
        {
            for (int i = 1; i <= n-2; i++)
            {
                printBody(n);
            }
        }
    }
}
