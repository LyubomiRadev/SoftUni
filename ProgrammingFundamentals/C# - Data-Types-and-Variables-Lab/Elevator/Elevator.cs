using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {

            int people = int.Parse(Console.ReadLine());
            int capacityPerCourse = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)people / capacityPerCourse);

            Console.WriteLine(courses);



        }
    }
}
