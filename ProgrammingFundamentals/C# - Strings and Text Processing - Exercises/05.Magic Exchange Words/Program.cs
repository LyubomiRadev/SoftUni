using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_Exchange_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split();
            var wordOne = input[0];
            var wordTwo = input[1];
            var exchDict = new Dictionary<char, char>();
            var min = Math.Min(wordOne.Length, wordTwo.Length);
            bool isExchangeable = true;

            for (int i = 0; i < min; i++)
            {
                if (!exchDict.ContainsKey(wordOne[i]))
                {
                    if (!exchDict.ContainsValue(wordTwo[i]))
                    {
                        exchDict.Add(wordOne[i], wordTwo[i]);
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }
                }
                else
                {
                    if(exchDict[wordOne[i]] != wordTwo[i])
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            string result = "";

            if (wordOne.Length > wordTwo.Length)
            {
                result = wordOne.Substring(min);
            }
            if(wordTwo.Length > wordOne.Length)
            {
                result = wordTwo.Substring(min);
            }

            foreach(char word in result)
            {
                if(!exchDict.ContainsKey(word) && !exchDict.ContainsValue(word))
                {
                    isExchangeable = false;
                    break;
                }
            }

            Console.WriteLine(isExchangeable.ToString().ToLower());


        }        
    }
}
