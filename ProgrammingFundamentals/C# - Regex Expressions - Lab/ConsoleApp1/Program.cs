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

            var input = Console.ReadLine();

            while (input != "end"){
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replacePattern = @"[URL href=$1]$2[/URL]";
                string output = Regex.Replace(input, pattern, replacePattern);

                Console.WriteLine(output);

                input = Console.ReadLine();
            }


        }
    }
}
