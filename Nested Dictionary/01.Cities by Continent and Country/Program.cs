using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentandCountry
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var line = Console.ReadLine().Split();
                var continent = line[0];
                var country = line[1];
                var town = line[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                    if (!dict[continent].ContainsKey(country))
                    {
                        dict[continent].Add(country, new List<string>());
                        if (!dict[continent][country].Contains(town))
                        {
                            dict[continent][country].Add(town);
                        }
                    }
                }
                else
                {
                    if (dict[continent].ContainsKey(country))
                    {
                        dict[continent][country].Add(town);
                    }
                    else
                    {

                        dict[continent].Add(country, new List<string>());
                        dict[continent][country].Add(town);
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: ");
                foreach (var a in item.Value)
                {
                    Console.WriteLine($"{a.Key} -> {string.Join(", ", a.Value)}");
                }
            }

        }


    }
}

