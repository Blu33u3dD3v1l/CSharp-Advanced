using System;
using System.Linq;
using System.Collections.Generic;


namespace SuperMario
{
    internal class Program
    {
        static void Main()
        {
            var life = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var jagged = new string[n][];
            var currRow = 0;
            var currCol = 0;
            var reachThePrinces = false;


            for (int row = 0; row < jagged.Length; row++)
            {
                var cols = Console.ReadLine();
                jagged[row] = new string[cols.Length];
                for (int col = 0; col < cols.Length; col++)
                {
                    jagged[row][col] = cols[col].ToString();
                    if (jagged[row][col] == "M")
                    {

                        currRow = row;
                        currCol = col;
                    }

                }
            }
            while (true)
            {
                var line = Console.ReadLine();
                var tokens = line.Split();
                if (tokens[0] == "W")
                {
                    var n1 = int.Parse(tokens[1]);
                    var n2 = int.Parse(tokens[2]);
                    jagged[n1][n2] = "B";
                    if (currRow - 1 >= 0)
                    {
                        if (jagged[currRow - 1][currCol] != "B" && jagged[currRow - 1][currCol] != "P")
                        {

                            life--;
                            if (life <= 0)
                            {

                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow - 1][currCol] = "X";
                                currRow--;
                                break;

                            }
                            else
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow - 1][currCol] = a;
                                currRow--;
                            }
                        }
                        else if (jagged[currRow - 1][currCol] == "B")
                        {

                            life -= 3;
                            if (life <= 0)
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow - 1][currCol] = "X";
                                currRow--;
                                break;

                            }
                            else
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow - 1][currCol] = a;
                                currRow--;
                            }
                        }
                        else if (jagged[currRow - 1][currCol] == "P")
                        {
                            life--;
                            var a = jagged[currRow][currCol];
                            jagged[currRow][currCol] = "-";
                            jagged[currRow - 1][currCol] = "-";
                            currRow--;
                            reachThePrinces = true;
                            break;

                        }

                    }
                    else
                    {
                        life--;
                        if (life <= 0)
                        {
                            break;
                        }
                    }
                    //foreach (var item in jagged)
                    //{
                    //    Console.WriteLine(String.Join("", item));
                    //}
                }
                if (tokens[0] == "A")
                {
                    var n1 = int.Parse(tokens[1]);
                    var n2 = int.Parse(tokens[2]);
                    jagged[n1][n2] = "B";
                    if (currCol - 1 >= 0)
                    {
                        if (jagged[currRow][currCol - 1] != "B" && jagged[currRow][currCol - 1] != "P")
                        {

                            life--;
                            if (life <= 0)
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow][currCol - 1] = "X";
                                currCol--;
                                break;

                            }
                            else
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow][currCol - 1] = a;
                                currCol--;
                            }
                        }
                        else if (jagged[currRow][currCol - 1] == "B")
                        {

                            life -= 3;
                            if (life <= 0)
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow][currCol - 1] = "X";
                                currCol--;
                                break;

                            }
                            else
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow][currCol - 1] = a;
                                currCol--;
                            }
                        }
                        else if (jagged[currRow][currCol - 1] == "P")
                        {
                            life--;
                            var a = jagged[currRow][currCol];
                            jagged[currRow][currCol] = "-";
                            jagged[currRow][currCol - 1] = "-";
                            currCol--;
                            reachThePrinces = true;
                            break;
                        }

                    }
                    else
                    {
                        life--;
                        if (life <= 0)
                        {
                            break;
                        }
                    }
                    //foreach (var item in jagged)
                    //{
                    //    Console.WriteLine(String.Join("", item));
                    //}
                }
                if (tokens[0] == "S")
                {
                    var n1 = int.Parse(tokens[1]);
                    var n2 = int.Parse(tokens[2]);
                    jagged[n1][n2] = "B";
                    if (currRow + 1 < jagged.Length)
                    {
                        if (jagged[currRow + 1][currCol] != "B" && jagged[currRow + 1][currCol] != "P")
                        {

                            life--;
                            if (life <= 0)
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow + 1][currCol] = "-";
                                jagged[currRow][currCol] = "X";
                                currRow++;
                                break;
                            }
                            else
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow + 1][currCol] = a;
                                currRow++;
                            }

                        }
                        else if (jagged[currRow + 1][currCol] == "B")
                        {


                            life -= 3;
                            if (life <= 0)
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow + 1][currCol] = "X";
                                currRow++;
                                break;

                            }
                            else
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow + 1][currCol] = a;
                                currRow++;
                            }
                        }
                        else if (jagged[currRow + 1][currCol] == "P")
                        {
                            life--;
                            var a = jagged[currRow][currCol];
                            jagged[currRow][currCol] = "-";
                            jagged[currRow + 1][currCol] = "-";
                            currRow++;
                            reachThePrinces = true;
                            break;
                        }

                    }
                    else
                    {
                        life--;
                        if (life <= 0)
                        {
                            break;
                        }
                    }
                    //foreach (var item in jagged)
                    //{
                    //    Console.WriteLine(String.Join("", item));
                    //}
                }
                if (tokens[0] == "D")
                {
                    var n1 = int.Parse(tokens[1]);
                    var n2 = int.Parse(tokens[2]);
                    jagged[n1][n2] = "B";
                    if (currCol + 1 < jagged[currCol].Length)
                    {

                        if (jagged[currRow][currCol + 1] != "B" && jagged[currRow][currCol + 1] != "P")
                        {

                            life--;
                            if (life <= 0)
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow][currCol + 1] = "X";
                                currCol++;
                                break;

                            }
                            else
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow][currCol + 1] = a;
                                currCol++;
                            }
                        }
                        else if (jagged[currRow][currCol + 1] == "B")
                        {

                            life -= 3;
                            if (life <= 0)
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow][currCol + 1] = "X";
                                currCol++;
                                break;
                            }
                            else
                            {
                                var a = jagged[currRow][currCol];
                                jagged[currRow][currCol] = "-";
                                jagged[currRow][currCol + 1] = a;
                                currCol++;
                            }
                        }
                        else if (jagged[currRow][currCol + 1] == "P")
                        {
                            life--;
                            var a = jagged[currRow][currCol];
                            jagged[currRow][currCol] = "-";
                            jagged[currRow][currCol + 1] = "-";
                            reachThePrinces = true;
                            currCol++;
                            break;
                        }

                    }
                    else
                    {
                        life--;
                        if (life <= 0)
                        {
                            break;
                        }
                    }
                    //foreach (var item in jagged)
                    //{
                    //    Console.WriteLine(String.Join("", item));
                    //}
                }
            }
            if (reachThePrinces == true)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {life}");

            }
            else
            {
                Console.WriteLine($"Mario died at {currRow};{currCol}.");

            }
            foreach (var item in jagged)
            {
                Console.WriteLine(String.Join("", item));
            }
        }
    }
}
