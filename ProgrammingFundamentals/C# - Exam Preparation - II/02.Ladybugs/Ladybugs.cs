using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugsIndexes = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();


            var ladybugs = new int[fieldSize];
            var command = Console.ReadLine().Split()
                .ToArray();

            foreach (var index in ladybugsIndexes)
            {
                if (index >= 0 && index < fieldSize)
                {
                    ladybugs[index] = 1;
                }
            }


            while (command[0].ToLower() != "end")
            {
                var index = long.Parse(command[0]);
                var movementLength = long.Parse(command[2]);

                if (index < 0 || index >= fieldSize)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                if (ladybugs[index] == 0)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }



                if (command[1] == "right")
                {
                    if (index + movementLength >= fieldSize || index + movementLength < 0)
                    {
                        ladybugs[index] = 0;
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else
                    {
                        long flyingDistance = index + movementLength;
                        ladybugs[index] = 0;
                        while (index < fieldSize && index >= 0 && flyingDistance < fieldSize && flyingDistance >= 0)
                        {
                            if (ladybugs[flyingDistance] == 0)
                            {
                                ladybugs[flyingDistance] = 1;
                                break;
                            }
                            else
                            {
                                flyingDistance += movementLength;
                            }
                        }
                    }
                }
                else if (command[1] == "left")
                {
                    if (index - movementLength >= fieldSize || movementLength - index < 0)
                    {
                        ladybugs[index] = 0;
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else
                    {
                        var flyingDistance = index - movementLength;
                        ladybugs[index] = 0;

                        while (index < fieldSize && index >= 0 && flyingDistance < fieldSize && flyingDistance >= 0)
                        {
                            if (ladybugs[flyingDistance] == 0)
                            {
                                ladybugs[flyingDistance] = 1;
                                break;
                            }
                            else
                            {
                                flyingDistance -= movementLength;
                            }
                        }

                    }

                }


                command = Console.ReadLine().Split()
                .ToArray();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }
    }
}
