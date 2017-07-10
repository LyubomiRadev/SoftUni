using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_of_Chars
{
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int numberOfChars = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 0; i < numberOfChars; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int value = (int)input;
                result += value;
            }
            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
