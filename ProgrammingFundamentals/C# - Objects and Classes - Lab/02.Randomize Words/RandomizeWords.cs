using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            for (int i = 0; i < input.Length; i++)
            {
                var randomize = new Random();
                var currentWord = input[i];
                int randomPosition = randomize.Next(0,input.Length);
                var temp = input[randomPosition];

                input[randomPosition] = currentWord ;
                input[i] = temp;
                               
            }

            foreach(var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
