using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_List
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                var command = Console.ReadLine().Split(' ').ToList();
                var output = new List<int>();

                switch (command[0].ToLower())
                {
                    case "delete":
                        int deletedItem = int.Parse(command[1]);
                        for (int k = 0; k < numbers.Count; k++)
                        {
                            if (numbers[k]  ==  deletedItem)
                            {
                                numbers.Remove(numbers[k]);
                                k--;
                            }
                        }
                        break;
                    case "insert":
                        int item = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, item);
                        break;
                    case "odd":
                        for (int k = 0; k < numbers.Count; k++)
                        {
                            if(numbers[k] %2 == 0)
                            {
                                numbers.Remove(numbers[k]);
                                k--;
                            }                            
                        }
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "even":
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            if (numbers[j] % 2 != 0)
                            {
                                numbers.Remove(numbers[j]);
                                j--;
                            }                            
                        }
                        Console.WriteLine(string.Join(" ", numbers));
                        break; ;
                }
            }

           
        }
    }
}
