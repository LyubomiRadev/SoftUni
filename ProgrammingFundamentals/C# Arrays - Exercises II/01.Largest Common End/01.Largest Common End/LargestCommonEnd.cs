using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            var arrayOne = Console.ReadLine().Split();
            var arrayTwo = Console.ReadLine().Split();

            int leftCount = 0;
            int rightCount = 0;
            int smallestArray = Math.Min(arrayOne.Length, arrayTwo.Length);
            for (int i = 0; i < smallestArray; i++)
            {
                if(arrayOne[i] == arrayTwo[i])
                {
                    leftCount++;
                }

                if(arrayOne[arrayOne.Length - 1 - i] == arrayTwo[arrayTwo.Length - 1 - i])
                {
                    rightCount++;
                }
            }

            Console.WriteLine(Math.Max(leftCount, rightCount));
        }
    }
}
