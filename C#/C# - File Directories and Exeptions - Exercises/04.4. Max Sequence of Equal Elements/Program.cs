using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04._4.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();
           
            int bestSequance = 0;
            int bestNumber = 0;

            int count = 1;

            for (int i = 0; i < input.Count(); i++)
            {

                for (int j = i + 1; j < input.Count(); j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;

                    }
                }
                if (count > bestSequance)
                {
                    bestSequance = count;
                    bestNumber = input[i];
                    count = 1;
                }

            }
            string[] result = new string[bestSequance];
            for (int i = 0; i < bestSequance; i++)
            {
                result[i] += bestNumber;
            }
            File.WriteAllText("output.txt", string.Join(" ", result));
        }
    }
}
