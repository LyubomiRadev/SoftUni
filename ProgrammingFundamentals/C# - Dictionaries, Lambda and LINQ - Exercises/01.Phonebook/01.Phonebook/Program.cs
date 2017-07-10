using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            //вземаме ip, message, user

            
            var userInfo = new SortedDictionary<string, Dictionary<string, int>>();
            bool canContinue = true;
            int counter = 0;
            while (canContinue)
            {
                var input = Console.ReadLine().Split('=').ToList();
                if(input[0] == "end")
                {
                    break;
                }
                string[] ipInfo = input[1].Split();
                string extractedIp = ipInfo[0];
                var userName = input[3];

                if (!userInfo.ContainsKey(userName))
                {
                    userInfo[userName] = new Dictionary<string, int>();
                }
                if (!userInfo[userName].ContainsKey(extractedIp))
                {
                    userInfo[userName].Add(extractedIp, counter);
                }
                userInfo[userName][extractedIp]++;
               
            }
            

            foreach(var user in userInfo)
            {
                Console.WriteLine($"{user.Key}:");
                var ipInformation = user.Value;
                foreach(var ip in ipInformation)
                {
                    if(ip.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip.Key} => {ip.Value}.");
                    }
                    
                }
            }            
        }
          
    }
}
