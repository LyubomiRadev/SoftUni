using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Censore_Word
{
    class CensoreWord
    {
        static void Main(string[] args)
        {
            var censoredWord = Console.ReadLine();

            string pattern = $"(?<word>{censoredWord})";
            
            var input = Console.ReadLine();

            var matches = Regex.Replace(input, pattern, new string('*', censoredWord.Count()));

            Console.WriteLine(matches);
        }
    }
}
