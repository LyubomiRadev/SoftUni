using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class FoldAndSum

    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numbersToTake = input.Length / 4;

            int[] firstTwoNumbers = input.Take(numbersToTake).Reverse().ToArray();
            int[] lastTwoNumbers = input.Reverse().Take(numbersToTake).ToArray();
            int[] middleNumbers = input.Skip(numbersToTake).Take(numbersToTake*2).ToArray();
            int[] firstRow = firstTwoNumbers.Concat(lastTwoNumbers).ToArray();
            //var sum = firstRow.Select((x, index) => x + middleNumbers[index]);
            var sum = new List<int>();

            for (int i = 0; i < middleNumbers.Length; i++)
            {
                sum.Add(firstRow[i] + middleNumbers[i]);
            }
            Console.WriteLine(string.Join(" ", sum));
            
        }
    }
}
