using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Add_Index_In_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllLines("..\\..\\..\\..\\..\\softuni.txt");
            var numberdLines = file.Select((line, index) => $"{index + 1}.{line}");

            File.WriteAllLines($"..\\..\\..\\..\\..\\output.txt", numberdLines);
        }
    }
}
