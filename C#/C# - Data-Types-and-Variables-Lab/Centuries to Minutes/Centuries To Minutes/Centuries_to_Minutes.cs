using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Minutes
{
    class Centuries_to_Minutes
    {
        static void Main(string[] args)
        {
            Console.Write("Centuries = ");
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            decimal days = (int)(years * 365.2422);
            decimal hours = 24 * days;
            decimal minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
