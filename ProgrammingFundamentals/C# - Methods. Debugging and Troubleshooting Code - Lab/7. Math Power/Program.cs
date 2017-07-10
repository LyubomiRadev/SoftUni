using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

           double result = powResult(number, pow);

            Console.WriteLine(result);

        }

        private static double powResult(double number, double pow)
        {
            double result = Math.Pow(number, pow);
            return result;
        }
    }
}
