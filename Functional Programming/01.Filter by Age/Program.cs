using System;
using System.Linq;
using System.Collections.Generic;

namespace SortingByAge
{
    internal class Program
    {
        static void Main()
        {

            var num = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < num; i++)
            {
                var line = Console.ReadLine();
                var tokens = line.Split(", ");
                var name = tokens[0];
                var agee = int.Parse(tokens[1]);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, agee);
                }

            }
            var command = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            if (command == "older")
            {
                if (format == "name age")
                {
                    foreach (var item in dict.Where(x => x.Value >= age))
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
                else if (format == "name")
                {
                    foreach (var item in dict.Where(x => x.Value >= age))
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                }
                else
                {
                    foreach (var item in dict.Where(x => x.Value >= age))
                    {
                        Console.WriteLine($"{item.Value}");
                    }
                }
            }
            if (command == "younger")
            {
                if (format == "name age")
                {
                    foreach (var item in dict.Where(x => x.Value < age))
                    {
                        Console.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
                else if (format == "name")
                {
                    foreach (var item in dict.Where(x => x.Value < age))
                    {
                        Console.WriteLine($"{item.Key}");
                    }
                }
                else
                {
                    foreach (var item in dict.Where(x => x.Value < age))
                    {
                        Console.WriteLine($"{item.Value}");
                    }
                }
            }

        }
    }
}