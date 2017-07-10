using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Count
{
    class PopulationCount
    {
        static void Main(string[] args)
        {
            var countriesPopulation = new Dictionary<string, Dictionary<string, long>>();

            bool canContinue = true;
            string country = "";
            string city = "";
            long cityPopulation = 0;
            while (canContinue)
            {
                var input = Console.ReadLine().Split('|').ToList();

                if(input[0] == "report")
                {
                    break;
                }

                 country = input[1];
                 city = input[0];
                 cityPopulation = long.Parse(input[2]);

                if (!countriesPopulation.ContainsKey(country))
                {
                    countriesPopulation[country] = new Dictionary<string, long>();
                }
                if (!countriesPopulation[country].ContainsKey(city))
                {
                    countriesPopulation[country].Add(city, cityPopulation);
                }
                countriesPopulation[country][city]=cityPopulation;
            }
            
            foreach(var countryPopulation in countriesPopulation.OrderByDescending(a => a.Value.Values.Sum()))
            {
                var citysSpecifics = countryPopulation.Value;
                Console.WriteLine($"{countryPopulation.Key} (total population: {countryPopulation.Value.Values.Sum()})");
                foreach(var info in citysSpecifics.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"=>{info.Key}: {info.Value} ");
                }
            }
            

            
        }
    }
}
