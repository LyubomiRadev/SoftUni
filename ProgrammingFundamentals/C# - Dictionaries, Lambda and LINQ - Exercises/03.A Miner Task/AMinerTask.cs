using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, long>();
            bool canContinue = true;

            while (canContinue)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    ShowAllRecourses(resources);
                    break;
                }
                else
                {
                    long quantity = long.Parse(Console.ReadLine());
                    AddToRecourses(resources, resource, quantity);
                }
            }
        }

        private static void ShowAllRecourses(Dictionary<string, long> resources)
        {
            foreach(var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        private static void AddToRecourses(Dictionary<string, long> resources, string resource, long quantity)
        {
            if (resources.ContainsKey(resource))
            {
                resources[resource] += quantity;
            }
            else
            {
                resources.Add(resource, quantity);
            }
        }
    }
}
