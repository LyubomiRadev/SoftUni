using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Most_Frequent_Number
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentFrequentSequance = 1;
            int currentFrequentNumber = 0;
            int bestFrequentSequence = 1;
            int bestFrequentNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
               foreach(int number in numbers)
                {
                    if(numbers[i] == number)
                    {
                        
                        currentFrequentSequance++;
                        if (bestFrequentSequence < currentFrequentSequance)
                        {
                            bestFrequentSequence = currentFrequentSequance;
                            bestFrequentNumber = numbers[i];
                        }
                    }
                    else
                    {
                        currentFrequentSequance = 1;
                        currentFrequentNumber = numbers[i];
                    }
                }
            }

            Console.WriteLine(bestFrequentNumber);
        }
    }
}
