using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Merge_Files
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            var textOne = File.ReadAllLines("input1.txt");
            var textTwo = File.ReadAllLines("input2.txt");

            //var numbersOne = textOne.Select(int.Parse).ToList();
            //var numberTwo = textTwo.Select(int.Parse).ToList();
            var sorted = new List<string>();
            for (int i = 0; i < textOne.Length; i++)
            {
                sorted.Add(textOne[i]);
                
            }
            for (int j = 0; j < textTwo.Length; j++)
            {
                sorted.Add(textTwo[j]);

            }
            sorted.Sort();
            File.WriteAllLines("output.txt", sorted);
        }
    }
}
