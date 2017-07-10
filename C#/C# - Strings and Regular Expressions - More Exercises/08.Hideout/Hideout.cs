using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08.Hideout
{
    class Hideout
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            bool stop = true;
            

            while (stop)
            {
                var clues = Console.ReadLine();
                var symbol = clues[0];
                var amount = int.Parse(clues[2].ToString());
                for (int i = 0; i < line.Count(); i++)
                {
                    var count = 1;
                    if (line[i] == symbol)
                    {

                        for (int j = i; j < line.Count() + 1; j++)
                        {

                            if (line[j] == line[j + 1])
                            {
                                count++;

                            }
                            else
                            {
                                break;
                            }

                        }
                        if (count >= amount)
                        {
                            Console.WriteLine($"Hideout found at index {i} and it is with size {count}!");
                            return;
                            stop = false; 
                        }

                    }
                }
            }

        }
    }
}
