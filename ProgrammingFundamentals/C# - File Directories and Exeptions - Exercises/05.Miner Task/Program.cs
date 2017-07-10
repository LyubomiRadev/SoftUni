using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");
            var recources = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i+=2)
            {
                if(input[i].ToLower() == "stop")
                {
                    foreach(var item in recources)
                    {
                        
                        var recource = item.Key;
                        var quantity = item.Value;
                        
                        File.AppendAllText("output.txt",$"{recource} -> {quantity}\r");
                        
                    }
                    break;
                }
                else if(i%2 == 0)
                {
                    if (!recources.ContainsKey(input[i]))
                    {
                        recources.Add(input[i], int.Parse(input[i + 1]));
                    }
                    else
                    {
                        recources[input[i]] += int.Parse(input[i + 1]);
                    }
                }
            }
        }
    }
}
