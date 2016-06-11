using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class PopulationAgregation
    {
        static void Main()
        {
            var townByCountry = new SortedDictionary<string, List<string>>();
            var populationByTown = new Dictionary<string, decimal>();


            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd =="stop")
                {
                    break;
                }

                var cmdTokens = cmd.Split('\\');
                var country = RemoveBadChars(cmdTokens[0]);
                var town = RemoveBadChars(cmdTokens[1]);

                if (!char.IsUpper(country[0]))
                {
                    var old = country;
                    country = town;
                    town = old;
                }

                //Add the current town to the current country
                if (townByCountry.ContainsKey(country))
                {
                    townByCountry[country].Add(town);
                }
                else
                {
                    townByCountry[country] = new List<string>() { town };
                }

                //Add the current population to the current town
                var population = decimal.Parse(cmdTokens[2]);
                if (populationByTown.ContainsKey(town))
                {
                    populationByTown[town] = population;
                }
                else
                {
                    populationByTown[town] = population;
                }

            }

            foreach (var countryAndTown in townByCountry)
            {
                Console.WriteLine("{0} -> {1}", countryAndTown.Key, countryAndTown.Value.Count);
            }

            var tor3populations = populationByTown.OrderByDescending(p => p.Value).Take(3);
            foreach (var p in tor3populations)
            {
                Console.WriteLine("{0} -> {1}",p.Key, p.Value);
            }
        }

         static string RemoveBadChars(string str)
        {
            var validCharsOnly = str.Split("@#$&0123456789".ToArray());
            var combined = string.Join("", validCharsOnly);
            return combined;
        }
    }

