using System;
using System.Linq;
using System.Collections.Generic;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main()
        {
            var dimention = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var matrix = new int[dimention[0], dimention[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];

                }
            }


            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                var a = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    a += matrix[row, col];
                }
                Console.WriteLine(a);
            }
        }
    }
}

