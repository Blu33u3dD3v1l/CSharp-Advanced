using System;
using System.Collections.Generic;
using System.Linq;
namespace Barista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, int>() { { "Cortado", 0 }, { "Espresso", 0 }, { "Capuccino", 0 }, { "Americano", 0 }, { "Latte", 0 } };
            var a = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var b = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var coffee = new Queue<int>(a);
            var milk = new Stack<int>(b);

            while (coffee.Any() && milk.Any())
            {
                var coffeeFirst = coffee.Peek();
                var milkFirst = milk.Peek();

                if (coffeeFirst + milkFirst == 50)
                {
                    dict["Cortado"]++;
                    coffee.Dequeue();
                    milk.Pop();
                }
                else if (coffeeFirst + milkFirst == 75)
                {
                    dict["Espresso"]++;
                    coffee.Dequeue();
                    milk.Pop();

                }
                else if (coffeeFirst + milkFirst == 100)
                {
                    dict["Capuccino"]++;
                    coffee.Dequeue();
                    milk.Pop();
                }
                else if (coffeeFirst + milkFirst == 150)
                {
                    dict["Americano"]++;
                    coffee.Dequeue();
                    milk.Pop();
                }
                else if (coffeeFirst + milkFirst == 200)
                {
                    dict["Latte"]++;
                    coffee.Dequeue();
                    milk.Pop();

                }
                else
                {
                    coffee.Dequeue();
                    var m = milkFirst;
                    var sum = m - 5;
                    milk.Pop();
                    milk.Push(sum);
                }


            }
            if (!coffee.Any() && !milk.Any())
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }
            if (!coffee.Any())
            {
                Console.WriteLine("Coffee left: none");
            }
            else
            {
                Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");
            }
            if (!milk.Any())
            {
                Console.WriteLine("Milk left: none");
            }
            else
            {
                Console.WriteLine($"Milk left: {string.Join(", ", milk)}");
            }
            foreach (var item in dict.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }

            }

        }
    }
}
