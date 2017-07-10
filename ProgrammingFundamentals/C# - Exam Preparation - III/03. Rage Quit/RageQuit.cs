using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    class RageQuit
    {
        static void Main(string[] args)
        {

            //?< disk >[A - Z]):\\(?< mainfolder >[\w] +)\\?(?< addfolder >\w +)?\\(?< filename > ([\w] +\.)*\s *\w +)(?< extention >\.[\w]+);(?<filesize>\d+)

            var input = Console.ReadLine().ToUpper();         
            var output = new StringBuilder();

            
            var pattern = @"(?<word>\D+)(?<numbers>\d+)";
            var collection = Regex.Matches(input, pattern);

            foreach(Match item in collection)
            {
                var num = int.Parse(item.Groups["numbers"].Value);
                var word = item.Groups["word"].Value.ToString();

                for (int i = 0; i < num; i++)
                {
                    output.Append(word);
                }
            }
            var uniqueSymbols = output.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(string.Join("",output.ToString()));
            }
        }
    }

