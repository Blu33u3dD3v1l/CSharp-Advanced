using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();
            var line1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var stack = new Stack<int>(line1);
            var queue = new Queue<int>(line);
            var dict = new Dictionary<string, int>() { { "Bread", 0 }, { "Cake", 0 }, { "Fruit Pie", 0 }, { "Pastry", 0 } };

            var b = 25;
            var c = 50;
            var p = 75;
            var f = 100;

            while(stack.Any() && queue.Any())
            {

                var sum = stack.Peek() + queue.Peek();              
                if (sum == b)
                {

                    dict["Bread"]++;                  
                    stack.Pop();
                    queue.Dequeue();

                }
                else if (sum == c)
                {
                   
                    dict["Cake"]++;                    
                    stack.Pop();
                    queue.Dequeue();

                }
                else if (sum == p)
                {
                   
                    dict["Pastry"]++;                    
                    stack.Pop();
                    queue.Dequeue();
                }
                else if (sum == f)
                {
                   
                    dict["Fruit Pie"]++;                    
                    stack.Pop();
                    queue.Dequeue();

                }
                else
                {
                    queue.Dequeue();
                    var area = stack.Peek() + 3;
                    stack.Pop();
                    stack.Push(area);
                }
              
            }
            var count = 0;
            foreach (var item in dict)
            {
                if(item.Value < 1)
                {
                    count++;
                }
                
            }
            if (count == 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if(queue.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",queue)}");
            }
            if(stack.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", stack)}");
            }
            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
          
           
        }
    }
}
