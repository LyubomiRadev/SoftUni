using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Rotate_and_Sum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();
            int k = input.Length / 4;

            int[] firstNumbers = input.Take(k).Reverse().ToArray();
            int[] lastNumbers = input.Reverse().Take(k).ToArray();
            int[] top = firstNumbers.Concat(lastNumbers).ToArray();
            var sum = new int[top.Length];

            for (int i = 0; i < k*2; i++)
            {
                sum[i] = top[i] + input[i + k];
            }

            Console.WriteLine(string.Join(" ",sum));
            //var backNumbers = new int[input.Length/4];
            //var frontNumbers = new int[input.Length / 4];
            //var sum = new int[input.Length / 2];
            //for (int i = 0; i < frontNumbers.Length; i++)
            //{
            //    frontNumbers[i] = input[i];
            //}

            //Array.Reverse(frontNumbers);
            //var coppy = new int[input.Length];
            //Array.Copy(input, coppy,input.Length);
            //Array.Reverse(coppy);
            //int backLenght = backNumbers.Length;

            //for (int i = 0; i < backNumbers.Length; i++)
            //{
            //    backNumbers[i] = coppy[i];
            //}

            //for (int i = 0; i < sum.Length/2; i++)
            //{
            //    sum[i] += frontNumbers[i] + input[i + backNumbers.Length ];
            //}

            //for (int i = 0; i < sum.Length/2; i++)
            //{
            //    sum[i + 2] = backNumbers[i] + coppy[i + backLenght+1];
            //    backLenght--;
            //}

            //Console.WriteLine(string.Join(" ",sum));
            
        }

       
    }
}
