using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {

            string patternddm = @"(?<ddm>.[^a-zA-Z-]+)";
            string patternbjm = @"\b(?<bjm>[a-zA-z]+-[a-zA-z]+)\b";

            var input = Console.ReadLine();
            var output = new StringBuilder();
            output.Append(input);
            var bjmRegex = new Regex(patternbjm);
            var ddmregex = new Regex(patternddm);

            while (input.Length > 0)
            {
                var matchddm = ddmregex.Match(input);
                if (!matchddm.Success)
                {
                    input = Console.ReadLine();
                    continue;

                }
                else
                {
                    var wordDDM = matchddm.Groups["ddm"].Value;
                    var removeCountDDM = wordDDM.Count();
                   
                   
                    Console.WriteLine(wordDDM);
                   

                    var matchbjm = bjmRegex.Match(input);

                    if (matchbjm.Success)
                    {
                        var wordBJM = matchbjm.Groups["bjm"].Value;
                        var remvoveBHM = wordBJM.Count();
                        var coutn = 0;
                        var removeCountBJM = wordBJM.Count();
                        input = input.Remove(0, removeCountBJM);
                        for (int i = 0; i < input.Length; i++)
                        {
                            if(input[i] == stopLetter)
                            {
                                break;
                            }
                            else
                            {
                                coutn++;
                            }
                        }

                        
                        
                        
                        input = input.Remove(0, coutn);
                              
                        Console.WriteLine(wordBJM);
                        
                    }
                }

               

            }
        }
    }
}
