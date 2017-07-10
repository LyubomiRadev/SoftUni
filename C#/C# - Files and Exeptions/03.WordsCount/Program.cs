using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace _03.WordsCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var fileToRead = File.ReadAllText("input.txt").ToLower().Split(new char[] { '\n','\r',' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var wordsEncounter = new Dictionary<string, int>();
            var wordsToCount = Console.ReadLine().Split().ToList();


            for (int i = 0; i < fileToRead.Length; i++)
            {
                for (int j = 0; j < wordsToCount.Count; j++)
                {
                    if (fileToRead[i] == wordsToCount[j])
                    {
                        if (!wordsEncounter.ContainsKey(wordsToCount[j]))
                        {
                            wordsEncounter.Add(wordsToCount[j], 0);
                        }
                        wordsEncounter[wordsToCount[j]] += 1;
                    }
                }
                
            }

            if (!File.Exists("output.txt"))
            {
                File.Create("output.txt");
            }

            

            
            var example = new List<string>();
            foreach (var kvp in wordsEncounter.OrderBy(a => a.Value))
            {
                var word = kvp.Key;
                var count = kvp.Value;
                string line = $"{word} -> {count}";
                example.Add(line);
                
            }

            File.WriteAllLines("output.txt", example);
        }
    }
}
