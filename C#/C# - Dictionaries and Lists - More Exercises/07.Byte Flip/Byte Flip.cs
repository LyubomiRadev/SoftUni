using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().ToList();
            var trying = new List<string>();
            for (int i = 0; i < input.Count; i++)
            {
                if(input[i].Length != 2)
                {
                    input.Remove(input[i]);
                }
                
            }
            var reversed = input.Select(word => new String(word.Reverse().ToArray())).ToList();

            reversed.Reverse();
            var output = new List<char>();

            for (int i = 0; i < reversed.Count; i++)
            {
                var val = Convert.ToInt32(reversed[i], 16);
                output.Add((char)val);
            }


            Console.WriteLine(string.Join("", output));

            
        }
        
    }
}
