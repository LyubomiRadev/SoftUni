using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class LargestThreeNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers = numbers.OrderByDescending(num => num).ToList();
            var largestThree = numbers.Take(3);
           
            Console.WriteLine(string.Join(" ",largestThree));
        }
    }
}
