using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceToPokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            

            var sumValue = 0;

            while (distanceToPokemons.Count() > 0)
            {
                double index = double.Parse(Console.ReadLine());

                if (index < 0)
                {
                    var copyIndex = distanceToPokemons.Last();
                    var removedItem = distanceToPokemons.First();
                    sumValue += removedItem;
                    distanceToPokemons.RemoveAt(0);
                    distanceToPokemons.Insert(0, copyIndex);

                    for (int i = 0; i < distanceToPokemons.Count(); i++)
                    {
                        if(distanceToPokemons[i] <= removedItem)
                        {
                            distanceToPokemons[i] += removedItem;
                        }
                        else
                        {
                            distanceToPokemons[i] -= removedItem;
                        }
                    }

                    
                }

                else if(index > distanceToPokemons.Count()-1)
                {
                    var copyIndex = distanceToPokemons.First();
                    var removedItem = distanceToPokemons.Last();
                    sumValue += removedItem;
                    distanceToPokemons.RemoveAt(distanceToPokemons.Count() - 1);
                    distanceToPokemons.Insert(distanceToPokemons.Count(), copyIndex);

                    for (int i = 0; i < distanceToPokemons.Count(); i++)
                    {
                        if (distanceToPokemons[i] <= removedItem)
                        {
                            distanceToPokemons[i] += removedItem;
                        }
                        else
                        {
                            distanceToPokemons[i] -= removedItem;
                        }
                    }

                    
                }

                else
                {
                    var removedItem = distanceToPokemons[int.Parse(index.ToString())];
                    sumValue += removedItem;

                    for (int i = 0; i < distanceToPokemons.Count(); i++)
                    {
                        if (distanceToPokemons[i] <= removedItem)
                        {
                            distanceToPokemons[i] += removedItem;
                        }
                        else
                        {
                            distanceToPokemons[i] -= removedItem;
                        }
                    }

                    distanceToPokemons.RemoveAt(int.Parse(index.ToString()));
                }

                
            }

            Console.WriteLine(sumValue);
        }
    }
}
