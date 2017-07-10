using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            int numberOfAdvertisements = int.Parse(Console.ReadLine());
            var phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new List<string>
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
            Random rnd = new Random();
            for (int i = 0; i < numberOfAdvertisements; i++)
            {
                
                Console.WriteLine("{0}. {1} {2} - {3}",
                    phrases[rnd.Next(phrases.Count)],
                    events[rnd.Next(events.Count)],
                    authors[rnd.Next(authors.Count)],
                    cities[rnd.Next(cities.Count)]);
            }
        }
    }
}
