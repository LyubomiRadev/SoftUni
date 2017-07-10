using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Email_Me
{
    class EmailMe
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();

            string pattern = @"(?<beggining>.*)@(?<end>.*)";
            Regex extract = new Regex(pattern);
            var matches = extract.Matches(email);

           foreach(Match item in matches)
            {
                var beggining = item.Groups["beggining"].Value;
                var end = item.Groups["end"].Value;
                var wordOneSum = 0;
                var wordTwoSum = 0;
                char[] wordOne= beggining.ToCharArray();
                char[] wordTwo = end.ToCharArray();

                for (int i = 0; i < wordOne.Count(); i++)
                {
                    wordOneSum += wordOne[i];
                }

                for (int i = 0; i < wordTwo.Count(); i++)
                {
                    wordTwoSum += wordTwo[i];
                }

                var differance = wordOneSum - wordTwoSum;

                if (differance >= 0)
                {
                    Console.WriteLine("Call her!");
                }
                else
                {
                    Console.WriteLine("She is not the one.");
                }
            }
        }
    }
}
