using System;
using System.Linq;
using System.Collections.Generic;

namespace Seiling
{
    internal class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var matrix = new string[num, num];
            var currRow = 0;
            var currCol = 0;
            var money = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
                    if (matrix[row, col] == "S")
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "right")
                {
                    if (currCol + 1 < matrix.GetLength(0))
                    {
                        if (matrix[currRow, currCol + 1] == "O")
                        {
                            matrix[currRow, currCol + 1] = "-";
                            matrix[currRow, currCol] = "-";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "O")
                                    {
                                        matrix[row, col] = "S";
                                        currRow = row;
                                        currCol = col;
                                    }
                                }
                            }

                        }
                        else
                        {
                            if (matrix[currRow, currCol + 1] != "-")
                            {
                                var price = int.Parse(matrix[currRow, currCol + 1]);
                                money += price;
                                matrix[currRow, currCol + 1] = "S";
                                matrix[currRow, currCol] = "-";
                                currCol++;
                                if (money >= 50)
                                {
                                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                                    Console.WriteLine($"Money: {money}");
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
                            else
                            {
                                matrix[currRow, currCol + 1] = "S";
                                matrix[currRow, currCol] = "-";
                                currCol++;

                            }

                        }

                    }
                    else
                    {
                        matrix[currRow, currCol] = "-";
                        break;
                    }
                }
                if (line == "left")
                {
                    if (currCol - 1 >= 0)
                    {
                        if (matrix[currRow, currCol - 1] == "O")
                        {
                            matrix[currRow, currCol - 1] = "-";
                            matrix[currRow, currCol] = "-";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "O")
                                    {
                                        matrix[row, col] = "S";
                                        currRow = row;
                                        currCol = col;
                                    }
                                }
                            }

                        }
                        else
                        {
                            if (matrix[currRow, currCol - 1] != "-")
                            {
                                var price = int.Parse(matrix[currRow, currCol - 1]);
                                money += price;
                                matrix[currRow, currCol - 1] = "S";
                                matrix[currRow, currCol] = "-";
                                currCol = currCol - 1;
                                if (money >= 50)
                                {
                                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                                    Console.WriteLine($"Money: {money}");
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
                            else
                            {
                                matrix[currRow, currCol - 1] = "S";
                                matrix[currRow, currCol] = "-";
                                currCol = currCol - 1;
                            }
                        }

                    }
                    else
                    {
                        matrix[currRow, currCol] = "-";
                        break;
                    }
                }
                if (line == "up")
                {

                    if (currRow - 1 >= 0)
                    {
                        if (matrix[currRow - 1, currCol] == "O")
                        {
                            matrix[currRow - 1, currCol] = "-";
                            matrix[currRow, currCol] = "-";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "O")
                                    {
                                        matrix[row, col] = "S";
                                        currRow = row;
                                        currCol = col;
                                    }
                                }
                            }

                        }
                        else
                        {
                            if (matrix[currRow - 1, currCol] != "-")
                            {
                                var price = int.Parse(matrix[currRow - 1, currCol]);
                                money += price;
                                matrix[currRow - 1, currCol] = "S";
                                matrix[currRow, currCol] = "-";
                                currRow--;
                                if (money >= 50)
                                {
                                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                                    Console.WriteLine($"Money: {money}");
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
                            else
                            {
                                matrix[currRow - 1, currCol] = "S";
                                matrix[currRow, currCol] = "-";
                                currRow--;
                            }
                        }

                    }
                    else
                    {
                        matrix[currRow, currCol] = "-";
                        break;
                    }
                }
                if (line == "down")
                {

                    if (currRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[currRow + 1, currCol] == "O")
                        {
                            matrix[currRow + 1, currCol] = "-";
                            matrix[currRow, currCol] = "-";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "O")
                                    {
                                        matrix[row, col] = "S";
                                        currRow = row;
                                        currCol = col;
                                    }
                                }
                            }

                        }
                        else
                        {
                            if (matrix[currRow + 1, currCol] != "-")
                            {
                                var price = int.Parse(matrix[currRow + 1, currCol]);
                                money += price;
                                matrix[currRow + 1, currCol] = "S";
                                matrix[currRow, currCol] = "-";
                                currRow++;
                                if (money >= 50)
                                {
                                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                                    Console.WriteLine($"Money: {money}");
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
                            else
                            {
                                matrix[currRow + 1, currCol] = "S";
                                matrix[currRow, currCol] = "-";
                                currRow++;
                            }
                        }

                    }
                    else
                    {
                        matrix[currRow, currCol] = "-";
                        break;
                    }
                }
            }
            Console.WriteLine("Bad news, you are out of the bakery.");
            Console.WriteLine($"Money: {money}");
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
