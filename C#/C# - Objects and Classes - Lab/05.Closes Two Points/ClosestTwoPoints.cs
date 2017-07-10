using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closes_Two_Points
{
    class ClosestTwoPoints
    {
        public class Points
        {
            public double X { get; set; }
            public double Y { get; set; }

            public string Print()
            {
                return $"({X}, {Y})";
            }
        }
        static void Main(string[] args)
        {
            var pointsList = new List<Points>();
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                var currentPoint = ReadPoints();
                pointsList.Add(currentPoint);
            }
            var bestResult = double.MaxValue;
            Points firstPointToPrint = null;
            Points secondPointToPrint = null;
            for (int first = 0; first < pointsList.Count; first++)
            {
                for (int second = first+1; second < pointsList.Count; second++)
                {
                    var firstPoint = pointsList[first];
                    var secondPoint = pointsList[second];
                    var currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < bestResult)
                    {
                        bestResult = currentDistance;
                        firstPointToPrint = firstPoint;
                        secondPointToPrint = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{bestResult:F3}");
            Console.WriteLine(firstPointToPrint.Print());
            Console.WriteLine(secondPointToPrint.Print());
           
        }

        private static double CalculateDistance(Points first, Points second)
        {
            var powX = first.X - second.X;
            var powY = first.Y - second.Y;
            var result = Math.Sqrt(Math.Pow(powX,2) + Math.Pow(powY,2));

            return result;
        }

        private static Points  ReadPoints()
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();

            return new Points
            {
                X = input[0],
                Y = input[1]
            };
        }
    }
}
