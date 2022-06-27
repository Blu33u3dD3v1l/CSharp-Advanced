using System;
using System.Linq;
using System.Collections.Generic;

namespace TilesMaster
{
    public class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();
            var line1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var dict = new Dictionary<string, int>() { { "Sink", 0 }, { "Oven", 0 }, { "Countertop", 0 }, { "Wall", 0 },{"Floor", 0 } };

            var stack = new Stack<int>(line);
            var queue = new Queue<int>(line1);

            while (stack.Any() && queue.Any())
            {
                var currStack = stack.Peek();
                var currQueue = queue.Peek();  
                
                if(currStack == currQueue)
                {
                    var a = currQueue + currStack;
                    if(a == 40)
                    {
                        dict["Sink"]++;
                        stack.Pop();
                        queue.Dequeue();
                    }
                    else if(a == 50)
                    {
                        dict["Oven"]++;
                        stack.Pop();
                        queue.Dequeue();
                    }
                    else if(a == 60)
                    {
                        dict["Countertop"]++;
                        stack.Pop();
                        queue.Dequeue();
                    }
                   else if(a == 70)
                    {
                        dict["Wall"]++;
                        stack.Pop();
                        queue.Dequeue();
                    }
                    else
                    {
                        dict["Floor"]++;
                        stack.Pop();
                        queue.Dequeue();
                    }
                }
                else
                {
                    var a = currStack / 2;
                    var b = currQueue;
                    stack.Pop();
                    stack.Push(a);
                    queue.Dequeue();
                    queue.Enqueue(b);
                }
            }
            if (stack.Any())
            {
                Console.WriteLine($"White tiles left: {string.Join(", ",stack)}");
            }
            else
            {
                Console.WriteLine("White tiles left: none");
            }
            if (queue.Any())
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", queue)}");
            }
            else
            {
                Console.WriteLine("Grey tiles left: none");
            }



            foreach (var item in dict.Where(x => x.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            
           
        }
    }
}
