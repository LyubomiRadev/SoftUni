using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_One
{
    class Program
    {
        static void Main(string[] args)
        {

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            if (day.ToLower() == "weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    ticketPrice = 12;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 18;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day.ToLower() == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    ticketPrice = 15;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age > 18 && age <= 64)
                {
                    ticketPrice = 20;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day.ToLower() == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    ticketPrice = 5;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age >= 18 && age <= 64)
                {
                    ticketPrice = 12;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else if (age > 64 && age <= 122)
                {
                    ticketPrice = 10;
                    Console.WriteLine($"{ticketPrice}$");
                }
                else
                {
                    Console.WriteLine("Error!");
                }

            }


        }
    }
}
