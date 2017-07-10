﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _06.Sum_Big_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var numberOne = Console.ReadLine().TrimStart(new char[] { '0' });
            var numberTwo = Console.ReadLine().TrimStart(new char[] { '0' });

            var result = new StringBuilder();

            if(numberOne.Length > numberTwo.Length)
            {
                numberTwo = numberTwo.PadLeft(numberOne.Length, '0');
            }
            else if(numberTwo.Length > numberOne.Length)
            {
                numberOne = numberOne.PadLeft(numberTwo.Length, '0');
            }

            char[] str1 = numberOne.ToCharArray();
            char[] str2 = numberTwo.ToCharArray();

            sbyte reminder = 0;
            sbyte additional = 0;

            for (int i = str1.Length-1; i >= 0; i--)
            {
                sbyte n1 = sbyte.Parse(str1[i].ToString());
                sbyte n2 = sbyte.Parse(str2[i].ToString());
                n1 += additional;
                additional = 0;
                if (n1 + n2 < 10)
                {
                    result.Append(n1 + n2);
                }
                else
                {
                    reminder = (sbyte)((n1 + n2) % 10);
                    result.Append(reminder);
                    additional = (sbyte)((n1 + n2) / 10);
                }
            }
            if(additional != 0)
            {
                result.Append(additional);
            }

            char[] finalResult = result.ToString().ToCharArray();
            Array.Reverse(finalResult);

            Console.WriteLine(string.Join("",finalResult));
        }
    }
}