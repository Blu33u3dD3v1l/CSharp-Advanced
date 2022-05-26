using System;
using System.Linq;
using System.Collections.Generic;

namespace MealPlan
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split();
            var line1 = Console.ReadLine().Split().Select(int.Parse).ToList();

            var queue = new Queue<string>(line);
            var stack = new Stack<int>(line1);
            var totalCount = queue.Count;


            while (queue.Any() && stack.Any())
            {

                if (queue.Peek() == "salad")
                {

                    if (stack.Peek() - 350 > 0)
                    {
                        var currNum = stack.Peek() - 350;
                        queue.Dequeue();
                        stack.Pop();
                        stack.Push(currNum);
                    }
                    else
                    {

                        var a = 350 - stack.Peek();
                        stack.Pop();
                        if (stack.Count > 0)
                        {
                            var currNum = stack.Peek() - a;
                            stack.Pop();
                            stack.Push(currNum);
                        }
                        queue.Dequeue();


                    }



                }
                else if (queue.Peek() == "soup")
                {

                    if (stack.Peek() - 490 > 0)
                    {
                        var currNum = stack.Peek() - 490;
                        stack.Pop();
                        stack.Push(currNum);
                        queue.Dequeue();
                    }
                    else
                    {

                        var a = 490 - stack.Peek();
                        stack.Pop();
                        if (stack.Count > 0)
                        {
                            var currNum = stack.Peek() - a;
                            stack.Pop();
                            stack.Push(currNum);
                        }
                        queue.Dequeue();


                    }


                }
                else if (queue.Peek() == "pasta")
                {

                    if (stack.Peek() - 680 > 0)
                    {
                        var currNum = stack.Peek() - 680;
                        stack.Pop();
                        stack.Push(currNum);
                        queue.Dequeue();
                    }
                    else
                    {

                        var a = 680 - stack.Peek();
                        stack.Pop();
                        if (stack.Count > 0)
                        {
                            var currNum = stack.Peek() - a;
                            stack.Pop();
                            stack.Push(currNum);
                        }
                        queue.Dequeue();


                    }



                }
                else if (queue.Peek() == "steak")
                {

                    if (stack.Peek() - 790 > 0)
                    {
                        var currNum = stack.Peek() - 790;
                        stack.Pop();
                        stack.Push(currNum);
                        queue.Dequeue();
                    }
                    else
                    {

                        var a = 790 - stack.Peek();
                        stack.Pop();
                        if (stack.Count > 0)
                        {
                            var currNum = stack.Peek() - a;
                            stack.Pop();
                            stack.Push(currNum);
                        }
                        queue.Dequeue();
                    }
                }


            }

            if (queue.Count == 0)
            {
                Console.WriteLine($"John had {totalCount} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", stack)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {totalCount - queue.Count} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", queue)}.");
            }


        }
    }
}
