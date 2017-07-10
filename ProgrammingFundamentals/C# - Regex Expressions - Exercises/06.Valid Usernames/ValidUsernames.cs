using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var inputSplitter = @"\W+";
            var splittedUsers = Regex.Replace(input, inputSplitter, " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";
            var regex = new Regex(pattern);
            var usersList = new List<string>();

            foreach(var item in splittedUsers)
            {
                if (regex.IsMatch(item))
                {
                    usersList.Add(item);
                }
            }

            int maxSum = 0;
            var userOne = string.Empty;
            var userTwo = string.Empty;

            for (int i = 1; i < usersList.Count; i++)
            {
                var currentSum = usersList[i - 1].Length + usersList[i].Length;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    userOne = usersList[i-1];
                    userTwo = usersList[i ];
                }
            }

            Console.WriteLine(userOne);
            Console.WriteLine(userTwo);
        }
    }
}
