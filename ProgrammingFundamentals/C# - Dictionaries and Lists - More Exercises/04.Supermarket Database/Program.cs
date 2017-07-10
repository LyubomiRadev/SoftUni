using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var supermarketDatabases = new Dictionary<string, Dictionary<double, int>>();
            bool canContinue = true;
            double total = 0;

            while (canContinue)
            {
                var input = Console.ReadLine().Split().ToList();

                if(input[0].ToLower() == "stocked")
                {
                    break;
                }
                string product = input[0];
                double productPrice = double.Parse(input[1]);
                int productQuantity = int.Parse(input[2]);
                if (!supermarketDatabases.ContainsKey(product))
                {
                    supermarketDatabases.Add(product, new Dictionary<double, int>());
                }

                if (!supermarketDatabases[product].ContainsKey(productPrice))
                {
                    supermarketDatabases[product].Add(productPrice, productQuantity);
                }
                supermarketDatabases[product][productPrice] = productQuantity;

            }

            foreach(var item in supermarketDatabases)
            {
                var name = item.Key;
                var price = item.Value.Keys.Last();
                var quantity = item.Value.Values.Sum();
                var productTotal = price * quantity;
                total += productTotal;

                Console.WriteLine($"{name}: ${price:F2} * {quantity} = ${productTotal:F2}");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${total:F2}");
        }
    }
}
