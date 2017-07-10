using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_Sentences_by_Keyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            var searchWord = Console.ReadLine();
            var input = Console.ReadLine().Split(new char[] { '.', '?', '!' });
            var sentances = new List<string>();

            Regex pattern = new Regex($"[^.!?;]*(({searchWord}\\W)|(\\W{searchWord}\\W))[^.!?;]*");
            for (int i = 0; i < input.Length; i++)
            {
                if (pattern.Match(input[i].Trim()).Success)
                {
                    sentances.Add(input[i].Trim());
                }
            }

            foreach(var sentance in sentances)
            {
                Console.WriteLine(sentance);
            }
        }
    }
}
