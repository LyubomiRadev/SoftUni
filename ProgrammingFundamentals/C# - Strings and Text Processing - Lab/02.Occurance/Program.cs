using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Occurance
{
    class Occurance
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var word = Console.ReadLine();
            var count = 0;

            //първо решение

            var lastIndex = 0;
            //while (true)
            //{
            //    var index = input.ToLower().IndexOf(word.ToLower(), lastIndex + 1);
            //        if(index != -1)
            //    {
            //        count++;
            //        lastIndex = index;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //второ решение

            while((lastIndex= input.ToLower().IndexOf(word.ToLower(),lastIndex + 1)) != -1)
            {
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
