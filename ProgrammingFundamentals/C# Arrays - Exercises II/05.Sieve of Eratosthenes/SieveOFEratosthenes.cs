using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sieve_of_Eratosthenes
{
    class SieveOFEratosthenes
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var primes = new bool[input + 1];

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            primes[0] = primes[1] = false;

            for (int i = 2; i <= input; i++)
            {
                if (!primes[i])
                {
                    continue;
                }
                Console.Write(i + " ");
                for (int j = i*2; j <= input; j+=i)
                {
                    primes[j] = false;
                }
            }
            Console.WriteLine();

        }
    }
}
