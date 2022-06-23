using System;
using System.Linq;
using System.Collections.Generic;

namespace FastFood
{
    public class Program
    {
        static void Main()
        {

            var num = int.Parse(Console.ReadLine());
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();
            var orders = new Queue<int>(line);
            var a = orders.Max();

            while (true)
            {
                if(orders.Count > 0)
                {
                    var order = orders.Peek();
                    if (num >= order)
                    {
                        num -= order;
                        orders.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }            
                else
                {
                    break;
                }
            }
            if(orders.Count == 0)
            {
                Console.WriteLine(a);
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(a);
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }

        }
     
    }
}
