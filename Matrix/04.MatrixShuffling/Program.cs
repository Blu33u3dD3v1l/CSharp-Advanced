using System;
using System.Linq;
using System.Collections.Generic;

namespace MatrixShuffling
{
    internal class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var matrix = new string[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                var cmd = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cmd[col];
                }
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var tokens = line.Split();
                if (tokens[0] != "swap" || tokens.Length != 5)
                {
                    Console.WriteLine("Invalid input!");

                }
                else
                {
                    var n1 = int.Parse(tokens[1]);
                    var n2 = int.Parse(tokens[2]);
                    var n3 = int.Parse(tokens[3]);
                    var n4 = int.Parse(tokens[4]);
                    if (n1 < matrix.GetLength(0) && n3 < matrix.GetLength(0) && n2 < matrix.GetLength(1) && n4 < matrix.GetLength(1))
                    {
                        var a = matrix[n1, n2];
                        var b = matrix[n3, n4];
                        matrix[n1, n2] = b;
                        matrix[n3, n4] = a;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
            }
        }
    }
}



