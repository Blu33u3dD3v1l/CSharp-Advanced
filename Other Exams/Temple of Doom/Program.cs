using System;
using System.Collections.Generic;
using System.Linq;

namespace Temple_of_Doom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var toolsInput = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();
            var substancesInput = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();
            var challengesInput = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();


            var tools = new Queue<int>(toolsInput);
            var substances = new Stack<int>(substancesInput);
            var challenges = new List<int>(challengesInput);

            while (substances.Any() && tools.Any() && challenges.Any())
            {
                var currentTool = tools.Peek();
                var currentSubstance = substances.Peek();


               var num = currentTool * currentSubstance;
                if (challenges.Contains(num))
                {
                    tools.Dequeue();
                    substances.Pop();
                    challenges.Remove(num);
                }
                else
                {
                    var a = currentTool + 1;
                    tools.Dequeue();
                    tools.Enqueue(a);
                    var b = currentSubstance - 1;
                    if(b <= 0)
                    {
                        substances.Pop();
                    }
                    else
                    {
                        substances.Pop();
                        substances.Push(b);
                    }
                }
            }

            if (challenges.Any())
            {
                Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
            }
            else
            {
                Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
            }

            if (tools.Any())
            {
                Console.WriteLine($"Tools:" + " " + string.Join(", ", tools));
            }
            if (substances.Any())
            {
                Console.WriteLine($"Substances:" + " " + string.Join(", ", substances));
            }
            if (challenges.Any())
            {
                Console.WriteLine($"Challenges:" + " " + string.Join(", ", challenges));
            }
           
        }
    }
}