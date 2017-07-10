using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Weather_Forecast
{
    class WeatherForecast
    {
        class WeatherInfo
        {            
            public double Temperature { get; set; }

            public string Weather { get; set; }
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"(?<city>[A-Z]{2})(?<temp>[0-9]+.[0-9]+)(?<weather>[A-Za-z]+)\|");
            var weatherInfo = new Dictionary<string,WeatherInfo>();
            while (input != "end")
            {
                var doesMatch = pattern.Match(input);

                if (!doesMatch.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var city = doesMatch.Groups["city"].Value;
                var temperature = double.Parse(doesMatch.Groups["temp"].Value);
                var forecast = doesMatch.Groups["weather"].Value;

                var info = new WeatherInfo
                {
                    Temperature = temperature,
                    Weather = forecast
                };

                weatherInfo[city] = info;

                input = Console.ReadLine();
            }

            var sortedInfo = weatherInfo.OrderBy(city => city.Value.Temperature);

            foreach(var item in sortedInfo)
            {
                var city = item.Key;
                var temperature = item.Value.Temperature;
                var weather = item.Value.Weather;

                Console.WriteLine($"{city} => {temperature:F2} => {weather}");
            }
           

            
        }
    }
}
