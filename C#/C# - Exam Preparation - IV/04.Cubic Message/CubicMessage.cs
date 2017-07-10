using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Cubic_Message
{
    class CubicMessage
    {
        static void Main(string[] args)
        {

            var pattern = @"^(?<frontNum>\d+)(?<word>[a-zA-z]+)(?<backNum>[^a-zA-z]*)$";
            var regex = new Regex(pattern);

            while (true)
            {
                var encryptedMessage = Console.ReadLine();

                if (encryptedMessage.ToLower() == "over!")
                {
                    break;
                }
              
                var messageMatch = regex.Match(encryptedMessage);

                if (!messageMatch.Success)
                {
                    continue;
                }

                string frontNum = messageMatch.Groups["frontNum"].Value;
                string word = messageMatch.Groups["word"].Value;
                string backNum = messageMatch.Groups["backNum"].Value;

                var m = int.Parse(Console.ReadLine());

                if (word.Length != m)
                {
                    continue;
                }

                // First Solution
                //string messageCode = new string((frontNum + backNum)
                //    .Where(char.IsDigit)
                //    .Select(@char => int.Parse(@char.ToString()))
                //    .Select(index => index >= 0 && index < word.Length ? word[index] : ' ')
                //    .ToArray());
                //Console.WriteLine($"{word} == {messageCode}");

                //Second Solution
                var output = new StringBuilder();
                output.Append($"{word} == ");
                foreach (var item in frontNum + backNum)
                {
                    if (!Char.IsDigit(item))
                    {
                        continue;
                    }
                    var index = int.Parse(item.ToString());

                    bool isIndex = index >= 0 && index < word.Length;

                    if (isIndex)
                    {
                        output.Append(word[index]);
                    }
                    else
                    {
                        output.Append(' ');
                    }
                }

                Console.WriteLine(output);
            }

        }
    }
}
