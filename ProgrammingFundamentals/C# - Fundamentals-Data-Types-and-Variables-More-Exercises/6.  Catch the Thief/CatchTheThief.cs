using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Catch_the_Thief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            long numberOfIDs = long.Parse(Console.ReadLine());

            long maxValue = long.MinValue;
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

                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid numeral type!");
                    break;

            }
            

            Console.WriteLine(maxValue);
        }
    }
}
