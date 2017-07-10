using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Message
{
    class DecryptingMessage
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                input += (char)key;
                string output = "";
                output += input;
                Console.Write(output);
            }

        }
    }
}
