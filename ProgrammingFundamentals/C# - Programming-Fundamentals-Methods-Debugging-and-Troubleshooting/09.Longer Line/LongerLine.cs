using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Line
{
    class LongerLine
    {
        static void Main(string[] args)
        {
            double lineOneX1 = double.Parse(Console.ReadLine());
            double lineOneY1 = double.Parse(Console.ReadLine());
            double lineOneX2 = double.Parse(Console.ReadLine());         
            double lineOneY2 = double.Parse(Console.ReadLine());
            double lineTwoX1 = double.Parse(Console.ReadLine());    
            double lineTwoY1 = double.Parse(Console.ReadLine());
            double lineTwoX2 = double.Parse(Console.ReadLine());
            double lineTwoY2 = double.Parse(Console.ReadLine());

            double resultLineOne = Math.Abs(lineOneX1) + Math.Abs(lineOneY1);
            double resultLineTwo = Math.Abs(lineTwoX1) + Math.Abs(lineTwoY1);

            if(resultLineOne > resultLineTwo || resultLineOne== resultLineTwo)
            {
                Console.WriteLine($"({lineOneX1}, {lineOneY1})({lineOneX2}, {lineOneY2})");
            }
            else
            {
                Console.WriteLine($"({lineTwoX1}, {lineTwoY1})({lineTwoX2}, {lineTwoY2})");
            }
        }
    }
}
