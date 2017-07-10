using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02._.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int baseN = int.Parse(input[0]);
            char[] number = input[1].ToCharArray();
            BigInteger result = new BigInteger(0);

            for (int i = number.Length-1,n=0; i >= 0; i--,n++)
            {
                BigInteger num = new BigInteger(char.GetNumericValue(number[n]));
                BigInteger sum = BigInteger.Multiply(num, BigInteger.Pow(new BigInteger(baseN),i));
                result += sum;
            }

            Console.WriteLine(result);
        }
    }
}
