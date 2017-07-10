using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_SMS
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfChars = int.Parse(Console.ReadLine());

            int mainDigit = 0;
            int offsetNumber = 0;
            int letterIndex = 0;
            int numberOfDigits = 0;
            string result = "";
            char word = 's';
            
            for (int i = 1; i <= numberOfChars ; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 10)
                {
                    numberOfDigits = 1;
                }
                else if(number>9 && number < 100)
                {
                    numberOfDigits = 2;
                }
                else if (number > 99)
                {
                    numberOfDigits = 3;
                }
                mainDigit = int.Parse(number.ToString()[0].ToString());

                if (number == 7777)
                {
                    word = 's';
                }
                if (number == 9999)
                {
                    word = 'z';
                }
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offsetNumber = ((mainDigit - 2) * 3) +1;
                }
                else
                {
                    offsetNumber = (mainDigit - 2) * 3;
                }

                letterIndex = offsetNumber + numberOfDigits - 1;

                if(letterIndex == -6)
                {
                    letterIndex = -65;
                }
               
                word = ((char)(97 + letterIndex));
                if (number == 7777)
                {
                    word = 's';
                }
                if (number == 9999)
                {
                    word = 'z';
                }
                result += word;
                
            }
            Console.WriteLine(result);
        }
    }
}
