using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.List_Manipulator
{
    class ListManipulator
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                var command = Console.ReadLine().Split(' ').ToList();
                

                switch (command[0].ToLower())
                {
                    case "add":
                        int index = int.Parse(command[1]);
                        int element = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;
                    case "addmany":
                        var elementsToAdd = new List<int>();
                        for (int j = 2; j < command.Count; j++)
                        {
                            elementsToAdd.Add(int.Parse(command[j]));                           
                        }
                        numbers.InsertRange(int.Parse(command[1]), elementsToAdd);
                        break;
                    case "contains":
                        bool checking = false;
                        int numbersIndex = 0;
                        for (int j = 0; j < numbers.Count; j++)
                        {
                            if (int.Parse(command[1]) == numbers[j])
                            {
                                checking = true;
                                numbersIndex = j;
                                break;
                            }
                                                      
                        }
                        if (checking)
                        {
                            Console.WriteLine(numbersIndex);
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        
                        break;
                    case "remove":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;
                    case "shift":
                        for (int k = 0; k < int.Parse(command[1]); k++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                        break;
                    case "sumpairs":
                        var sumArray = new List<int>();
                        
                        for (int p = 0; p < numbers.Count-1; p+=2)
                        {
                            int sum = 0;
                            sum = numbers[p] + numbers[p + 1];
                            sumArray.Add(sum);
                            
                        }
                        if (numbers.Count % 2 != 0)
                        {
                            sumArray.Add(numbers[numbers.Count - 1]);

                        }
                        numbers.Clear();
                        numbers = sumArray.ToList();
                        break;
                    case "print":
                        Console.WriteLine("[{0}]", string.Join(", ", numbers));
                        break;

                }


            }


        }

       
    }
}   
   
