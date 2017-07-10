using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList() ;

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                int reversed = 0;
                while(numbers[i] > 0)
                {
                    int number = numbers[i] % 10;
                    reversed = reversed * 10 + number;
                    numbers[i] = numbers[i] / 10;
                }
                sum += reversed;
            }

            Console.WriteLine(sum);
        }

        
    }
}
