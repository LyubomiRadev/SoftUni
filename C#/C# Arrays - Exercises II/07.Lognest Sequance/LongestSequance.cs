using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lognest_Sequance
{
    class LongestSequance
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentSequenceLength = 1;
            int currentStartingIndex = 0;
            int bestSequence = 1;
            int bestStartingIndex = 0;
            
            
            for (int i =1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    currentSequenceLength++;

                    if (bestSequence < currentSequenceLength)
                    {
                        bestSequence = currentSequenceLength;
                        bestStartingIndex = currentStartingIndex;
                    }
                }
                else
                {
                    currentStartingIndex = i;
                    currentSequenceLength = 1;

                }
                
            }

            for (int i = bestStartingIndex; i <= bestStartingIndex + bestSequence; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
