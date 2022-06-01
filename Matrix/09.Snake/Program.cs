using System;
using System.Linq;
using System.Collections.Generic;

namespace Snake
{
    internal class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var matrix = new string[num, num];
            var currentRow = 0;
            var currentCol = 0;
            var food = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
                    if (matrix[row, col] == "S")
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            while (true)
            {

                if (food >= 10)
                {
                    break;
                }
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "right")
                {

                    if (currentCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[currentRow, currentCol + 1] == "B")
                        {
                            matrix[currentRow, currentCol + 1] = ".";
                            matrix[currentRow, currentCol] = ".";
                            currentCol = currentCol + 1;
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "B")
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = "S";
                                    }
                                }

                            }
                        }
                        else if (matrix[currentRow, currentCol + 1] != "B" && matrix[currentRow, currentCol + 1] != "-")
                        {
                            food++;
                            matrix[currentRow, currentCol + 1] = "S";
                            matrix[currentRow, currentCol] = ".";
                            currentCol = currentCol + 1;


                        }
                        else
                        {
                            matrix[currentRow, currentCol + 1] = "S";
                            matrix[currentRow, currentCol] = ".";
                            currentCol += 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = ".";
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col]);
                            }
                            Console.WriteLine();

                        }
                        Environment.Exit(0);
                    }

                }
                if (cmd[0] == "left")
                {
                    if (currentCol - 1 >= 0)
                    {
                        if (matrix[currentRow, currentCol - 1] == "B")
                        {
                            matrix[currentRow, currentCol - 1] = ".";
                            matrix[currentRow, currentCol] = ".";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "B")
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = "S";
                                    }
                                }

                            }
                        }
                        else if (matrix[currentRow, currentCol - 1] != "B" && matrix[currentRow, currentCol - 1] != "-")
                        {
                            food++;
                            matrix[currentRow, currentCol - 1] = "S";
                            matrix[currentRow, currentCol] = ".";
                            currentCol = currentCol - 1;

                        }
                        else
                        {
                            matrix[currentRow, currentCol - 1] = "S";
                            matrix[currentRow, currentCol] = ".";
                            currentCol -= 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = ".";
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col]);
                            }
                            Console.WriteLine();

                        }
                        Environment.Exit(0);
                    }
                }
                if (cmd[0] == "up")
                {
                    if (currentRow - 1 >= 0)
                    {
                        if (matrix[currentRow - 1, currentCol] == "B")
                        {
                            matrix[currentRow - 1, currentCol] = ".";
                            matrix[currentRow, currentCol] = ".";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "B")
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = "S";
                                    }
                                }

                            }
                        }
                        else if (matrix[currentRow - 1, currentCol] != "B" && matrix[currentRow - 1, currentCol] != "-")
                        {
                            food++;
                            matrix[currentRow - 1, currentCol] = "S";
                            matrix[currentRow, currentCol] = ".";
                            currentRow -= 1;

                        }
                        else
                        {
                            matrix[currentRow - 1, currentCol] = "S";
                            matrix[currentRow, currentCol] = ".";
                            currentRow -= 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = ".";
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col]);
                            }
                            Console.WriteLine();

                        }
                        Environment.Exit(0);
                    }

                }
                if (cmd[0] == "down")
                {
                    if (currentRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[currentRow + 1, currentCol] == "B")
                        {
                            matrix[currentRow + 1, currentCol] = ".";
                            matrix[currentRow, currentCol] = ".";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "B")
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = "S";
                                    }
                                }

                            }
                        }
                        else if (matrix[currentRow + 1, currentCol] != "B" && matrix[currentRow + 1, currentCol] != "-")
                        {
                            food++;
                            matrix[currentRow + 1, currentCol] = "S";
                            matrix[currentRow, currentCol] = ".";
                            currentRow += 1;

                        }
                        else
                        {
                            matrix[currentRow + 1, currentCol] = "S";
                            matrix[currentRow, currentCol] = ".";
                            currentRow += 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = ".";
                        Console.WriteLine("Game over!");
                        Console.WriteLine($"Food eaten: {food}");
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row, col]);
                            }
                            Console.WriteLine();

                        }
                        Environment.Exit(0);
                    }

                }
            }
            Console.WriteLine("You won! You fed the snake.");
            Console.WriteLine($"Food eaten: {food}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();

            }

        }

    }
}
