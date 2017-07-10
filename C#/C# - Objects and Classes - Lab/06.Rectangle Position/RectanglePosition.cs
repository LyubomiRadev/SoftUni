using System;
using System.Linq;

namespace _06.Rectangle_Position
{
    class RectanglePosition
    {
        public class Rectangle
        {
            public double left { get; set; }
            public double top { get; set; }
            public double width { get; set; }
            public double height { get; set; }

            public double Bottom { get
                {
                    return top + height;
                } }

            public double Right { get
                {
                    return left + width;
                } }
            public  bool IsInside(Rectangle rectangle)
            {
                var isLeft = rectangle.left <= left;
                var isRight = rectangle.Right >= Right;
                var isTop = rectangle.top <= top;
                var isBottom = rectangle.Bottom >= Bottom;

                if(isBottom && isLeft && isRight && isTop)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static void Main(string[] args)
        {

            var rectangleOne = ReadPoints();
            var rectangleTwo = ReadPoints();
            var result = rectangleOne.IsInside(rectangleTwo);

            var printResult = result ? "Inside" : "Not Inside";

            Console.WriteLine(printResult);
           
        }

        
        private static Rectangle ReadPoints()
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToList();

            return new Rectangle
            {
                left = input[0],
                top = input[1],
                width = input[2],
                height = input[3]
            };
        }
    }
}
