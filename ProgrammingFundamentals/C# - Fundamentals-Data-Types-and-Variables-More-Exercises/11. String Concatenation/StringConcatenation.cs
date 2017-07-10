using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {

            string separator = Console.ReadLine();
            string logic = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            var result = new List<string>();

           
            switch (logic)
            {
                case "even":
                    for (int i = 1; i <= count; i++)
                    {
                        string input = Console.ReadLine();
                        
                        if(i % 2 == 0)
                        {
                            result.Add(input);
                        }
                    }

                    result.Insert(1,separator);
                    break;

                 case "odd":
                    for (int i = 1; i <= count; i++)
                    {
                        string input = Console.ReadLine();
                        
                        if(i % 2 != 0)
                        {
                           result.Add(input);
                        }
                    }
                    result.Insert(1,separator);
                    break;
            }

           foreach(string blqblq in result)
            {
                Console.Write(blqblq);
            }
            Console.WriteLine();
        }
    }
}
