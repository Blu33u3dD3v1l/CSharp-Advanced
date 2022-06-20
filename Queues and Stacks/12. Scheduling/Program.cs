using System;
using System.Linq;
using System.Collections.Generic;

namespace Sheduling
{
    public class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var line1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numToKill = int.Parse(Console.ReadLine()); 

            var task = new Stack<int>(line);
            var thread = new Queue<int>(line1);

            var some = 0;

            while (task.Any() && thread.Any())
            {
                var taskFirst = task.Peek();
                var threadFirst = thread.Peek();
                if (taskFirst == numToKill)
                {
                    some = threadFirst;
                    break;
                }
                if (threadFirst >= taskFirst)
                {
                    thread.Dequeue();
                    task.Pop();
                }
                if(threadFirst < taskFirst)
                {
                    thread.Dequeue();
                } 

            }
            Console.WriteLine($"Thread with value {some} killed task {numToKill}");
            Console.WriteLine(String.Join(" ",thread));
            

        }
    }
}
