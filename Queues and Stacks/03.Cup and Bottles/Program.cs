using System;
using System.Linq;
using System.Collections.Generic;

namespace CupsAndBottles
{
    class Program
    {
        static void Main()
        {

            var cups = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).Reverse().ToList());
            var bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());

            var wastedWater = 0;

            while (true)
            {
                if (bottles.Count == 0 || cups.Count == 0)
                {
                    break;
                }
                var cup = cups.Peek();
                var bottle = bottles.Peek();               
                if (bottle < cup)
                {

                    var curr = cup - bottle;
                    cups.Pop();
                    cups.Push(curr);
                    bottles.Pop();

                }
                else
                {


                    wastedWater += bottle - cup;
                    cups.Pop();
                    bottles.Pop();

                }


            }
            if (bottles.Count > 0)
            {

                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
                
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ",cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
         
        }
    }
}
