using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();
            int appearance = 1;
            var output = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(i == numbers.Count - 1)
                {
                    Console.WriteLine($"{numbers[i]} -> {appearance}");
                    break;
                }
                
                if(numbers[i] == numbers[i + 1])
                {
                    
                    appearance++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {appearance}");
                    
                    appearance = 1;
                }
            }
        }
    }
}
