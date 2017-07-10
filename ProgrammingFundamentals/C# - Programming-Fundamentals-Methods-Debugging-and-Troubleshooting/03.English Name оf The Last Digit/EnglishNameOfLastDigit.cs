using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_оf_The_Last_Digit
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            LastDigitInWords(number);
        }

        private static void LastDigitInWords(int number)
        {
            number %= 10;
            
            switch (number)
            {
                case 0:
                    Console.WriteLine("zero"); 
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break; 
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
            }
        }
    }
}
