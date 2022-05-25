using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            var dict1 = new Dictionary<string, Dictionary<string, ulong>>();
            var dict2 = new Dictionary<string, ulong>();


            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end of contests")
                {
                    break;
                }
                var tokens = line.Split(":");
                var contest = tokens[0];
                var password = tokens[1];
                dict.Add(contest, password);
            }
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end of submissions")
                {
                    break;
                }
                var tokens = line.Split("=>");
                var contest = tokens[0];
                var password = tokens[1];
                var username = tokens[2];
                var points = ulong.Parse(tokens[3]);

                if (dict.ContainsKey(contest) && dict[contest].Contains(password))
                {
                    if (!dict1.ContainsKey(username))
                    {
                        dict1[username] = new Dictionary<string, ulong>();
                        dict1[username].Add(contest, points);
                    }
                    else
                    {
                        if (!dict1[username].ContainsKey(contest))
                        {
                            dict1[username].Add(contest, points);
                        }
                        else
                        {
                            if (dict1[username][contest] < points)
                            {
                                dict1[username][contest] = points;
                            }
                        }
                    }
                }

            }
            foreach (var item in dict1)
            {

                foreach (var a in item.Value)
                {
                    if (!dict2.ContainsKey(item.Key))
                    {
                        dict2.Add(item.Key, a.Value);

                    }
                    else
                    {
                        dict2[item.Key] += a.Value;
                    }
                }
            }
            var bigg = dict2.Values.Max();
            foreach (var item in dict2)
            {

                if (item.Value == bigg)
                {
                    Console.WriteLine($"Best candidate is {item.Key} with total {bigg} points.");
                    break;
                }

            }
            Console.WriteLine("Ranking:");
            foreach (var item in dict1.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var a in item.Value.OrderByDescending(y => y.Value))
                {
                    Console.WriteLine($"#  {a.Key} -> {a.Value}");
                }
            }
        }
    }
}

