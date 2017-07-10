using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Compare_Char_Arrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] wordOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] wordTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int shorterOfTwo = Math.Min(wordOne.Length, wordTwo.Length);

            for (int i = 0; i < shorterOfTwo; i++)
            {
               if(wordOne.Length == wordTwo.Length && wordOne[i] == wordTwo[i])
                {
                    Console.WriteLine(wordOne);
                    Console.WriteLine(wordTwo);
                }
               else if(wordOne[i] > wordTwo[i])
                {
                    Console.WriteLine(wordTwo);
                    Console.WriteLine(wordOne);
                    break;
                }
               else if(wordOne[i] < wordTwo[i])
                {
                   Console.WriteLine(wordOne);
                   Console.WriteLine(wordTwo);
                    break;
                }
               else if(wordOne.Length != wordTwo.Length && wordOne[i] == wordTwo[i])
                {
                    Console.WriteLine(wordOne.Length > wordTwo.Length ? wordTwo:wordOne);
                    Console.WriteLine(wordOne.Length < wordTwo.Length ? wordTwo:wordOne);
                    break;
                }
                
            }
        }
    }
}
