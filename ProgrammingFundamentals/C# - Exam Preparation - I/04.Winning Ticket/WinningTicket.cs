using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            var input = Regex.Split(Console.ReadLine(), @"\s*,\s*").Select(ticket => ticket.Trim()).ToArray();
            var validTickets = new List<string>();

           foreach(var ticket in input)
            {
                bool validTicket = ticket.Length == 20;
                if (validTicket)
                {
                    var leftside = ticket.Substring(0,10);
                    var rightSide = ticket.Substring(10);
                    
                    var leftSideLength = SequanceLength(leftside);
                    var rightSideLength = SequanceLength(rightSide);
                    if(leftSideLength.Length >=6 && rightSideLength.Length >=6 && leftSideLength[0] == rightSideLength[0])
                    {
                        var min = Math.Min(leftSideLength.Length, rightSideLength.Length);
                        var symbol = leftSideLength[0];
                        if(min == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {min}{symbol} Jackpot!");
                        }                       
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {min}{symbol} ");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                   
                }
                else
                {
                    Console.WriteLine($"invalid ticket");
                }
            }
        }

        private static string SequanceLength(string input)
        {
            var symbol =""+ input[0];
            var maxLength = 0;

            for (int i = 0; i < input.Length-1; i++)
            {
                
                var coutn = 1;
                while(i + coutn<input.Length && input[i+coutn] == input[i])
                {
                    coutn++;
                    if (coutn > maxLength)
                    {
                        maxLength = coutn;
                        symbol = input.Substring(i, coutn);
                    }
                }
                
            }
            return symbol;
        }
    }
}
