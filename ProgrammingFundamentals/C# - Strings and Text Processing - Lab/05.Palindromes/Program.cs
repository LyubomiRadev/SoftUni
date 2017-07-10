using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var palindromes = Console.ReadLine().Split(new char[] { ',', '!', '.', ' ', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var output = new List<string>();

            foreach(var palindorome in palindromes)
            {
                if (input.Contains(palindorome))
                {
                    output.Add(palindorome);
                }
            }

            output.Sort();
            Console.WriteLine(string.Join(", ", output));

        }
    }
}
