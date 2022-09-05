using System;

namespace ReVolt
{
    public class Program
    {

        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var num1 = int.Parse(Console.ReadLine());
            var matrix = new string[num, num];
            var currRow = 0;
            var currCol = 0;
            var finish = false;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
                    if (matrix[row, col] == "f")
                    {
                        currRow = row;
                        currCol = col;
                    }
                }

            }
            for (int i = 0; i < num1; i++)
            {
                var lines = Console.ReadLine();
                if (lines == "right")
                {
                    if (currCol + 1 < matrix.GetLength(1))
                    {
                        if (matrix[currRow, currCol + 1] != "B" && matrix[currRow, currCol + 1] != "T" && matrix[currRow, currCol + 1] != "F")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "-";
                            matrix[currRow, currCol + 1] = "f";
                            currCol++;
                        }
                        else if (matrix[currRow, currCol + 1] == "B")
                        {
                            if (currCol + 2 < matrix.GetLength(1))
                            {
                                var a = matrix[currRow, currCol];
                                matrix[currRow, currCol] = "-";
                                if (matrix[currRow, currCol + 2] == "F")
                                {
                                    matrix[currRow, currCol + 2] = "f";
                                    finish = true;
                                    break;

                                }
                                else
                                {
                                    matrix[currRow, currCol + 2] = "f";
                                    currCol += 2;
                                }

                            }
                            else
                            {
                                var a = matrix[currRow, currCol];
                                matrix[currRow, currCol] = "-";
                                if (matrix[currRow, 0] == "F")
                                {
                                    finish = true;
                                    break;
                                }
                                else
                                {
                                    matrix[currRow, 0] = a;
                                    currCol = 0;
                                }
                            }

                        }
                        else if (matrix[currRow, currCol + 1] == "F")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "-";
                            matrix[currRow, currCol + 1] = "f";
                            finish = true;
                            break;
                        }

                    }
                    else
                    {

                        var a = matrix[currRow, currCol];
                        matrix[currRow, currCol] = "-";
                        if (matrix[currRow, 0] == "F")
                        {
                            matrix[currRow, 0] = a;
                            finish = true;
                            break;
                        }
                        else
                        {
                            matrix[currRow, 0] = a;
                            currCol = 0;
                        }
                    }
                }
                if (lines == "left")
                {
                    if (currCol - 1 >= 0)
                    {
                        if (matrix[currRow, currCol - 1] != "B" && matrix[currRow, currCol - 1] != "T" && matrix[currRow, currCol - 1] != "F")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "-";
                            matrix[currRow, currCol - 1] = "f";
                            currCol--;
                        }
                        else if (matrix[currRow, currCol - 1] == "B")
                        {
                            if (currCol - 2 >= 0)
                            {
                                var a = matrix[currRow, currCol];
                                matrix[currRow, currCol] = "-";
                                if (matrix[currRow, currCol - 2] == "F")
                                {
                                    matrix[currRow, currCol - 2] = "f";
                                    finish = true;
                                    break;
                                }
                                else
                                {
                                    matrix[currRow, currCol - 2] = "f";
                                    currCol -= 2;
                                }

                            }
                            else
                            {
                                var a = matrix[currRow, currCol];
                                matrix[currRow, currCol] = "-";
                                if (matrix[currRow, matrix.GetLength(1) - 1] == "F")
                                {
                                    finish = true;
                                    break;
                                }
                                else
                                {
                                    matrix[currRow, matrix.GetLength(1) - 1] = a;
                                    currCol = matrix.GetLength(1) - 1;
                                }
                            }
                        }
                        else if (matrix[currRow, currCol - 1] == "F")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "-";
                            matrix[currRow, currCol - 1] = "f";
                            finish = true;
                            break;
                        }

                    }
                    else
                    {

                        var a = matrix[currRow, currCol];
                        matrix[currRow, currCol] = "-";
                        if (matrix[currRow, matrix.GetLength(1) - 1] == "F")
                        {
                            matrix[currRow, matrix.GetLength(1) - 1] = a;
                            currCol = matrix.GetLength(1) - 1;
                            finish = true;
                            break;
                        }
                        else
                        {
                            matrix[currRow, matrix.GetLength(1) - 1] = a;
                            currCol = matrix.GetLength(1) - 1;
                        }

                    }
                }
                if (lines == "down")
                {
                    if (currRow + 1 < matrix.GetLength(0))
                    {
                        if (matrix[currRow + 1, currCol] != "B" && matrix[currRow + 1, currCol] != "T" && matrix[currRow + 1, currCol] != "F")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "-";
                            matrix[currRow + 1, currCol] = "f";
                            currRow++;
                        }
                        else if (matrix[currRow + 1, currCol] == "B")
                        {
                            if (currRow + 2 < matrix.GetLength(0))
                            {
                                var a = matrix[currRow, currCol];
                                matrix[currRow, currCol] = "-";
                                if (matrix[currRow + 2, currCol] == "F")
                                {
                                    matrix[currRow + 2, currCol] = "f";
                                    currRow += 2;
                                    finish = true;
                                    break;
                                }
                                else
                                {
                                    matrix[currRow + 2, currCol] = "f";
                                    currRow += 2;
                                }

                            }
                            else
                            {
                                var a = matrix[currRow, currCol];
                                matrix[currRow, currCol] = "-";
                                if (matrix[0, currCol] == "F")
                                {
                                    finish = true;
                                    break;
                                }
                                else
                                {
                                    matrix[0, currCol] = a;
                                    currRow = 0;
                                }

                            }
                        }
                        else if (matrix[currRow + 1, currCol] == "F")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "-";
                            matrix[currRow + 1, currCol] = "f";
                            finish = true;
                            break;
                        }

                    }
                    else
                    {

                        var a = matrix[currRow, currCol];
                        matrix[currRow, currCol] = "-";
                        if (matrix[0, currCol] == "F")
                        {
                            matrix[0, currCol] = a;
                            currRow = 0;
                            finish = true;
                            break;
                        }
                        else
                        {
                            matrix[0, currCol] = a;
                            currRow = 0;
                        }

                    }
                }
                if (lines == "up")
                {
                    if (currRow - 1 >= 0)
                    {
                        if (matrix[currRow - 1, currCol] != "B" && matrix[currRow - 1, currCol] != "T" && matrix[currRow - 1, currCol] != "F")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "-";
                            matrix[currRow - 1, currCol] = "f";
                            currRow--;
                        }
                        else if (matrix[currRow - 1, currCol] == "B")
                        {
                            if (currRow - 2 >= 0)
                            {
                                var a = matrix[currRow, currCol];
                                matrix[currRow, currCol] = "-";
                                if (matrix[currRow - 2, currCol] == "F")
                                {
                                    matrix[currRow - 2, currCol] = "f";
                                    currRow -= 2;
                                    finish = true;
                                    break;

                                }
                                else
                                {
                                    matrix[currRow - 2, currCol] = "f";
                                    currRow -= 2;
                                }

                            }
                            else
                            {
                                var a = matrix[currRow, currCol];
                                matrix[currRow, currCol] = "-";
                                if (matrix[matrix.GetLength(0) - 1, currCol] == "F")
                                {


                                    finish = true;
                                    break;
                                }
                                else
                                {
                                    matrix[matrix.GetLength(0) - 1, currCol] = a;
                                    currRow = matrix.GetLength(0) - 1;
                                }


                            }
                        }
                        else if (matrix[currRow - 1, currCol] == "F")
                        {
                            var a = matrix[currRow, currCol];
                            matrix[currRow, currCol] = "-";
                            matrix[currRow - 1, currCol] = "f";
                            finish = true;
                            break;
                        }

                    }
                    else
                    {

                        var a = matrix[currRow, currCol];
                        matrix[currRow, currCol] = "-";
                        if (matrix[matrix.GetLength(0) - 1, currCol] == "F")
                        {
                            matrix[matrix.GetLength(0) - 1, currCol] = a;
                            finish = true;
                            break;
                        }
                        else
                        {

                            matrix[matrix.GetLength(0) - 1, currCol] = a;
                            currRow = matrix.GetLength(0) - 1;
                        }

                    }
                }
            }
            if (finish == true)
            {
                Console.WriteLine("Player won!");

            }
            else
            {
                Console.WriteLine("Player lost!");

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
