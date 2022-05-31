using System;
using System.Linq;
using System.Collections.Generic;

namespace Armory
{
    internal class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var matrix = new string[num, num];
            var currentRow = 0;
            var currentCol = 0;
            var gold = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
                    if (matrix[row, col] == "A")
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                }
            }

            while (true)
            {
               
                if (gold >= 65)
                {
                    break;
                }
                var cmd = Console.ReadLine().Split();
                if (cmd[0] == "right")
                {
                   
                    if(currentCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[currentRow, currentCol + 1] == "M")
                        {
                            matrix[currentRow, currentCol + 1] = "-";
                            matrix[currentRow, currentCol] = "-";
                            currentCol = currentCol + 1;
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "M")
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = "A";
                                    }
                                }

                            }
                        }
                        else if (matrix[currentRow, currentCol + 1] != "M" && matrix[currentRow, currentCol + 1] != "-")
                        {
                            var n = int.Parse(matrix[currentRow, currentCol + 1]);
                            gold += n;
                            matrix[currentRow, currentCol + 1] = "A";
                            matrix[currentRow, currentCol] = "-";
                            currentCol = currentCol + 1;
                           

                        }
                        else
                        {
                            matrix[currentRow, currentCol + 1] = "A";
                            matrix[currentRow, currentCol] = "-";
                            currentCol += 1;
                        }                                             
                    }
                    else
                    {
                        matrix[currentRow,currentCol] = "-";
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {gold} gold coins.");
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
                        if (matrix[currentRow, currentCol - 1] == "M")
                        {
                            matrix[currentRow, currentCol - 1] = "-";
                            matrix[currentRow, currentCol] = "-";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "M")
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = "A";
                                    }
                                }

                            }
                        }
                        else if (matrix[currentRow, currentCol - 1] != "M" && matrix[currentRow, currentCol - 1] != "-")
                        {
                            var n = int.Parse(matrix[currentRow, currentCol - 1]);
                            gold += n;
                            matrix[currentRow, currentCol - 1] = "A";
                            matrix[currentRow, currentCol] = "-";
                            currentCol = currentCol - 1;

                        }
                        else
                        {
                            matrix[currentRow, currentCol - 1] = "A";
                            matrix[currentRow, currentCol] = "-";
                            currentCol -= 1;
                        }
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = "-";
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {gold} gold coins.");
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
                        if (matrix[currentRow - 1, currentCol] == "M")
                        {
                            matrix[currentRow - 1, currentCol] = "-";
                            matrix[currentRow, currentCol] = "-";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "M")
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = "A";
                                    }
                                }

                            }
                        }
                        else if (matrix[currentRow - 1, currentCol] != "M" && matrix[currentRow - 1, currentCol] != "-")
                        {
                            var n = int.Parse(matrix[currentRow - 1, currentCol]);
                            gold += n;
                            matrix[currentRow - 1, currentCol] = "A";
                            matrix[currentRow, currentCol] = "-";
                            currentRow -= 1;

                        }
                        else
                        {
                            matrix[currentRow - 1, currentCol] = "A";
                            matrix[currentRow, currentCol] = "-";
                            currentRow -= 1;
                        }                    
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = "-";
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {gold} gold coins.");                       
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
                        if (matrix[currentRow + 1, currentCol] == "M")
                        {
                            matrix[currentRow + 1, currentCol] = "-";
                            matrix[currentRow, currentCol] = "-";
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    if (matrix[row, col] == "M")
                                    {
                                        currentRow = row;
                                        currentCol = col;
                                        matrix[row, col] = "A";
                                    }
                                }

                            }
                        }
                        else if (matrix[currentRow + 1, currentCol] != "M" && matrix[currentRow + 1, currentCol] != "-")
                        {
                            var n = int.Parse(matrix[currentRow + 1, currentCol]);
                            gold += n;
                            matrix[currentRow + 1, currentCol] = "A";
                            matrix[currentRow, currentCol] = "-";
                            currentRow += 1;

                        }
                        else
                        {
                            matrix[currentRow + 1, currentCol] = "A";
                            matrix[currentRow, currentCol] = "-";
                            currentRow += 1;
                        }   
                    }
                    else
                    {
                        matrix[currentRow, currentCol] = "-";
                        Console.WriteLine("I do not need more swords!");
                        Console.WriteLine($"The king paid {gold} gold coins.");                      
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
            Console.WriteLine("Very nice swords, I will come back for more!");
            Console.WriteLine($"The king paid {gold} gold coins.");



            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]); 
                }
                Console.WriteLine();

            }

        }

    }
}

