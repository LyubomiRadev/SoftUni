using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class MaxSequencOfEqualElements
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bestSequance = 0;
            int currentBestSequance = 0;
            int currentBestNumber = 0;
            var sequanceNumbers = new List<int>();
            int bestNumber = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
              foreach(int number in numbers)
                {
                    if(numbers[i] == number)
                    {
                        currentBestSequance++;
                        currentBestNumber = numbers[i];
                        
                        if (currentBestSequance > bestSequance)
                        {
                            bestSequance = currentBestSequance;
                            bestNumber = currentBestNumber;
                        }                        
                    }
                    else
                    {
                        currentBestSequance = 0;
                        
                    }
              }

            }
            for (int i = 1; i <= bestSequance; i++)
            {
                sequanceNumbers.Add(bestNumber);
            }

            Console.WriteLine(string.Join(" ", sequanceNumbers));
        }
    }
}
