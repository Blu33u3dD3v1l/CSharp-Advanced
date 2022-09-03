using System;
using System.Collections.Generic;
using System.Linq;


namespace TruffelHunter
{
    public class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            var matrix = new string[num, num];
            var black = 0;
            var summer = 0;
            var white = 0;
            var boar = 0;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
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
                    int num1 = int.Parse(tokens[1]);
                    int num2 = int.Parse(tokens[2]);
                    if (num1 < matrix.GetLength(0) && num2 < matrix.GetLength(1))
                    {
                        if (matrix[num1, num2] == "S")
                        {
                            matrix[num1, num2] = "-";
                            summer++;
                        }
                        if (matrix[num1, num2] == "B")
                        {
                            matrix[num1, num2] = "-";
                            black++;
                        }
                        if (matrix[num1, num2] == "W")
                        {
                            matrix[num1, num2] = "-";
                            white++;
                        }

                    }


                }
                if (tokens[0] == "Wild_Boar")
                {
                    int n1 = int.Parse(tokens[1]);
                    int n2 = int.Parse(tokens[2]);
                    var direction = tokens[3];
                    if (direction == "right")
                    {
                        for (int i = n2; i < matrix.GetLength(1); i += 2)
                        {
                            if (matrix[n1, i] == "B" || matrix[n1, i] == "S" || matrix[n1, i] == "W")
                            {
                                matrix[n1, i] = "-";
                                boar++;

                            }
                        }
                    }
                    if (direction == "left")
                    {
                        for (int i = n2; i >= 0; i -= 2)
                        {
                            if (matrix[n1, i] == "B" || matrix[n1, i] == "S" || matrix[n1, i] == "W")
                            {
                                matrix[n1, i] = "-";
                                boar++;

                            }
                        }
                    }
                    if (direction == "down")
                    {
                        for (int i = n1; i < matrix.GetLength(0); i += 2)
                        {
                            if (matrix[i, n2] == "B" || matrix[i, n2] == "S" || matrix[i, n2] == "W")
                            {
                                matrix[i, n2] = "-";
                                boar++;

                            }
                        }
                    }
                    if (direction == "up")
                    {
                        for (int i = n1; i >= 0; i -= 2)
                        {
                            if (matrix[i, n2] == "B" || matrix[i, n2] == "S" || matrix[i, n2] == "W")
                            {
                                matrix[i, n2] = "-";
                                boar++;

                            }
                        }
                    }

                }

            }
            Console.WriteLine($"Peter manages to harvest {black} black, {summer} summer, and {white} white truffles.");
            Console.WriteLine($"The wild boar has eaten {boar} truffles.");

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
