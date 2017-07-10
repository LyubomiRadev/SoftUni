using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class CenterPoint   a
    {
        static void Main(string[] args)
        {

            double pointOneA = double.Parse(Console.ReadLine());
            double pointOneB = double.Parse(Console.ReadLine());
            double pointTwoA = double.Parse(Console.ReadLine());
            double pointTwoB = double.Parse(Console.ReadLine());

            double resultPointOne = Math.Abs(pointOneA )+ Math.Abs(pointOneB);
            double resultPointTwo = Math.Abs(pointTwoA )+ Math.Abs(pointTwoB);

            if (resultPointOne < resultPointTwo || resultPointOne == resultPointTwo)
            {
                Console.WriteLine($"({pointOneA}, {pointOneB}) ");
            }
            else
            {
                Console.WriteLine($"({pointTwoA}, {pointTwoB})");
            }


        }
    }
}
