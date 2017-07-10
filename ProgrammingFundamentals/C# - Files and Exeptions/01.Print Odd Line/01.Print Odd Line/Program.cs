using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _01.Print_Odd_Line
{
    class PrintOddLine

    {
        static void Main(string[] args)
        {
            var file = File.ReadAllLines("..\\..\\..\\..\\..\\..\\softuni.txt");

            for (int i = 0; i < file.Length; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(file[i]);
                }
            }

        }
    }
}
