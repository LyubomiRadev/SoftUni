using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_Gallery
{
    class Photo_Gallery
    {
        static void Main(string[] args)
        {

            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double sizeInBytes = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            
            string resolutionName = "";
            string sizeFormat = "";

            if(width == height)
            {
                resolutionName = "square";
            }
            else if (width < height)
            {
                resolutionName = "portrait";
            }
            else if(width > height)
            {
                resolutionName = "landscape";
            }

            if (sizeInBytes <= 999)
            {
                sizeFormat = "B";
            }
            if(sizeInBytes > 999 && sizeInBytes <= 999999)
            {
                sizeFormat = "KB";
                sizeInBytes /= 1000;
            }
            if (sizeInBytes > 999999)
            {
                sizeFormat = "MB";
                sizeInBytes /= 1000000;
            }

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {sizeInBytes}{sizeFormat}");
            Console.WriteLine($"Resolution: {width}x{height} ({resolutionName})");
        }
    }
}
