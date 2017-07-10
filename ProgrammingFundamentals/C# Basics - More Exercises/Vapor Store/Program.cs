using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Vapor_Store
{
    class Program
    {
        static void Main()
        {
            double startingBallance = double.Parse(Console.ReadLine());
            double gamePrice = 0;
            double spendMoney = 0;

            for (int i = 1; i < 5000; i++)
            {

                string gameName = Console.ReadLine();

                if (gameName.ToLower() == "game time")
                {
                    Console.WriteLine($"Total spent: ${spendMoney:F2}. Remaining: ${startingBallance:F2}");
                    return;
                }
                else if (startingBallance < 0)
                {
                    Console.WriteLine("Out of money");
                    return;
                }

                else
                {
                    switch (gameName)
                    {
                        case "OutFall 4":
                        case "RoverWatch Origins Edition":
                           
                                gamePrice = 39.99;
                                if (gamePrice > startingBallance)
                                {
                                    Console.WriteLine("Too Expensive");
                                    break;
                                }
                                startingBallance -= gamePrice;
                                spendMoney += gamePrice;
                                Console.WriteLine($"Bought {gameName}");                            
                            break;
                        case "CS: OG":
                           
                            gamePrice = 15.99;
                            if (gamePrice > startingBallance)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            startingBallance -= gamePrice;
                            spendMoney += gamePrice;
                            Console.WriteLine($"Bought {gameName}");
                            break;
                        case "Zplinter Zell":                           
                            gamePrice = 19.99;
                            if (gamePrice > startingBallance)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            startingBallance -= gamePrice;
                            spendMoney += gamePrice;
                            Console.WriteLine($"Bought {gameName}");
                            break;
                        case "Honored 2":                           
                            gamePrice = 59.99;
                            if (gamePrice > startingBallance)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            startingBallance -= gamePrice;
                            spendMoney += gamePrice;
                            Console.WriteLine($"Bought {gameName}");
                            break;
                        case "RoverWatch":
                            
                            gamePrice = 29.99;
                            if (gamePrice > startingBallance)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            startingBallance -= gamePrice;
                            spendMoney += gamePrice;
                            Console.WriteLine($"Bought {gameName}");                            
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            break;
                    }
                }

            }
        }
    }
}
