using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.Most_Frequant_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("input.txt").Split().Select(int.Parse).ToList();

            //int bestNumber = 0;
            //int currentBestNumber = 0;
            //int bestCout = 0;
            //int count = 0;
            //for (int i = 0; i < input.Count; i++)
            //{

            //    for (int j = 1; j < input.Count; j++)
            //    {

            //        if(input[i] == input[j])
            //        {
            //            count++;
            //        }

            //    }
            //    if (count > bestCout)
            //    {
            //        bestCout = count;
            //        bestNumber = input[i];
            //    }
            //    count = 0;


            //}
            //File.WriteAllText("output.txt", bestNumber.ToString());
           
            
            var numbersCount = new Dictionary<int, int>();
            for (int i = 0; i < input.Count; i++)
            {
                if (!numbersCount.ContainsKey(input[i]))
                {
                    numbersCount.Add(input[i], 0);
                }
                else
                {
                    numbersCount[input[i]] += 1;
                }
            }

            var bestNumber = numbersCount.OrderByDescending(number => number.Value).Take(1);


           foreach(var item in bestNumber)
            {
                File.WriteAllText("output.txt", item.Value.ToString());
            }
        }
    }
}
