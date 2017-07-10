using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Viechle_Catalogue
{
    class ViechleCatalogue
    {
        public class Cars
        {
            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public int HorsePower { get; set; }
        }

        public class Trucks
        {
            public string Type { get; set; }

            public string Model { get; set; }

            public string Color { get; set; }

            public int HorsePower { get; set; }
        }
        public class Catalogue
        {
            public List<Cars> Cars { get; set; }

            public List<Trucks> Trucks { get; set; }
        }
        static void Main(string[] args)
        {
            var catalogue = new Catalogue
            {
                Cars = new List<Cars>(),
                Trucks = new List<Trucks>()
            };
            Catalogue catalog = NewMethod(catalogue);
            var models = Console.ReadLine();

            while (models != "Close the Catalogue")
            {
                foreach (var item in catalog.Cars)
                {
                    if (item.Model == models)
                    {
                        Console.WriteLine($"Type: {item.Type}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                   
                }

                foreach(var item in catalog.Trucks)
                {
                    if(item.Model == models)
                    {
                        Console.WriteLine($"Type: {item.Type}");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                   
                }
                models = Console.ReadLine();

            }

            double averageCarPower;
            double averageTruckPower;
            if (catalog.Cars.Count <= 0)
            {
                averageTruckPower = catalog.Trucks.Average(item => item.HorsePower);
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckPower:F2}.");


            }
          
            if (catalog.Trucks.Count <= 0)
            {
                averageCarPower = catalog.Cars.Average(item => item.HorsePower);
                Console.WriteLine($"Cars have average horsepower of: {averageCarPower:F2}.");
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");

            }
            else
            {
                averageCarPower = catalog.Cars.Average(item => item.HorsePower);
                averageTruckPower = catalog.Trucks.Average(item => item.HorsePower);
                Console.WriteLine($"Cars have average horsepower of: {averageCarPower:F2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckPower:F2}.");
            }

        }

        private static Catalogue NewMethod(Catalogue catalogue)
        {
            var input = Console.ReadLine().Split().ToList();

            while (input[0] != "End")
            {

                if (input[0].ToLower() == "truck")
                {
                    catalogue.Trucks.Add(AddTruck(input));
                }
                if (input[0].ToLower() == "car")
                {
                    catalogue.Cars.Add(AddCar(input));
                }

                input = Console.ReadLine().Split().ToList();



            }
            return catalogue;

        }

        private static Trucks AddTruck(List<string> input)
        {
            return new Trucks
            {
                Type = "Truck",
                Model = input[1],
                Color = input[2],
                HorsePower = int.Parse(input[3])
            };
        }

        private static Cars AddCar(List<string> input)
        {
            return new Cars
            {
                Type = "Car",
                Model = input[1],
                Color = input[2],
                HorsePower = int.Parse(input[3])
            };
        }
    }
}

