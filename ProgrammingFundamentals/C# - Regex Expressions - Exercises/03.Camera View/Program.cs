using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"\|<");

            var coordinates = Console.ReadLine().Split().Select(int.Parse).ToList();
            var initialInput = Console.ReadLine();
            var text = initialInput.Substring(initialInput.IndexOf("|<") + 2, initialInput.Length - initialInput.IndexOf("|<") - 2);
            var listOfItems = new List<string>();
            var elements = pattern.Split(text);

            for (int i = 0; i < elements.Length; i++)
            {
                if(elements[i].Length - coordinates[0] > coordinates[1])
                {
                    listOfItems.Add(elements[i].Substring(coordinates[0], coordinates[1]));
                }
                else
                {
                    listOfItems.Add(elements[i].Substring(coordinates[0], elements[i].Length - coordinates[0]));
                }
            }

            Console.WriteLine(string.Join(", ", listOfItems));
        }
    }
}
