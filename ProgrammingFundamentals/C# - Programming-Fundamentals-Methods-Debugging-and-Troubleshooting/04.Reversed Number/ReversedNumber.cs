using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Reversed_Number
{
    class ReversedNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            PrintReversedNumber(input);


        }

        private static void PrintReversedNumber(string number)
        {
            string reversedInput = new string(number.ToString().Reverse().ToArray());
            decimal result = 0;
            if (decimal.TryParse(reversedInput, out result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
