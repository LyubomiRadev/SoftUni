using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPerKilo = decimal.Parse(Console.ReadLine());

            decimal neededDesserts = Math.Ceiling(guests / 6.0M);
            decimal singleCakePrice = (2 * bananaPrice) + (4 * eggPrice) + (0.2M * berriesPerKilo);
            decimal allCakesPrice = singleCakePrice * neededDesserts;
           
            if(allCakesPrice <= budget)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {allCakesPrice:F2}lv.");
            }
            else
            {
                decimal neededMoney = allCakesPrice - budget;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
