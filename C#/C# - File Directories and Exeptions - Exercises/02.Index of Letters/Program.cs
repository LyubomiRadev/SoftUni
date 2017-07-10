using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("input.txt");
            byte[] value = Encoding.ASCII.GetBytes(input);
            var indexes = new List<string>();

            for (int i = 0; i < value.Length; i++)
            {
                indexes.Add((char)value[i] + " -> " + (value[i] - 97));
            }
           
                File.AppendAllLines("output.txt", indexes.Select(a => a.ToString()).ToArray());
            

           // Console.WriteLine(string.Join(" ",indexes));
        }
    }
}
