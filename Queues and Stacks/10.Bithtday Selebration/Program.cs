using System;
using System.Linq;
using System.Collections.Generic;

namespace BirthdaySelebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            var list1 = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();



            var guest = new Stack<int>(list);
            var plate = new Queue<int>(list1);

            var wastedFood = 0;


            while (plate.Any() && guest.Any())
            {
                var plates = plate.Peek();
                var guests = guest.Peek();

                if(plates >= guests)
                {
                    wastedFood += plates - guests;
                    plate.Dequeue();
                    guest.Pop();
                }
                else
                {
                    var a = guests - plates;
                    plate.Dequeue();
                    guest.Pop();
                    guest.Push(a);
                }
            }
            if (plate.Any())
            {
                Console.WriteLine($"Plates: {string.Join(" ",plate)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(" ", guest)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
        }
    }
}
