using System;
using System.Collections.Generic;

namespace Help_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new string[n, n];
            var currRow = 0;
            var currCol = 0;
            var points = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
                    if (matrix[row, col] == "M")
                    {
                        currRow= row;
                        currCol = col;
                    }
                }
            }
            while(true)
            {
                if(points >= 25)
                {
                    break;
                }
                var cmd = Console.ReadLine();
                if(cmd == "End")
                {
                    break;
                }
                if(cmd == "right")
                {
                    if (currCol + 1 > matrix.GetLength(1) - 1)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        
                    }
                    else if (matrix[currRow, currCol + 1] == "S")
                    {
                        matrix[currRow, currCol] = "-";
                        matrix[currRow, currCol + 1] = "-";
                        var coordRow = 0;
                        var coordCol = 0;   
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {                           
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                if (matrix[row, col] == "S")
                                {
                                    coordRow = row;
                                    coordCol= col;
                                }
                            }
                        }
                        matrix[coordRow, coordCol] = "M";
                        currRow = coordRow;
                        currCol = coordCol;
                        points -= 3;

                    }
                    else
                    {
                        if (matrix[currRow,currCol + 1] != "-")
                        {
                            var a = int.Parse(matrix[currRow, currCol + 1]);
                            points += a;
                        }
                        matrix[currRow, currCol] = "-";
                        matrix[currRow, currCol + 1] = "M";
                        currCol++;
                    }                   
                }
                else if(cmd == "left")
                {
                    if (currCol - 1 < 0)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");

                    }
                    else if (matrix[currRow, currCol - 1] == "S")
                    {
                        matrix[currRow, currCol] = "-";
                        matrix[currRow, currCol - 1] = "-";
                        var coordRow = 0;
                        var coordCol = 0;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                if (matrix[row, col] == "S")
                                {
                                    coordRow = row;
                                    coordCol = col;
                                }
                            }
                        }
                        matrix[coordRow, coordCol] = "M";
                        currRow = coordRow;
                        currCol = coordCol;
                        points -= 3;

                    }
                    else
                    {
                        if (matrix[currRow, currCol - 1] != "-")
                        {
                            var a = int.Parse(matrix[currRow, currCol - 1]);
                            points += a;
                        }
                        matrix[currRow, currCol] = "-";
                        matrix[currRow, currCol - 1] = "M";
                        currCol--;
                    }                  
                }
                else if(cmd == "down")
                {
                    if (currRow + 1 > matrix.GetLength(0) - 1)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");

                    }
                    else if (matrix[currRow + 1, currCol] == "S")
                    {
                        matrix[currRow, currCol] = "-";
                        matrix[currRow + 1, currCol] = "-";
                        var coordRow = 0;
                        var coordCol = 0;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                if (matrix[row, col] == "S")
                                {
                                    coordRow = row;
                                    coordCol = col;
                                }
                            }
                        }
                        matrix[coordRow, coordCol] = "M";
                        currRow = coordRow;
                        currCol = coordCol;
                        points -= 3;

                    }
                    else
                    {
                        if (matrix[currRow + 1, currCol] != "-")
                        {
                            var a = int.Parse(matrix[currRow + 1, currCol]);
                            points += a;
                        }
                        matrix[currRow, currCol] = "-";
                        matrix[currRow + 1, currCol] = "M";
                        currRow++;
                    }                
                }
                else if(cmd == "up")
                {
                    if (currRow - 1 < 0)
                    {
                        Console.WriteLine("Don't try to escape the playing field!");

                    }
                    else if (matrix[currRow - 1, currCol] == "S")
                    {
                        matrix[currRow, currCol] = "-";
                        matrix[currRow - 1, currCol] = "-";
                        var coordRow = 0;
                        var coordCol = 0;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                if (matrix[row, col] == "S")
                                {
                                    coordRow = row;
                                    coordCol = col;
                                }
                            }
                        }
                        matrix[coordRow, coordCol] = "M";
                        currRow = coordRow;
                        currCol = coordCol;
                        points -= 3;

                    }
                    else
                    {
                        if (matrix[currRow - 1, currCol] != "-")
                        {
                            var a = int.Parse(matrix[currRow - 1, currCol]);
                            points += a;
                        }
                        matrix[currRow, currCol] = "-";
                        matrix[currRow - 1, currCol] = "M";
                        currRow--;
                    }                  
                }
            }
            if(points >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            }
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
