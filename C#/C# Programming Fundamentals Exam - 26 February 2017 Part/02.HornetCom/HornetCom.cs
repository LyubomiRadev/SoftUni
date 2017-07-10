using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.HornetCom
{
    class HornetCom
    {
        static void Main(string[] args)
        {

            var broadCasts = new Dictionary<string, List<string>>();
            var privateMessages = new Dictionary<string, List<string>>();
            string privateMessageQ = @"^(?<Q1>[0-9]+)\s+<->\s+(?<Q2>[a-zA-z0-9]+)$";
            string broadcastMessageQ = @"^(?<Q1>[^0-9]+)\s+<->\s+(?<Q2>[a-zA-z0-9]+)$";

            var privateRegex = new Regex(privateMessageQ);
            var broadcastRegex = new Regex(broadcastMessageQ);
            var queries = Console.ReadLine();
            while (true)
            {

                if (queries.ToLower() == "hornet is green")
                {
                    break;
                }

                IsPrivate(privateMessages, privateRegex, queries);
                IsBroadcast(broadCasts, broadcastRegex, queries);

                queries = Console.ReadLine();
            }

            PrintBroadcastMessages(broadCasts);
            PrintPrivateMessages(privateMessages);
        }

        private static void PrintPrivateMessages(Dictionary<string, List<string>> privateMessages)
        {
            Console.WriteLine("Messages:");
            if (!privateMessages.Any())
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var prMess in privateMessages)
                {
                    var recepeintData = prMess.Key;
                    var messages = prMess.Value;
                    foreach (var message in messages)
                    {
                        Console.WriteLine($"{recepeintData} -> {message}");
                    }

                }
            }
        }

        private static void PrintBroadcastMessages(Dictionary<string, List<string>> broadCasts)
        {
            Console.WriteLine("Broadcasts:");
            if (!broadCasts.Any())
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadCasts)
                {
                    var message = broadcast.Key;
                    var frequancies = broadcast.Value;
                    foreach (var frequancy in frequancies)
                    {
                        Console.WriteLine($"{frequancy} -> {message}");
                    }
                }
            }
        }

        private static void IsBroadcast(Dictionary<string, List<string>> broadCasts, Regex broadcastRegex, string queries)
        {
            Match isBroadcast = broadcastRegex.Match(queries);

            if (isBroadcast.Success)
            {
                var q1 = isBroadcast.Groups["Q1"].Value;
                var q2 = isBroadcast.Groups["Q2"].Value;
                var reverseQ2 = string.Empty;
                foreach (var letter in q2)
                {
                    if (Char.IsUpper(letter))
                    {
                        reverseQ2 += letter.ToString().ToLower();
                    }
                    else if (char.IsLower(letter))
                    {
                        reverseQ2 += letter.ToString().ToUpper();
                    }
                    else
                    {
                        reverseQ2 += letter;
                    }

                }

                if (!broadCasts.ContainsKey(q1))
                {
                    broadCasts[q1] = new List<string>();
                }

                broadCasts[q1].Add(reverseQ2);
            }
        }

        private static void IsPrivate(Dictionary<string, List<string>> privateMessages, Regex privateRegex, string queries)
        {
            Match isPrivate = privateRegex.Match(queries);

            if (isPrivate.Success)
            {
                var q1 = isPrivate.Groups["Q1"].Value.Reverse();
                var q2 = isPrivate.Groups["Q2"].Value;
                var q1Rev = string.Empty;
                foreach (var @char in q1)
                {
                    q1Rev += @char;
                }

                if (!privateMessages.ContainsKey(q1Rev))
                {
                    privateMessages[q1Rev] = new List<string>();
                }
                privateMessages[q1Rev].Add(q2);

            }
        }
    }
}
