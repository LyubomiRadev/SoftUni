using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { ',', ',', ':',';','(',')','"','\'','[',']','/','!','?',' '}).ToList();

            var sortedWords = input.Where(word => word != "").Where(word => word.Length<5).OrderBy(w =>w).Distinct();

            Console.WriteLine(string.Join(", ",sortedWords));
        }
    }
}
