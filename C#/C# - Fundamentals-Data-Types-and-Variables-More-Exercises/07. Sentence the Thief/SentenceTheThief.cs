using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
{
    class SentenceTheThief
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            long numberOfIDs = long.Parse(Console.ReadLine());

            long maxValue = long.MinValue;
            double overFlow = double.MinValue;
            double sentance = 0;
            double result = 0;
            switch (numeralType)
            {
                case "sbyte":
                    for (int i = 0; i < numberOfIDs; i++)
                    {

                        long id = long.Parse(Console.ReadLine());
                        bool isByte = (sbyte.MinValue <= id) && (id <= sbyte.MaxValue);

                        if (isByte && maxValue <= id)
                        {
                            maxValue = id;
                        }

                        if (overFlow < maxValue)
                        {
                            overFlow = maxValue;
                        }

                        if (overFlow < 0)
                        {
                            result = (Math.Abs(overFlow) / 128);
                            sentance = Math.Ceiling(result);
                        }
                        else
                        {
                            result = Math.Abs(overFlow) / 127;
                            sentance = Math.Ceiling(result);
                        }

                    }

                    if(sentance == 1)
                    {
                        Console.WriteLine($"Prisoner with id {overFlow} is sentenced to {sentance} year");
                    }
                    else
                    {
                        Console.WriteLine($"Prisoner with id {overFlow} is sentenced to {sentance} years");

                    }
                    break;
                case "int":
                    for (int i = 0; i < numberOfIDs; i++)
                    {

                        long id = long.Parse(Console.ReadLine());
                        bool isByte = (int.MinValue <= id) && (id <= int.MaxValue);

                        if (isByte && maxValue <= id)
                        {
                            maxValue = id;
                        }

                        if (overFlow < id)
                        {
                            overFlow = id;
                        }

                        if (overFlow < 0)
                        {
                            result = (Math.Abs(overFlow) / 128);
                           
                            sentance = Math.Ceiling(result);
                        }
                        else
                        {
                            result = Math.Abs(overFlow) / 127;
                            sentance = Math.Ceiling(result);
                        }

                       

                    }

                    if (sentance == 1)
                    {
                        Console.WriteLine($"Prisoner with id {overFlow} is sentenced to {sentance} year");
                    }
                    else
                    {
                        Console.WriteLine($"Prisoner with id {overFlow} is sentenced to {sentance} years");

                    }
                    break;
                case "long":
                    for (int i = 0; i < numberOfIDs; i++)
                    {

                        long id = long.Parse(Console.ReadLine());
                        bool isByte = (long.MinValue <= id) && (id <= long.MaxValue);

                        if (isByte && maxValue <= id)
                        {
                            maxValue = id;
                        }

                        if (overFlow < id)
                        {
                            overFlow = id;
                        }

                        if (overFlow < 0)
                        {
                            result = (Math.Abs(overFlow) / 128);
                            sentance = Math.Ceiling(result);
                        }
                        else
                        {
                            result = overFlow / 127;
                            sentance = Math.Ceiling(result);
                        }
                      

                    }

                    if (sentance == 1)
                    {
                        Console.WriteLine($"Prisoner with id {overFlow} is sentenced to {sentance} year");
                    }
                    else
                    {
                        Console.WriteLine($"Prisoner with id {overFlow} is sentenced to {sentance} years");

                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid numeral type!");
                    break;

            }

        }
    }
}
