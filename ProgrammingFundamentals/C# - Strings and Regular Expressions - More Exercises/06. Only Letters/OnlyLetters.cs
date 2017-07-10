using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _06.Only_Letters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //var pattern = @"(?<number>\d+)?(?<letter>[a-zA-z]?)";
            //Regex separator = new Regex(pattern);

            //MatchCollection check = Regex.Matches(input, pattern);

            //foreach(Match item in check)
            //{
            //    var number = item.Groups["number"].Value;
            //    var letter = item.Groups["letter"].Value;

            //    for (int i = 0; i < input.Length; i++)
            //    {
            //        if(input[i] == number)
            //    }
            //}

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (Char.IsNumber(input[i]))
                {
                    if (Char.IsNumber(input[i + 1]))
                    {
                        input = input.Remove(i, 1);
                        i--;
                    }
                    else
                    {
                        input = input.Replace(input[i], input[i + 1]);
                    }
                }
            }

            Console.WriteLine(input);
        }
    }
}
