using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_List
{
    class AppendList
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');

            var result = new List<int>();

            for (int i = input.Length-1; i >= 0 ; i--)
            {
                int[] numbers = input[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                result.AddRange(numbers);
            }
            

            Console.WriteLine(string.Join(" ", result));

           
        }
    }
}
