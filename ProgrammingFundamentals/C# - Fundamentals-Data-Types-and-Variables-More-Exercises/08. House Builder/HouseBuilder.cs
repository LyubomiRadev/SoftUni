using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();

            sbyte sbyteNumber = 0;
            long intagerNumber= 0;

            if(sbyte.TryParse(n1, out sbyteNumber))
            {
                sbyteNumber = sbyte.Parse(n1);
                intagerNumber = int.Parse(n2);
            }
            else
            {
                intagerNumber = int.Parse(n1);
                sbyteNumber = sbyte.Parse(n2);
            }

            long byteBricks = sbyteNumber * 4;
            long intagerBricks = intagerNumber * 10;
            long result = byteBricks + intagerBricks;

            Console.WriteLine(result);
        }
    }
}
