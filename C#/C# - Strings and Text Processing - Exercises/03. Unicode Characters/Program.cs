using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray();
            StringBuilder output = new StringBuilder();

            //foreach(var letter in input)
            //{
            //    output.Append("\\u");
            //    output.Append(String.Format("{0:x4}", (int)letter));
            //}

            for (int i = 0  ; i < input.Count(); i++)
            {
                output.Append("\\u" + ((int)input[i]).ToString("X4"));
            }

            Console.WriteLine(output);
        }
    }
}
