using System;
using System.Linq;
using System.Collections.Generic;

namespace Bee
{
    internal class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var matrix = new string[num, num];
            var currRow = 0;
            var currCol = 0;
            var flower = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
                    if (matrix[row, col] == "B")
                    {
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            while (true)
            {
                var line = Console.ReadLine();
                if(line == "End")
                {
                    break;
                }
                if (line == "right")
                {
                    if (currCol + 1 < matrix.GetLength(0))
                    {
                        if (matrix[currRow, currCol + 1] == "O")
                        {
                           
                                    if (matrix[currRow, currCol + 2] != "f")
                                    {
                                        matrix[currRow, currCol + 1] = ".";
                                        matrix[currRow, currCol] = ".";
                                        matrix[currRow, currCol + 2] = "B";
                                        currCol += 2;
                                    }
                                    else
                                    {
                                        flower++;
                                        matrix[currRow, currCol + 1] = ".";
                                        matrix[currRow, currCol] = ".";
                                        matrix[currRow, currCol + 2] = "B";
                                        currCol += 2;

                                    }                               
                        }
                        else
                        {
                            if (matrix[currRow, currCol + 1] != ".")
                            {
                                flower++;
                                matrix[currRow, currCol + 1] = "B";
                                matrix[currRow, currCol] = ".";
                                currCol++;
                              
                            }
                            else
                            {
                                matrix[currRow, currCol + 1] = "B";
                                matrix[currRow, currCol] = ".";
                                currCol++;

                            }

                        }                     
                    }                
                    else
                    {
                        matrix[currRow, currCol] = ".";
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                   
                }
                if (line == "left")
                {
                    if (currCol - 1 >= 0)
                    {
                        if (matrix[currRow, currCol - 1] == "O")
                        {
                            
                                if (matrix[currRow, currCol - 2] != "f")
                                {
                                    matrix[currRow, currCol - 1] = ".";
                                    matrix[currRow, currCol] = ".";
                                    matrix[currRow, currCol - 2] = "B";
                                    currCol -= 2;
                                }
                                else
                                {
                                    flower++;
                                    matrix[currRow, currCol - 1] = ".";
                                    matrix[currRow, currCol] = ".";
                                    matrix[currRow, currCol - 2] = "B";
                                    currCol -= 2;

                                }                         
                        }
                        else
                        {
                            if (matrix[currRow, currCol - 1] != ".")
                            {
                                flower++;
                                matrix[currRow, currCol - 1] = "B";
                                matrix[currRow, currCol] = ".";
                                currCol = currCol - 1;
                               
                                
                            }
                            else
                            {
                                matrix[currRow, currCol - 1] = "B";
                                matrix[currRow, currCol] = ".";
                                currCol = currCol - 1;
                            }
                        }                     
                    }
                    else
                    {
                        matrix[currRow, currCol] = ".";
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                   
                }
                if (line == "up")
                {

                    if (currRow - 1 >= 0)
                    {
                        if (matrix[currRow - 1, currCol] == "O")
                        {
                            
                                if(matrix[currRow - 2, currCol] != "f")
                                {
                                    matrix[currRow - 1, currCol] = ".";
                                    matrix[currRow, currCol] = ".";
                                    matrix[currRow - 2, currCol] = "B";
                                    currRow -= 2;

                                }
                                else
                                {
                                    matrix[currRow - 1, currCol] = ".";
                                    matrix[currRow, currCol] = ".";
                                    matrix[currRow - 2, currCol] = "B";
                                    currRow -= 2;
                                }                        
                        }
                        else
                        {
                            if (matrix[currRow - 1, currCol] != ".")
                            {
                                flower++;
                                matrix[currRow - 1, currCol] = "B";
                                matrix[currRow, currCol] = ".";
                                currRow--;
                             
                            }
                            else
                            {
                                matrix[currRow - 1, currCol] = "B";
                                matrix[currRow, currCol] = ".";
                                currRow--;
                            }
                        }

                    }
                    else
                    {
                        matrix[currRow, currCol] = ".";
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                   
                }
                if (line == "down")
                {

                    if (currRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[currRow + 1, currCol] == "O")
                        {


                            if (matrix[currRow + 2, currCol] != "f")
                            {
                                matrix[currRow + 1, currCol] = ".";
                                matrix[currRow, currCol] = ".";
                                matrix[currRow + 2, currCol] = "B";
                                currRow += 2;
                            }
                            else
                            {
                                flower++;
                                matrix[currRow + 1, currCol] = ".";
                                matrix[currRow, currCol] = ".";
                                matrix[currRow + 2, currCol] = "B";
                                currRow += 2;
                            }
                        }
                        else
                        {
                            if (matrix[currRow + 1, currCol] != ".")
                            {
                                flower++;
                                matrix[currRow + 1, currCol] = "B";
                                matrix[currRow, currCol] = ".";
                                currRow++;

                            }
                            else
                            {
                                matrix[currRow + 1, currCol] = "B";
                                matrix[currRow, currCol] = ".";
                                currRow++;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The bee got lost!");
                        matrix[currRow, currCol] = ".";
                        break;
                    }                  
                }
            }
            if(flower >= 5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flower} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - flower} flowers more");
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
