using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Bombs
{
    public class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            var line1 = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            var dict = new SortedDictionary<string, int>() { { "Datura Bombs", 0 }, { "Cherry Bombs", 0 }, { "Smoke Decoy Bombs", 0 } };
           

            var queue = new Queue<int>(line);
            var stack = new Stack<int>(line1);

            while (queue.Any() && stack.Any())
            {
                var first = queue.Peek();
                var second = stack.Peek();
                                  
                if(first + second == 40)
                {
                    dict["Datura Bombs"]++;
                    queue.Dequeue();
                    stack.Pop();
                }
                else if(first + second == 60)
                {
                    dict["Cherry Bombs"]++;
                    queue.Dequeue();
                    stack.Pop();
                }
                else if (first + second == 120)
                {
                    dict["Smoke Decoy Bombs"]++;
                    queue.Dequeue();
                    stack.Pop();
                }
                else
                {
                    var a = second - 5;
                    stack.Pop();
                    stack.Push(a);
                }
               if (dict["Datura Bombs"] > 2 && dict["Cherry Bombs"] > 2 && dict["Smoke Decoy Bombs"] > 2)
                {
                    break;
                }
            }            
            if (dict["Datura Bombs"] > 2 && dict["Cherry Bombs"] > 2 && dict["Smoke Decoy Bombs"] > 2)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (!queue.Any())
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", queue)}");
            }
            if (!stack.Any())
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", stack)}");
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
