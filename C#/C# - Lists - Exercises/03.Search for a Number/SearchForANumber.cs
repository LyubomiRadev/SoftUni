using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var newCollection = new List<int>();

            for (int i = 0; i < commands[0]; i++)
            {
                newCollection.Add(numbers[i]);
            }

            
             newCollection.RemoveRange(0, commands[1]);
            bool check = false;

            for (int i = 0; i < newCollection.Count; i++)
            {
                if(commands[2] == newCollection[i])
                {
                    check = true;
                    break;
                }
                
            }
            if (check)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
            //Console.WriteLine(string.Join(" ", newCollection));

        }
    }
}
