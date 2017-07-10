using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Max_Index_Of_Increasing_Numbers
{
    class MaxIndexOfIncreasingNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentStart = 0;
            int currentSequanceLength = 1;
            int bestStart = 0;
            int bestSequanceLengt = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] > numbers[i - 1]){
                    currentSequanceLength++;
                    
                    if(currentSequanceLength > bestSequanceLengt)
                    {
                        bestSequanceLengt = currentSequanceLength;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentSequanceLength = 1;
                }
            }
            for (int i = bestStart; i < bestStart + bestSequanceLengt; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
