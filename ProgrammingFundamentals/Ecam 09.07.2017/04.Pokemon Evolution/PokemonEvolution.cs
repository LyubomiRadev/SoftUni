using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Pokemon_Evolution
{
    class PokemonInfo
    {
        public int Index { get; set; }

        public string EvolutionType { get; set; }
    }
    class PokemonEvolution
    {
        static void Main(string[] args)
        {



            var pokemonBook = new Dictionary<string, List<PokemonInfo>>();

            while (true)
            {
                var input = Console.ReadLine();
                var coppyInput = input.Split();

                if (input.ToLower() == "wubbalubbadubdub")
                {
                    break;
                }
                var addPokemonInfo = new List<PokemonInfo>();
                string pattern = @"(?<Name>\w+)\s+->\s+(?<type>\w+)\s+->\s+(?<index>\d+)";
                var splitRegex = new Regex(pattern);
                
                var matchInut = splitRegex.Match(input);
               
                if (coppyInput.Length<2)
                {
                    var name = input;

                    if (pokemonBook.ContainsKey(name))
                    {
                        foreach (var item in pokemonBook.Where(a => a.Key == name))
                        {
                            var pname = item.Key;
                            var info = item.Value;
                            Console.WriteLine($"# {pname}");
                            foreach (var pinfo in info)
                            {
                                var type = pinfo.EvolutionType;
                                var index = pinfo.Index;

                                Console.WriteLine($"{type} <-> {index}");
                            }
                        }
                    }
                }
                if (matchInut.Success)
                {
                    var name = matchInut.Groups["Name"].Value;
                    var type = matchInut.Groups["type"].Value;
                    var index = int.Parse(matchInut.Groups["index"].Value);

                    var adding = new PokemonInfo
                    {
                        EvolutionType = type,
                        Index = index
                    };
                    
                    addPokemonInfo.Add(adding);
                    if (!pokemonBook.ContainsKey(name))
                    {
                        pokemonBook[name] = new List<PokemonInfo>();
                    }
                    
                    pokemonBook[name].Add(adding);
                }


            }

            foreach (var item in pokemonBook)
            {
                var name = item.Key;
                Console.WriteLine($"# {name}");
                var secondOutput = item.Value;
                foreach (var info in secondOutput.OrderByDescending(pokemon => pokemon.Index))
                {
                    var evType = info.EvolutionType;
                    var index = info.Index;

                    Console.WriteLine($"{evType} <-> {index}");
                }
            }
           
        }
    }
}
