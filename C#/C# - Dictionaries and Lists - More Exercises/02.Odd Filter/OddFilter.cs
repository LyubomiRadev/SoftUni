using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            input.RemoveAll(number => number % 2 != 0);
            int averageSum = (int)input.Average();
           

            for (int i = 0; i < input.Count; i++)
            {
                if(input[i] > averageSum)
                {
                    input[i] += 1;
                }
                else
                {
                    input[i] -= 1;
                }
            }

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
