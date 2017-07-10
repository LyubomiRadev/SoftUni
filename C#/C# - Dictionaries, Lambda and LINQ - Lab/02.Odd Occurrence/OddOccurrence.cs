using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrence
{
    class OddOccurrence
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');

            var results = new Dictionary<string, int>();

            foreach(var word in words)
            {
                if (results.ContainsKey(word))
                {
                    results[word]++;
                }
                else
                {
                    results[word] = 1;
                }
            }

            var output = new List<string>();

            foreach(var result in results)
            {
                
                if(result.Value %2 == 1)
                {
                    output.Add(result.Key);
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
