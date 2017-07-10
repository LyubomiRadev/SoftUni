using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Files_Size_in_Megabytes
{
    class FileSize
    {
        static void Main(string[] args)
        {

            string[] files = Directory.GetFiles("..\\..\\..\\05.Files Size in Megabytes");
            decimal sum = 0;

            foreach(var file in files)
            {
                FileInfo fileSize = new FileInfo(file);
                sum += fileSize.Length;
            }
            sum = sum / 1024 / 1024;

            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
