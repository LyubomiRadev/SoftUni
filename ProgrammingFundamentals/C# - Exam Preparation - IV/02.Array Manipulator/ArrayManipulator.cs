using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var command = Console.ReadLine().Split();

            while (command[0].ToLower() != "end")
            {
                if (command[0].ToLower() == "exchange")
                {
                    var index = int.Parse(command[1]);
                    if (index < 0 || index >= input.Count)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        var newList = new List<string>();

                        newList.AddRange(input.Take(index + 1));
                        input.RemoveRange(0, index + 1);
                        input.AddRange(newList);
                    }
                }
                if (command[0].ToLower() == "max")
                {
                    int typeMax = command[1] == "even" ? 0 : 1;

                    var maxElement = input.Select(int.Parse).Where(e => e % 2 == typeMax).ToArray();
                    if (!maxElement.Any())
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ",input.LastIndexOf(maxElement.Max().ToString())));
                    }
                }
                if (command[0].ToLower() == "min")
                {
                    int typeMin = command[1] == "even" ? 0 : 1;


                    var minElement = input.Select(int.Parse).Where(a => a % 2 == typeMin).ToArray();
                    if (!minElement.Any())
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ",input.LastIndexOf(minElement.Min().ToString())));
                    }
                }

                if (command[0] == "first")
                {                    
                    if (int.Parse(command[1]) > input.Count())
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        var firstCount = command[2] == "even" ? 0 : 1;
                        var count = int.Parse(command[1]);
                        string[] firstEven = null;
                        var firstArray = input.Where(a => int.Parse(a) % 2 == firstCount).ToArray().Take(count);
                        if (firstArray.Any())
                        {
                            Console.WriteLine("[{0}]", string.Join(", ", firstArray));
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                }
                if(command[0] == "last")
                {
                    if(int.Parse(command[1]) > input.Count())
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        var firstCount = command[2] == "even" ? 0 : 1;
                        var count = int.Parse(command[1]);
                        string[] firstEven = null;
                        var firstArray = input.Where(a => int.Parse(a) % 2 == firstCount).ToArray().Reverse().Take(count);
                        if (firstArray.Any())
                        {
                            Console.WriteLine("[{0}]",string.Join(", ", firstArray));
                        }
                        else
                        {
                            Console.WriteLine("[]");
                        }
                    }
                }
                    command = Console.ReadLine().Split();
            }

            Console.WriteLine("[{0}]",string.Join(", ",input));
        }
    }
}

