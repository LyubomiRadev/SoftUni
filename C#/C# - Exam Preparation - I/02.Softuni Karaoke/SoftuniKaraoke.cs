using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Softuni_Karaoke
{
    class SoftuniKaraoke
    {
        static void Main(string[] args)
        {

            var participants = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries );

            var songs = Regex.Split(Console.ReadLine(), @"\s*,\s*").ToList();
            
            var dataBase = new Dictionary<string, List<string>>();
            var participent = Regex.Split(Console.ReadLine(), @"\s*,\s*").ToList();
            
            
           
            while(participent[0].ToLower() != "dawn")
            {
                var singer = participent[0];
                var song = participent[1].Trim();
                var award = participent[2].Trim();

                if (participants.Contains(singer) && songs.Contains(song))
                {
                    if (!dataBase.ContainsKey(singer))
                    {
                        dataBase[singer] = new List<string>();
                    }
                    dataBase[singer].Add(award);
                }
                participent = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            var sortedData = dataBase.OrderByDescending(singer => singer.Value.Count()).ThenBy(singer => singer.Key).ToArray();
          
            if(sortedData.Count() == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var item in sortedData)
                {
                    var name = item.Key;
                    var awards = item.Value.Distinct().OrderBy(a => a);
                    var awardsCount = awards.Count();

                    Console.WriteLine($"{name}: {awardsCount} awards");

                    foreach (var award in awards)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            
        }
    }
}
