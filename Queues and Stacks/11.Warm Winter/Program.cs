using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    internal class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var endList = new List<int>();

           
            var hats = new Stack<int>(list);
            var scarf = new Queue<int>(list1);

            while (hats.Any() && scarf.Any())
            {
                var hatsFirst = hats.Peek();
                var scarfFirst = scarf.Peek();

                if(hatsFirst > scarfFirst)
                {
                    var a = hatsFirst + scarfFirst;
                    endList.Add(a);
                    hats.Pop();
                    scarf.Dequeue();
                }
                else if(scarfFirst > hatsFirst)
                {
                    hats.Pop();
                }
                else if(hatsFirst == scarfFirst)
                {
                    var a = hatsFirst + 1;
                    scarf.Dequeue();
                    hats.Pop();
                    hats.Push(a);

                }


            }
            var maxSet = endList.Max();
            Console.WriteLine($"The most expensive set is: {maxSet}");
            Console.WriteLine(String.Join(" ",endList));


        }
    }
}
