using System;
using System.Collections.Generic;
using System.Linq;


namespace ToolBox
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();
            var line2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var queue = new Queue<int>(line);
            var stack = new Stack<int>(line2);
            var sum = 0;

            while (queue.Any() && stack.Any())
            {

                var a = queue.Peek() + stack.Peek();
                if (a % 2 == 0)
                {
                    sum += a;
                    stack.Pop();
                    queue.Dequeue();
                }
                else
                {
                    var n = stack.Peek();
                    queue.Enqueue(n);
                    stack.Pop();
                }

            }
            if (stack.Any())
            {
                Console.WriteLine("First lootbox is empty");
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");

            }
            if (sum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
