using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split().Select(double.Parse).ToList();
            var line1 = Console.ReadLine().Split().Select(double.Parse).ToList();                  
            var stack = new Stack<double>(line1);
            var queue = new Queue<double>(line);
            var dict = new Dictionary<string, int>();

            var c = 50;
            var m = 40;
            var bagu = 30;
            var bag = 20;
            while (stack.Any() && queue.Any())
            {
                
                var sum = stack.Peek() + queue.Peek();
                var area = (queue.Peek() * 100) / sum;                         
                if(area == c)
                {
                    if (!dict.ContainsKey("Croissant"))
                    {
                        dict.Add("Croissant", 1);
                    }
                    else
                    {
                        dict["Croissant"]++;
                    }                  
                    stack.Pop();
                    queue.Dequeue();
                  
                }
                else if (area == m)
                {
                    if (!dict.ContainsKey("Muffin"))
                    {
                        dict.Add("Muffin", 1);
                    }
                    else
                    {
                        dict["Muffin"]++;
                    }                                   
                    stack.Pop();
                    queue.Dequeue();
                 
                }
                else if (area == bagu)
                {
                    if (!dict.ContainsKey("Baguette"))
                    {
                        dict.Add("Baguette", 1);
                    }
                    else
                    {
                        dict["Baguette"]++;
                    }                                 
                    stack.Pop();
                    queue.Dequeue();                  
                }
               else if (area == bag)
                {
                    if (!dict.ContainsKey("Bagel"))
                    {
                        dict.Add("Bagel", 1);
                    }
                    else
                    {
                        dict["Bagel"]++;
                    }                            
                    stack.Pop();
                    queue.Dequeue();

                }
                else
                {
                    var a = queue.Peek();
                    var b = stack.Peek();
                    var area5 = b - a;                 
                    stack.Pop();
                    stack.Push(area5);                  
                    if (!dict.ContainsKey("Croissant"))
                    {
                        dict.Add("Croissant", 1);
                    }
                    else
                    {
                        dict["Croissant"]++;
                    }
                    queue.Dequeue();
                }               
            }          
            foreach (var item in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Water left: None");
               
            }
            if(queue.Count > 0)
            {
                Console.WriteLine($"Water left: {string.Join(", ", queue)}");
            }
            if(stack.Count == 0)
            {
               
                Console.WriteLine($"Flour left: None");
            }
            if(stack.Count > 0)
            {
                Console.WriteLine($"Flour left: {string.Join(", ", stack)}");
            }
  
        }
    }
}
