using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Email
{
    class FixEmail
    {
        static void Main(string[] args)
        {
            var clientsEmails = new Dictionary<string, string>();
            bool canContinue = true;

            while (canContinue)
            {
                string name = Console.ReadLine();
                if(name == "stop")
                {                    
                    PrintUsers(clientsEmails, name);
                    canContinue = false;
                }
                else
                {
                    string email = Console.ReadLine();
                    AddToClientsEmails(clientsEmails, name, email);
                }
            }
        }

        private static void AddToClientsEmails(Dictionary<string, string> clientsEmails, string name, string email)
        {
            
                if (clientsEmails.ContainsKey(name))
                {
                    clientsEmails[name] = email;
                }
                else
                {
                    clientsEmails.Add(name, email);
                }
            
        }

        private static void PrintUsers(Dictionary<string, string> clientsEmails, string name)
        {
            

            foreach(var client in clientsEmails)
            {
                if (!client.Value.ToLower().Contains(".us") || !client.Value.ToLower().Contains(".uk"))
                {
                     Console.WriteLine("{0} -> {1}", client.Key, client.Value);
                }
               
            }

           
        }
    }
}
