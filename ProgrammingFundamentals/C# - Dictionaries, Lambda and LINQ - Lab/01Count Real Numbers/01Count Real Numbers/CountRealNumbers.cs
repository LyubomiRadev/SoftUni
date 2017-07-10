using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Count_Real_Numbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            var counts = new SortedDictionary<double, int>();

            foreach(var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            foreach(var number in counts.Keys)
            {
                Console.WriteLine($"{number} -> {counts[number]} times");
            }
        }
    }
}
