using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Order_by_Age
{
    class OrderByAge
    {
        public class Information
        {
            public string Name { get; set; }

            public int Id { get; set; }

            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var persons = new List<Information>();

            var input = Console.ReadLine().Split().ToList();
            while (input[0].ToLower() != "end")
            {
                if (input[0].ToLower() == "end")
                {
                    break;
                }
                else
                {
                    persons.Add(AddPerson(input));
                }
                input = Console.ReadLine().Split().ToList();
            }

            foreach (var person in persons.OrderBy(item => item.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }

        }

        private static Information AddPerson(List<string> input)
        {

            return new Information
            {
                Name = input[0],
                Id = int.Parse(input[1]),
                Age = int.Parse(input[2])
            };
        }
    }
}
