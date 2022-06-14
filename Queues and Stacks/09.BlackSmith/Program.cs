using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BlackSmith
{
    public class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            var line1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var dict = new SortedDictionary<string, int>() { { "Gladius", 0 }, { "Shamshir", 0 }, { "Katana",  0 },{"Sabre", 0 }, {"Broadsword", 0 } };


            var steel = new Stack<int>(line);
            var carbon = new Stack<int>(line1);

            while (steel.Any() && carbon.Any())
            {
                var first = steel.Peek();
                var second = carbon.Peek();
                if (first + second == 70)
                {
                    dict["Gladius"]++;
                    steel.Pop();
                    carbon.Pop();
                }
                else if (first + second == 80)
                {
                    dict["Shamshir"]++;
                    steel.Pop();
                    carbon.Pop();
                }
                else if (first + second == 90)
                {
                    dict["Katana"]++;
                    steel.Pop();
                    carbon.Pop();
                }
                else if(first + second == 110)
                {
                    dict["Sabre"]++;
                    steel.Pop();
                    carbon.Pop();
                }
                else if (first + second == 150)
                {
                    dict["Broadsword"]++;
                    steel.Pop();
                    carbon.Pop();
                }
                else
                {
                    var a = second + 5;
                    steel.Pop();
                    carbon.Pop();
                    carbon.Push(a);
  
                }
                

            }                    
            if (dict.Values.Sum() > 0)
            {
                Console.WriteLine($"You have forged {dict.Values.Sum()} swords.");
            }
            else
            {
                Console.WriteLine($"You did not have enough resources to forge a sword.");
            }
            if (!steel.Any())
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ",steel)}");
            }
            if (!carbon.Any())
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ",carbon)}");
            }
            foreach (var item in dict.Where(x => x.Value > 0))
            {

                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
