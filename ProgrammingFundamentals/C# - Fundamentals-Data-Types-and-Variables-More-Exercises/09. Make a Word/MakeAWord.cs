using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_a_Word
{
    class MakeAWord
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string sentance = "";
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                sentance += word;
            }

            Console.WriteLine($"The word is: {sentance}");
        }
    }
}
