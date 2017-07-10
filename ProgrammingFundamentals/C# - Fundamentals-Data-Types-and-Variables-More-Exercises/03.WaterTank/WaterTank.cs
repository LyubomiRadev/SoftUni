using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WaterTank
{
    class WaterTank
    {
        static void Main(string[] args)
        {
            int numberOfPourings = int.Parse(Console.ReadLine());

            int capacity = 255;
            int currentFill = 0;

            for (int i = 1; i <= numberOfPourings ; i++)
            {

                int quantityToPour = int.Parse(Console.ReadLine());
                currentFill += quantityToPour;

                if (capacity < currentFill)
                {
                    Console.WriteLine("Insufficient capacity!");
                    currentFill -= quantityToPour;           
                }
            }

            Console.WriteLine(currentFill);
        }
    }
}
