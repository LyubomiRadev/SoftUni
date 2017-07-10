using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Karate_Strings
{
    class KarateStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray().Select(a => a.ToString()).ToList();

            var strength = 0;

            for (int i = 1; i < input.Count; i++)
            {
                var word = input[i - 1];
                string punch = input[i];

                try
                {
                    if(char.IsDigit(char.Parse(punch)) && word == ">")
                    {
                        strength += int.Parse(punch.ToString());

                        while(input[i]!=">" && strength>0 )
                        {
                            input.RemoveAt(i);
                            strength--;

                        }
                    }
                }
                catch
                {
                    Console.WriteLine();
                }

            }

            Console.WriteLine(string.Join("",input));


        }
    }
}
