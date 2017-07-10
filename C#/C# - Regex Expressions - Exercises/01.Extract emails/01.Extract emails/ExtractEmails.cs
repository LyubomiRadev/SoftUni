using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Extract_emails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var emails = new List<string>();

            Regex emailPattern = new Regex(@"^[a-zA-Z]+[\.\-_]?[a-zA-Z0-9]+?\@([a-zA-Z]+[a-zA-Z0-9\.\-_])+[a-zA-Z0-9]+$");

            for (int i = 0; i < input.Length; i++)
            {
                if(emailPattern.Match(input[i].Trim()).Success)
                {
                    emails.Add(input[i].Trim());
                }
            }
            

            foreach(var email in emails)
            {
                Console.WriteLine($"{email}");
            }
        }
    }
}
