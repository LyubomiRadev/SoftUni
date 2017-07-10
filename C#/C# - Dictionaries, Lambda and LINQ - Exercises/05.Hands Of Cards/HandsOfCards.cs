using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_Of_Cards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            var finalPlayersStats = new Dictionary<string, HashSet<int>>();
            //var currentPlayersStats = new Dictionary<string, List<int>>();
            
            bool canContinue = true;

            while (canContinue)
            {
                var playerInfo = Console.ReadLine().Split(':').ToList();
                string playerName = playerInfo[0];

                if (playerName.ToLower() == "joker")
                {
                    break;
                }

                string[] cards = playerInfo[1].Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string cardPower = "";
                string cardType = "";

                for (int i = 0; i < cards.Length; i++)
                {
                     cardPower = cards[i].Substring(0, cards[i].Length - 1).Trim();
                     cardType = cards[i].Substring(cards[i].Length -1).Trim();

                    CalculateCardPower(cardPower);
                    CalculateCardTypePower(cardType);
                    int totalCardPower = CalculateCardPower(cardPower) * CalculateCardTypePower(cardType);

                    if (!finalPlayersStats.ContainsKey(playerName))
                    {
                        finalPlayersStats[playerName] = new HashSet<int>();
                    }

                    finalPlayersStats[playerName].Add(totalCardPower);
                }     
                
            }

            //foreach (var item in finalPlayersStats)
            //{
            //    if(!currentPlayersStats.ContainsKey(item.Key))
            //    {
            //        currentPlayersStats[item.Key] = new List<int>();
            //    }

            //    currentPlayersStats[item.Key] = item.Value.Distinct().ToList();
            //}

            // PrintResults(currentPlayersStats);
            PrintResults(finalPlayersStats);

        }

        private static void PrintResults(Dictionary<string, HashSet<int>> finalPlayersStats)
        {
            foreach (var kvp in finalPlayersStats)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Sum()}");
            }
        }

        private static int CalculateCardTypePower(string cardType)
        {
            int sum = 0;
            switch (cardType)
            {
                case "S":
                    sum = 4;
                    break;
                case "H":
                    sum = 3;
                    break;
                case "D":
                    sum = 2;
                    break;
                case "C":
                    sum = 1;
                    break;
            }
            return sum;
        }

        private static int CalculateCardPower(string cardPower)
        {
            int sum = 0;
           
                switch (cardPower[0])
                {
                    case 'J':
                        sum += 11;
                        break;
                    case 'Q':
                        sum += 12;
                        break;
                    case 'K':
                        sum += 13;
                        break;
                    case 'A':
                        sum += 14;
                        break;
                    default:
                        sum += int.Parse(cardPower);
                        break;
                }
            
            return sum;
        }


        //първо вземаме имената и ги записваме в лист
        //взимаме двойките(карта,боя)
        //разделяме ги по char и ги умножаваме
        //записваме ги в листа където сме записали имената;проверяваме дали името го има, ако го има увеличаваме резултата, в противен случай го записваме


    }
}
