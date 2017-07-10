using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Morse_Code
{
    class MorseCode
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            var output = string.Empty;
            var zero = @"0";
            var doubleZero = @"00+";
            var one = @"1";
            var doubleOne = @"11+";
            

            foreach(var item in input)
            {
                MatchCollection onlyZeros = Regex.Matches(item, zero);
                var sum = 0;
                var add = 0;
                sum += onlyZeros.Count*3;
                
                MatchCollection moreZeros = Regex.Matches(item, doubleZero);
               foreach(Match nill in moreZeros)
                {
                    sum += nill.Length;
                }
                

                MatchCollection justOne = Regex.Matches(item, one);
                
                sum += justOne.Count*5;
                

                MatchCollection moreOnes = Regex.Matches(item, doubleOne);
                foreach(Match ones in moreOnes)
                {
                    sum += ones.Length;
                }




                output += (char)(sum);
               
            }

            Console.WriteLine(output);
        }
    }
}
