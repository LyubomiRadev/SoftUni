using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonPower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            var count = 0;
            double pokemonCurrentPower = pokemonPower;
            var halfPower = pokemonPower * 0.5;

            while (pokemonCurrentPower >= distance)
            {
                pokemonCurrentPower -= distance;
                count++;

                bool isInt = halfPower == (int)halfPower;
                if (pokemonCurrentPower == halfPower && isInt && exhaustion != 0)
                {
                   
                        pokemonCurrentPower = int.Parse(pokemonCurrentPower.ToString()) / exhaustion;
                }
            }

            Console.WriteLine(pokemonCurrentPower);
            Console.WriteLine(count);
        }
    }
}
