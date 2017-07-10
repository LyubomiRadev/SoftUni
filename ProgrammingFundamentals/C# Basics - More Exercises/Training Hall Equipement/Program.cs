using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Hall_Equipement
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int items = int.Parse(Console.ReadLine());
            double subtotal = 0;

            for (int i = 1; i <= items; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());

                if (itemCount > 1)
                {
                    itemName = itemName + "s";
                }
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");

                subtotal += itemPrice * itemCount;
            }

            double moneyNeeded = subtotal - budget;
            double moneyLeft = budget - subtotal;
            if (subtotal > budget)
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Not enough. We need ${moneyNeeded:F2} more.");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${subtotal:F2}");
                Console.WriteLine($"Money left: ${ moneyLeft:F2}");
            }

        }
    }
}
