using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_Between_Points
{
    class DistanecBetweenPoints
    {
        public class Points
        {
            public  double pointX1 { get; set; }
            public double pointX2 { get; set; }
            public double pointY1 { get; set; }
            public double pointY2 { get; set; }
        }
        static void Main(string[] args)
        {

            var inputForX1Y1 = Console.ReadLine().Split().Select(double.Parse).ToList();
            var inputForX2Y2 = Console.ReadLine().Split().Select(double.Parse).ToList();

            var firstPoint = new Points
            {
                pointX1 = inputForX1Y1[0],
                pointX2 = inputForX2Y2[0]
                
            };

            var seconPoint = new Points
            {
                pointY1 = inputForX1Y1[1],
                pointY2 = inputForX2Y2[1]
            };

            var sideA = firstPoint.pointX1 - firstPoint.pointX2;
            var sideB = seconPoint.pointY1 - seconPoint.pointY2;
            var distance = Math.Sqrt(Math.Pow(sideA,2) + Math.Pow(sideB,2));
            

            Console.WriteLine($"{distance:F3}");
        }
    }
}
