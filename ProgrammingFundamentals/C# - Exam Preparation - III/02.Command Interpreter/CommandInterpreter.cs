using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _02.Command_Interpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            var collection = Regex.Split(Console.ReadLine(), @"\s+").ToList();
            var input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                var command = input[0];



                if (command.ToLower() == "reverse")
                {

                    long index = long.Parse(input[2]);
                    long count = long.Parse(input[4]);

                    if (index > collection.Count || index < 0 || count <= 0 || index + count > collection.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");


                    }
                    else
                    {
                        var getNumbers = collection.GetRange((int)index, (int)count).ToList();
                        getNumbers.Reverse();
                        collection.RemoveRange(int.Parse(index.ToString()), int.Parse(count.ToString()));
                        collection.InsertRange(int.Parse(index.ToString()), getNumbers);

                    }
                }

                else if (command.ToLower() == "sort")
                {
                    var index = long.Parse(input[2]);
                    var count = long.Parse(input[4]);

                    if (index > collection.Count || index < 0 || count <= 0 || index + count > collection.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        var rangeForSorting = collection.GetRange(int.Parse(index.ToString()), int.Parse(count.ToString())).ToList();
                        rangeForSorting.Sort();
                        //collection.RemoveRange(int.Parse(index.ToString()), int.Parse(count.ToString()));
                        //collection.InsertRange(int.Parse(index.ToString()), getNumbers);
                        for (int i = 0; i < count; i++)
                        {
                            collection[(int)(i + index)] = rangeForSorting[i];
                        }
                    }

                }

                else if (command.ToLower() == "rollleft")
                {
                    var count = long.Parse(input[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");

                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            collection.Insert(collection.Count(), collection[0]);
                            collection.RemoveAt(0);
                        }
                    }


                }

                else if (command.ToLower() == "rollright")
                {
                    var count = long.Parse(input[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");

                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            collection.Insert(0, collection[collection.Count() - 1]);
                            collection.RemoveAt(collection.Count() - 1);
                        }
                    }


                }

                else if (command.ToLower() != "reverse" || command.ToLower() == "sort" || command.ToLower() == "rollleft" || command.ToLower() == "rollright")
                {
                    Console.WriteLine("Ivalid input parameters.");
                }

                input = Console.ReadLine().Split();
            }

            Console.WriteLine("[{0}]", string.Join(", ", collection));
        }
    }
}
