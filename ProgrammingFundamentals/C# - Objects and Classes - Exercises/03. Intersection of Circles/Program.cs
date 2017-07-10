using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Intersection_of_Circles
{
    class IntersectionOfCircles
    {
        public class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public double DistanceTo(Point p)
            {
                double deltaX = Math.Abs(X - p.X);
                double deltaY = Math.Abs(Y - p.Y);
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        }
        static void Main(string[] args)
        {
            Circle circleOne = CreateCircle();
            Circle circleTwo = CreateCircle();
            bool intersect = circleOne.Center.DistanceTo(circleTwo.Center) <= circleOne.Radius + circleTwo.Radius;

            Console.WriteLine(intersect ? "Yes" : "No");


        }

        private static Circle CreateCircle()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Point Center = new Point() { X = input[0], Y = input[1] };
            Circle circle = new Circle() { Center = Center, Radius = input[2] };
            return circle;
        }
    }
}
