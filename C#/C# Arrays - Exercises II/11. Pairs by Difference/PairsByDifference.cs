using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Pairs_by_Difference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int differance = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i+1; k < numbers.Length; k++)
                {
                    int max = Math.Max(numbers[i], numbers[k]);
                    int min = Math.Min(numbers[i], numbers[k]);

                    if (max - min == differance)
                    {
                        count++;
                    }
                }
                
            }
            Console.WriteLine(count);

        }
    }
}
