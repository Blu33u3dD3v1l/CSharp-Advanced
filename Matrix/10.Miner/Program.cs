using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    public class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine().Split().ToList();
            var matrix = new string[num, num];
            var currRow = 0;
            var currCol = 0;
            var coals = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().Split();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
                    if (matrix[row,col] == "s")
                    {
                        currRow = row;
                        currCol = col;
                    }
                    if(matrix[row, col] == "c")
                    {
                        coals++;
                    }

                }
            }       
            for (int i = 0; i < commands.Count; i++)
            {
                if(coals == 0)
                {
                    break;
                }
                if (commands[i] == "right")
                {
                    if(currCol + 1 < matrix.GetLength(1))
                    {
                        if(matrix[currRow, currCol + 1] == "c")
                        {
                           
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "*";
                            matrix[currRow,currCol + 1] = a;
                            currCol++;
                            coals--;

                        }
                        else if (matrix[currRow, currCol + 1] == "e")
                        {
                            currCol++;
                            Console.WriteLine($"Game over! ({currRow}, {currCol})");
                            Environment.Exit(0);
                        }
                        else if(matrix[currRow, currCol + 1] == "*")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "*";
                            matrix[currRow, currCol + 1] = a;
                            currCol++;

                        }
                    }
                  
                }
               else if (commands[i] == "left")
                {
                    if (currCol - 1 >= 0)
                    {
                        if (matrix[currRow, currCol - 1] == "c")
                        {

                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "*";
                            matrix[currRow, currCol - 1] = a;
                            currCol--;
                            coals--;

                        }
                        else if (matrix[currRow, currCol - 1] == "e")
                        {
                            currCol--;
                            Console.WriteLine($"Game over! ({currRow}, {currCol})");
                            Environment.Exit(0);
                        }
                       else if (matrix[currRow, currCol - 1] == "*")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "*";
                            matrix[currRow, currCol - 1] = a;
                            currCol--;

                        }
                    }
                  
                }
               else if(commands[i] == "up")
                {
                    if (currRow - 1 >= 0)
                    {
                        if (matrix[currRow - 1, currCol] == "c")
                        {

                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "*";
                            matrix[currRow - 1, currCol] = a;
                            currRow--;
                            coals--;

                        }
                       else if (matrix[currRow - 1, currCol] == "e")
                        {
                            currRow--;
                            Console.WriteLine($"Game over! ({currRow}, {currCol})");
                            Environment.Exit(0);
                        }
                        else if(matrix[currRow - 1, currCol] == "*")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "*";
                            matrix[currRow - 1, currCol] = a;
                            currRow--;

                        }
                    }
                   
                }
               else if (commands[i] == "down")
                {
                    if (currRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[currRow + 1, currCol] == "c")
                        {

                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "*";
                            matrix[currRow + 1, currCol] = a;
                            currRow++;
                            coals--;

                        }
                        else if (matrix[currRow + 1, currCol] == "e")
                        {
                            currRow++;
                            Console.WriteLine($"Game over! ({currRow}, {currCol})");
                            Environment.Exit(0);
                        }
                        else if(matrix[currRow + 1, currCol] == "*")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "*";
                            matrix[currRow + 1, currCol] = a;
                            currRow++;

                        }
                    }
                   
                }
              
            }
            if (coals == 0)
            {
                Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
            }
            else
            {
                Console.WriteLine($"{coals} coals left. ({currRow}, {currCol})");
            }
        
        }
    }
}
