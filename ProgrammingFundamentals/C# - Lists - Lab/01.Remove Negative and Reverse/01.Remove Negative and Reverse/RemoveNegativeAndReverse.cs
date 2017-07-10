using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negative_and_Reverse
{
    class RemoveNegativeAndReverse
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var positiveNumbers = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] > 0)
                {
                    positiveNumbers.Add((int)numbers[i]);
                }
            }

            positiveNumbers.Reverse();
            
            if(positiveNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (int positiveNumber in positiveNumbers)
                {
                    Console.Write($"{positiveNumber} ");
                }
            }
            Console.WriteLine();
        }
    }
}
