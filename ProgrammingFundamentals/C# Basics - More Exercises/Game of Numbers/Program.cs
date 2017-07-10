using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int space = n - 2;
            
            int rightSideSpace = 0;
            int secondRightSpace = n / 2 - 1;
            int secondSpace = 1;
            


            for (int i = 1; i <= n/2 ; i++)
            {
               
                Console.WriteLine("{1}x{0}x", new string(' ', space), new string(' ', rightSideSpace));
                space -= 2;
                rightSideSpace++;
                
            }
            Console.WriteLine("{0}x",new string(' ',n/2));

            for (int i = 1; i <= n / 2; i++)
            {

                Console.WriteLine("{1}x{0}x", new string(' ', secondSpace), new string(' ', secondRightSpace));
                secondSpace += 2;
                secondRightSpace--;

            }
        }
    }
}
