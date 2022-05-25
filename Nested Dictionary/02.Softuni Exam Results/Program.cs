using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftuniExamResults
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, int>();
            var examsCount = new Dictionary<string, int>();
            while (true)
            {
                var line = Console.ReadLine();
                if(line =="exam finished")
                {
                    break;
                }
                var tokens = line.Split("-");
                if(tokens[1] != "banned")
                {
                    var name = tokens[0];
                    var exam = tokens[1];
                    var points = int.Parse(tokens[2]);

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, points);
                        if (!examsCount.ContainsKey(exam))
                        {
                            examsCount.Add(exam, 1);
                        }
                        else
                        {
                            examsCount[exam]++;
                        }
                    }
                    else
                    {
                        if(dict[name] < points)
                        {
                            dict[name] = points;
                        }
                        if (!examsCount.ContainsKey(exam))
                        {
                            examsCount.Add(exam, 1);
                        }
                        else
                        {
                            examsCount[exam]++;
                        }

                    }
                }
                else
                {
                    var name = tokens[0];
                    if (dict.ContainsKey(name))
                    {
                        dict.Remove(name);
                    }
                }
            }
            Console.WriteLine("Results:");
            foreach (var item in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in examsCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
