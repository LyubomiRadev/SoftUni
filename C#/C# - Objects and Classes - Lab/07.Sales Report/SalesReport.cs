using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class SalesReport
    {
        public class Sales
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

            public static Sales Parse(string input)
            {
                var saleParts = input.Split();
                return new Sales
                {
                    Town = saleParts[0],
                    Product = saleParts[1],
                    Price = decimal.Parse(saleParts[2]),
                    Quantity = decimal.Parse(saleParts[3])

                };
            }
        }
        static void Main(string[] args)
        {
            var totalInputs = int.Parse(Console.ReadLine());
            var results = new SortedDictionary<string, decimal>();
            for (int i = 0; i < totalInputs; i++)
            {
                var input = Console.ReadLine();
                var currentSale = Sales.Parse(input);

                if (!results.ContainsKey(currentSale.Town))
                {
                    results[currentSale.Town] = 0;
                }
                
                    results[currentSale.Town] += currentSale.Quantity * currentSale.Price;
                
            }

            foreach(var result in results)
            {
                var town = result.Key;
                var totalSales = result.Value;
                Console.WriteLine($"{town} -> {totalSales:F2}");
            }
        }

       
    }
}
