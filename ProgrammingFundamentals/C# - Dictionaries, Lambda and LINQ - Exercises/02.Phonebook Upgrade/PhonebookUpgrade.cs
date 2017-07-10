using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook_Upgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            bool canContinue = true;

            while (canContinue)
            {
                string[] input = Console.ReadLine().Split();

                switch (input[0])
                {
                    case "A":
                        AddToPhoneBook(phonebook, input);
                        break;
                    case "S":
                        SearchPhoneBook(phonebook, input);
                        break;
                    case "ListAll":
                        ShowEntirePhonebook(phonebook);
                        break;
                    case "END":
                        canContinue = false;
                        break;

                }



            }
        }

        private static void ShowEntirePhonebook(SortedDictionary<string, string> phonebook)
        {
            foreach(var contact in phonebook)
            {
                Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
            }
        }

        private static void SearchPhoneBook(SortedDictionary<string, string> phonebook, string[] input)
        {
            if (phonebook.ContainsKey(input[1]))
            {
                Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
            }
            else
            {
                Console.WriteLine($"Contact {input[1]} does not exist.");
            }
        }

        private static void AddToPhoneBook(SortedDictionary<string, string> phonebook, string[] input)
        {
            if (phonebook.ContainsKey(input[1]))
            {
                phonebook[input[1]] = input[2];
            }
            else
            {
                phonebook.Add(input[1], input[2]);
            }
        }
    }
}
