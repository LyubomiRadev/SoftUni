using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double newResult = 0;
            double result = 0;
            string output = "";

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                double kegHeight = double.Parse(Console.ReadLine());

                result = Math.PI * kegRadius * kegRadius * kegHeight;

                if(newResult< result)
                {
                    newResult = result;
                    output = kegModel;
                }
            }

            Console.WriteLine(output);

        }
    }
}
