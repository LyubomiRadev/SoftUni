using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");
            var contacts = new Dictionary<string, string>();

            for (int i = 0; i < input.Length; i+=2)
            {
                if(input[i].ToLower() == "stop")
                {
                    foreach(var person in contacts)
                    {
                       
                        if(!person.Value.ToLower().Contains(".us") || !person.Value.ToLower().Contains(".uk"))
                        {
                            //File.WriteAllText("output.txt", $"{person} -> {email}");
                            Console.WriteLine($"{person.Key} -> {person.Value}");
                        }
                    }
                    break;
                }
                if(i%2 ==0)
                {
                    if (!contacts.ContainsKey(input[i]))
                    {
                        contacts.Add(input[i], input[i + 1]);
                    }
                    contacts[input[i]] = input[i + 1];
                }
            }
        }
    }
}
