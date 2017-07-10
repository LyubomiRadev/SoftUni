using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_Of_Week
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
