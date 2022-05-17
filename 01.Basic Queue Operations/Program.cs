using System;
using System.Collections.Generic;
using System.Linq;

namespace gfdf
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();
            var queue = new Queue<int>();
            var line1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < line1.Count; i++)
            {
                queue.Enqueue(line1[i]);
            }
            for (int i = 0; i < line[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(line[2]))
            {
                Console.WriteLine("true");
            }
            if (!queue.Contains(line[2]) && queue.Count > 0)
            {
                Console.WriteLine(queue.Min());
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }


        }
    }
}
