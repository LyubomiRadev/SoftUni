using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var wordOne = input[0].ToCharArray();
            var wordTwo = input[1].ToCharArray();

            var output = MultiplyCharacters(wordOne, wordTwo);

            Console.WriteLine(output);
        }

        private static long MultiplyCharacters(char[] wordOne, char[] wordTwo)
        {
            int stop = Math.Min(wordOne.Count(), wordTwo.Count());
            
            long result = 0;
            for (int i = 0; i < stop; i++)
            {
                result += (int)wordOne[i] * (int)wordTwo[i];
            }
            if (stop == 1)
            {
                stop = 2;
            }
            if (wordOne.Count() > wordTwo.Count())
            {
                var bigger = Math.Max(wordOne.Count(), wordTwo.Count());
                for (int i = stop - 1; i < bigger; i++)
                {
                    result += (int)wordOne[i];
                }
            }
            if (wordOne.Count() < wordTwo.Count())
            {
                var bigger = Math.Max(wordOne.Count(), wordTwo.Count());
                for (int i = stop - 1; i < bigger; i++)
                {
                    result += (int)wordTwo[i];
                }
            }

            return result;
        }

    }
}
