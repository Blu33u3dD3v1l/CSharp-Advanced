using System;
using System.Linq;
using System.Collections.Generic;

namespace FlowerWreaths
{
    public class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var line1 = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var wreaths = 0;
            var storedFlowers = 0;

            var roses = new Queue<int>(line);
            var lilis = new Stack<int>(line1);

            while(roses.Any() && lilis.Any())
            {
                var firstRose = roses.Peek();
                var firstLili = lilis.Peek();

                if(firstRose + firstLili == 15)
                {
                    wreaths++;
                    roses.Dequeue();
                    lilis.Pop();
                }
                if(firstRose + firstLili > 15)
                {
                    var a = firstLili - 2;
                    lilis.Pop();
                    lilis.Push(a);
                }
                if(firstLili + firstRose < 15)
                {
                    var a = firstRose + firstLili;
                    storedFlowers += a;
                    roses.Dequeue();
                    lilis.Pop();
                }
            }
            if(storedFlowers > 0)
            {
                wreaths += Math.Abs(storedFlowers) / 15;
            }
            if(wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
         
           

        }
    }
}
