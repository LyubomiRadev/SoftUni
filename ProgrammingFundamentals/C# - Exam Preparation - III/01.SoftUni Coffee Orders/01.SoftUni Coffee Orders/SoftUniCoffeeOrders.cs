using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace _01.SoftUni_Coffee_Orders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var ordersCount = int.Parse(Console.ReadLine());
            decimal totalSum = 0;
            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsules = int.Parse(Console.ReadLine());

                var daysInMonth = System.DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                var orderPrice = daysInMonth * pricePerCapsule * capsules;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

                totalSum += orderPrice;
            }

            Console.WriteLine($"Total: ${totalSum:F2}");
        }
    }
}
