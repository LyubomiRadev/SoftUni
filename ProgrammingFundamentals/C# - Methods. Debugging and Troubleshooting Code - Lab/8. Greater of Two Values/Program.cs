using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        int value1 = int.Parse(Console.ReadLine());
                        int value2 = int.Parse(Console.ReadLine());
                        int result = Max(value1, value2);
                        Console.WriteLine(result);
                        break;
                    }
                case "char":
                    {
                        char value1 = char.Parse(Console.ReadLine());
                        char value2 = char.Parse(Console.ReadLine());
                        char result = Max(value1, value2);
                        Console.WriteLine(result);
                        break;
                    }
                case "string":
                    {
                        string value1 = Console.ReadLine();
                        string value2 = Console.ReadLine();
                        string result = Max(value1, value2);
                        Console.WriteLine(result);
                        break;
                    }
                default:
                    Console.WriteLine("Please put in a correct format."); 
                    break;
            }

           
        }

        private static string Max(string value1, string value2)
        {
            if(value1.CompareTo(value2) > 0)
            {
                return value1;
            }
            return value2;
        }

        private static int Max(int value1, int value2)
        {
            int result = Math.Max(value1, value2);
            return result;
        }

        private static char Max(char value1, char value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            return value2;
        }

    }
}
