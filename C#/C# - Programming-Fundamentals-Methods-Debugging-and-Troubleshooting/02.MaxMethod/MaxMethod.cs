using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            GetMaxNumber(numberOne, numberTwo, numberThree);
        }

        private static void GetMaxNumber(int numberOne, int numberTwo, int numberThree)
        {
            if(numberOne > numberTwo && numberOne> numberThree)
            {
                Console.WriteLine(numberOne);
            }
            else if(numberTwo > numberOne && numberTwo > numberThree)
            {
                Console.WriteLine(numberTwo);
            }
            else
            {
                Console.WriteLine(numberThree);
            }
        }
    }
}
