using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main()
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            var bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            var intelligence = int.Parse(Console.ReadLine());
            var all = 0;
            var counterBullet = gunBarrelSize;


            while (true)
            {
                if (bullets.Count == 0 || locks.Count == 0)
                {
                    break;
                }
                var bullet = bullets.Peek();
                var Lock = locks.Peek();

                if (bullet <= Lock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();

                }
                else
                {
                    Console.WriteLine("Ping!");

                }
                bullets.Pop();
                all++;
                counterBullet--;


                if (counterBullet == 0 && bullets.Count > 0)
                {
                    counterBullet = gunBarrelSize;
                    Console.WriteLine("Reloading!");
                }


            }

            var area = intelligence - (all * priceOfBullet); ;
            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${area}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }

        }
    }
}
