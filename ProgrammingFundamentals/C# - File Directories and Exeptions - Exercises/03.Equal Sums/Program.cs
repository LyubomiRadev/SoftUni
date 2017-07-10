using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.Equal_Sums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();
            
            int index = 0;
            bool printNo = true;

            if (input.Count() == 1)
            {
                File.WriteAllText("output.txt", 0.ToString());
                printNo = false;
                
            }
            if (input.Count() == 2)
            {
                File.WriteAllText("output.txt", "no");
                printNo = false;
               
            }
            for (int i = 1; i < input.Count(); i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                
                for (int leftSide = i-1; leftSide >= 0; leftSide--)
                {
                    sumLeft += input[leftSide];
                    
                }
                for (int rightSide = i + 1; rightSide < input.Count(); rightSide++)
                {
                    sumRight += input[rightSide];
                }
                if (sumRight == sumLeft)
                {
                    File.WriteAllText("output.txt", i.ToString());
                    printNo = false;
                    break;
                }
                
            }
            if (printNo)
            {
                File.WriteAllText("output.txt", "no");
            }
            
        }
    }
}
