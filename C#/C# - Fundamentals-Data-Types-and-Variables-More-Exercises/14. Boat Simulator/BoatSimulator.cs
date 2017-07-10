using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char boatOne = char.Parse(Console.ReadLine());
            char boatTwo = char.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            int resultBoatOne = 0;
            int resultBoatTwo = 0;

            for (int i = 1; i <= count; i++)
            {
                string input = Console.ReadLine();

                

                if (input.ToLower() == "upgrade")
                {
                    boatOne += (char)3;
                    boatTwo += (char)3;
                    
                 }
                 if(i % 2 == 0 && input.ToLower() != "upgrade")
                {
                    resultBoatTwo += input.Count();
                    
                    //Console.WriteLine($"{i} -> {resultBoatTwo}");
                }
                if(i % 2 != 0 && input.ToLower() != "upgrade")
                {
                    resultBoatOne += input.Count();
                    
                    //Console.WriteLine($"{i} -> {resultBoatOne}");
                }

                if (resultBoatOne >= 50)
                {
                    Console.WriteLine(boatOne);
                    return;
                }
                else if (resultBoatTwo >= 50)
                {
                    Console.WriteLine(boatTwo);
                    return;
                }

            }
            if (resultBoatTwo < resultBoatOne)
            {
                Console.WriteLine(boatOne);
            }
            else
            {
                Console.WriteLine(boatTwo);
            }

        }
    }
}
