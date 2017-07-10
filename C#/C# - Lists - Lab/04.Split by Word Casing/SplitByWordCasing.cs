using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '"', '\'', '\\', '/', '(', ')', '[', ']', },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            var upperCase = new List<string>();
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();

            foreach(var word in input)
            {
                bool isAllUpper = true;
                bool isAllLower = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i])){
                        isAllUpper = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLower = false;
                    }
                    else
                    {
                        isAllLower = false;
                        isAllUpper = false;
                    }

                }
                if (isAllLower)
                {
                    lowerCase.Add(word);
                }
                else if (isAllUpper)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }

                
            }
            Console.WriteLine("Lower-case: {0}",string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));

        }
    }
}
