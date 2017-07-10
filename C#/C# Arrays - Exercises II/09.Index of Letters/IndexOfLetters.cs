using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            char[] chars = new char[26];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] =(char)(97+i);
                Console.WriteLine(chars[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + " ->  "+Array.IndexOf(chars,input[i]));
            }

            
        }
    }
}
