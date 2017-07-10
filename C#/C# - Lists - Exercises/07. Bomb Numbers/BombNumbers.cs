using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == bomb[0])
                {
                    int left = Math.Max(i - bomb[1],0);
                    int right = Math.Min(i + bomb[1], numbers.Count - 1);

                    int range = right - left + 1;

                    numbers.RemoveRange(left, range);
                    i = 0;

                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
