using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rotate = int.Parse(Console.ReadLine());

            var rotatedArray = new int[input.Length];

            for (int i = 0; i < rotate; i++)
            {
                RotateInput(input);
                for (int j = 0; j < input.Length; j++)
                {
                    rotatedArray[j] += input[j];
                }
            }
            Console.WriteLine(string.Join(" ",rotatedArray));

        }

        private static void RotateInput(int[] array)
        {
            var lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastElement;
        }
    }
}
