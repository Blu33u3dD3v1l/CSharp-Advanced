using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingSome
{
    public class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var matrix = new string[num, num];

            var currRow = 0;
            var currCow = 0;

            var holes = 0;
            var rods = 0;

            bool electricity = false;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
                    if (matrix[row, col] == "V")
                    {
                        currRow = row;
                        currCow = col;
                    }

                }
            }
            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "End")
                {
                    break;
                }
                if (cmd == "right")
                {
                    if (currCow + 1 < matrix.GetLength(1))
                    {
                        if (matrix[currRow, currCow + 1] != "R" && matrix[currRow, currCow + 1] != "C" && matrix[currRow, currCow + 1] != "*")
                        {
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow, currCow + 1] = a;
                            holes++;
                            currCow++;
                        }
                        else if (matrix[currRow, currCow + 1] == "R")
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rods++;
                        }
                        else if (matrix[currRow, currCow + 1] == "C")
                        {
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow, currCow + 1] = "E";
                            holes += 2;
                            electricity = true;
                            currCow++;
                            break;
                        }
                        else if (matrix[currRow, currCow + 1] == "*")
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCow + 1}]!");
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow, currCow + 1] = a;
                            currCow++;

                        }
                    }
                }
                if (cmd == "left")
                {
                    if (currCow - 1 >= 0)
                    {
                        if (matrix[currRow, currCow - 1] != "R" && matrix[currRow, currCow - 1] != "C" && matrix[currRow, currCow - 1] != "*")
                        {
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow, currCow - 1] = a;
                            holes++;
                            currCow--;
                        }
                        else if (matrix[currRow, currCow - 1] == "R")
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rods++;
                        }
                        else if (matrix[currRow, currCow - 1] == "C")
                        {
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow, currCow - 1] = "E";
                            holes += 2;
                            electricity = true;
                            currCow--;
                            break;
                        }
                        else if (matrix[currRow, currCow - 1] == "*")
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow}, {currCow - 1}]!");
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow, currCow - 1] = a;
                            currCow--;
                        }
                    }
                }

                if (cmd == "down")
                {
                    if (currRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[currRow + 1, currCow] != "R" && matrix[currRow + 1, currCow] != "C" && matrix[currRow + 1, currCow] != "*")
                        {
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow + 1, currCow] = a;
                            holes++;
                            currRow++;
                        }
                        else if (matrix[currRow + 1, currCow] == "R")
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rods++;
                        }
                        else if (matrix[currRow + 1, currCow] == "C")
                        {
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow + 1, currCow] = "E";
                            holes += 2;
                            electricity = true;
                            currRow++;
                            break;
                        }
                        else if (matrix[currRow + 1, currCow] == "*")
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow + 1}, {currCow}]!");
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow + 1, currCow] = a;
                            currRow++;
                        }
                    }
                }
                if (cmd == "up")
                {
                    if (currRow - 1 >= 0)
                    {
                        if (matrix[currRow - 1, currCow] != "R" && matrix[currRow - 1, currCow] != "C" && matrix[currRow - 1, currCow] != "*")
                        {
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow - 1, currCow] = a;
                            holes++;
                            currRow--;
                        }
                        else if (matrix[currRow - 1, currCow] == "R")
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            rods++;
                        }
                        else if (matrix[currRow - 1, currCow] == "C")
                        {
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow - 1, currCow] = "E";
                            holes += 2;
                            electricity = true;
                            currRow--;
                            break;
                        }
                        else if (matrix[currRow - 1, currCow] == "*")
                        {
                            Console.WriteLine($"The wall is already destroyed at position [{currRow - 1}, {currCow}]!");
                            var a = matrix[currRow, currCow];
                            matrix[currRow, currCow] = "*";
                            matrix[currRow - 1, currCow] = a;
                            currRow--;
                        }
                    }
                }
            }
            if (electricity == false)
            {
                Console.WriteLine($"Vanko managed to make {holes + 1} hole(s) and he hit only {rods} rod(s).");
            }
            else
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holes} hole(s).");
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
