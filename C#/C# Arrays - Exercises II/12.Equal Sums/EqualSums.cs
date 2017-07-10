using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Sums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumOnTheLeft = 0;
            int sumOnTheRight = 0;
            int numberIndex = 0;
            bool areEqual = (sumOnTheLeft == sumOnTheRight);


            if (input.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            if (input.Length == 2)
            {
                Console.WriteLine("no");
                return;
            }

            for (int i = 1; i < input.Length - 1; i++)
            {
                for (int k = i - 1; k >= 0; k--)
                {
                    sumOnTheLeft += input[k];

                }
                for (int j = i + 1; j < input.Length; j++)
                {
                    sumOnTheRight += input[j];
                    if(sumOnTheLeft < sumOnTheRight)
                    {
                        break;
                    }

                }

                if (sumOnTheLeft == sumOnTheRight)
                {
                    numberIndex = i;
                }
                else
                {
                    sumOnTheLeft = 0;
                    sumOnTheRight = 0;
                }

            }
            Console.WriteLine(numberIndex);

            //if (areEqual)
            //{
            //    Console.WriteLine(numberIndex);
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

        }
    }
}
