using System;
using System.Linq;
using System.Collections.Generic;

namespace TruffelHunter
{
    internal class Program
    {
        static void Main()
        {

            var num = int.Parse(Console.ReadLine());
            var matrix = new string[num, num];
            var dict = new Dictionary<string, int>();
            var allTruffelsCount = 0;
            var black = 0;
            var white = 0;
            var summer = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var nums = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = nums[col];
                    if (matrix[row, col] != "-")
                    {
                        allTruffelsCount++;
                    }
                }
            }


            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Stop the hunt")
                {
                    break;
                }
                var tokens = line.Split();
                if (tokens[0] == "Collect")
                {
                    var firstRow = int.Parse(tokens[1]);
                    var firstCol = int.Parse(tokens[2]);

                    if (firstRow >= 0 && firstRow < matrix.GetLength(0) && firstCol >= 0 && firstCol < matrix.GetLength(1))
                    {
                        var position = matrix[firstRow, firstCol];
                        if (position == "B")
                        {
                            matrix[firstRow, firstCol] = "-";
                            black++;

                        }
                        else if (position == "S")
                        {
                            matrix[firstRow, firstCol] = "-";
                            summer++;
                        }
                        else if (position == "W")
                        {
                            matrix[firstRow, firstCol] = "-";
                            white++;

                        }

                    }
                }
                if (tokens[0] == "Wild_Boar")
                {
                    var currRow = int.Parse(tokens[1]);
                    var currCol = int.Parse(tokens[2]);
                    var direction = tokens[3];
                    if (direction == "right")
                    {
                        for (int i = currCol; i < matrix.GetLength(1); i++)
                        {

                            if (currCol % 2 == 0)
                            {
                                if (i % 2 == 0)
                                {

                                    matrix[currRow, i] = "-";


                                }

                            }
                            else
                            {
                                if (i % 2 != 0)
                                {

                                    matrix[currRow, i] = "-";


                                }
                            }


                        }
                    }
                    if (direction == "left")
                    {
                        for (int i = currCol; i >= 0; i--)
                        {
                            if (currCol % 2 == 0)
                            {
                                if (i % 2 == 0)
                                {


                                    matrix[currRow, i] = "-";


                                }

                            }
                            else
                            {
                                if (i % 2 != 0)
                                {

                                    matrix[currRow, i] = "-";


                                }
                            }
                        }
                    }
                    if (direction == "down")
                    {
                        for (int i = currRow; i < matrix.GetLength(0); i++)
                        {

                            if (currRow % 2 == 0)
                            {
                                if (i % 2 == 0)
                                {

                                    matrix[i, currCol] = "-";


                                }

                            }
                            else
                            {
                                if (i % 2 != 0)
                                {

                                    matrix[i, currCol] = "-";


                                }
                            }
                        }
                    }
                    if (direction == "up")
                    {
                        for (int i = currRow; i >= 0; i--)
                        {
                            if (currRow % 2 == 0)
                            {
                                if (i % 2 == 0)
                                {

                                    matrix[i, currCol] = "-";


                                }

                            }
                            else
                            {
                                if (i % 2 != 0)
                                {

                                    matrix[i, currCol] = "-";


                                }
                            }
                        }
                    }


                }
            }
            var obshto = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != "-")
                    {
                        obshto++;
                    }
                }

            }
            var area = allTruffelsCount - obshto;
            var area1 = black + white + summer;

            Console.WriteLine($"Peter manages to harvest {black} black, {summer} summer, and {white} white truffles.");
            Console.WriteLine($"The wild boar has eaten {area - area1} truffles.");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();

            }


        }
    }
}

