﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_One
{
    class Program
    {
        static void Main(string[] args)
        {

            string country = Console.ReadLine();

            switch (country)
            {
                case "England":

                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
