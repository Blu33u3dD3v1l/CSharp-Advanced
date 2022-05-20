using System;
using System.Linq;
using System.Collections.Generic;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main()
        {

            var num = int.Parse(Console.ReadLine());
            var matrix = new int[num, num];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];


                }
            }
            var a = 0;

            for (int i = 0; i < num; i++)
            {
                a += matrix[i, 0 + i];
            }
            Console.WriteLine(a);
        }

    }
}