using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            //условирето е на дъното на кода

            int numberOfRegistrations = int.Parse(Console.ReadLine());
            var registrationDatabase = new Dictionary<string, string>();
            for (int i = 0; i < numberOfRegistrations; i++)
            {
                var registrationInput = Console.ReadLine().Split().ToList();



                if (registrationInput[0] == "register")
                {
                    bool isValid = CheckPlate(registrationInput);


                    bool canContinue = true;
                    if (!isValid)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {registrationInput[2]}");
                        canContinue = false;
                    }
                    string name = registrationInput[1];
                    string carNumber = registrationInput[2];
                    var firstTwoLetters = registrationInput[2].Take(2).ToList();
                    var lastTwoLetters = registrationInput[2].Skip(6).Take(2).ToList();

                    if (registrationDatabase.ContainsKey(name) && canContinue)
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carNumber}");
                        canContinue = false;
                    }
                    if (registrationDatabase.ContainsValue(carNumber) && canContinue)
                    {
                        Console.WriteLine($"ERROR: license plate {carNumber} is busy");
                        canContinue = false;
                    }
                    if (!registrationDatabase.ContainsKey(name) && canContinue)
                    {
                        registrationDatabase.Add(name, carNumber);
                    }

                    else if (registrationDatabase.ContainsValue(carNumber) && canContinue)
                    {

                        canContinue = false;
                    }
                    if (canContinue)
                    {
                        Console.WriteLine($"{name} registered {carNumber} successfully");
                    }
                }

                if (registrationInput[0] == "unregister")
                {
                    string name = registrationInput[1];

                    if (!registrationDatabase.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        registrationDatabase.Remove(name);
                        Console.WriteLine($"user {name} unregistered successfully");
                    }
                }
            }

            foreach (var parkingUser in registrationDatabase)
            {
                var name = parkingUser.Key;
                var carNumber = parkingUser.Value;
                Console.WriteLine($"{name} => {carNumber}");
            }
        }

        private static bool CheckPlate(List<string> registrationInput)
        {
            string carNumber = registrationInput[2];
            var firstTwoLetters = registrationInput[2].Take(2).ToList();
            var lastTwoLetters = registrationInput[2].Skip(6).Take(2).ToList();
            var digitsInNumber = carNumber.Skip(2).Take(4).ToList();
            firstTwoLetters.AddRange(lastTwoLetters);

            if (carNumber.Length != 8)
            {
                return false;
            }

            for (int i = 0; i < firstTwoLetters.Count; i++)
            {
                if (!char.IsLetter(firstTwoLetters[i]))
                {

                    return false;
                }
                if (!char.IsUpper(firstTwoLetters[i]))
                {
                    return false;
                }
            }

            for (int i = 0; i < digitsInNumber.Count; i++)
            {
                if (!char.IsDigit(digitsInNumber[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}