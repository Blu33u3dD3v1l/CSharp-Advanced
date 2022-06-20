using System;
using System.Collections.Generic;
using System.Linq;

namespace Survivor
{
    internal class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var matrix = new string[num, num];
            var myTokens = 0;
            var oponentTokens = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col].ToString();
                   
                }
            }
            while (true)
            {
                var line = Console.ReadLine();
                if(line == "Gong")
                {
                    break;
                }
                var tokens = line.Split();
                if (tokens[0] == "Find")
                {
                    var currRow = int.Parse(tokens[1]);
                    var currCol = int.Parse(tokens[2]);
                    if(currRow >= 0 && currRow < matrix.GetLength(0) && currCol >= 0 && currCol < matrix.GetLength(1))
                    {
                        if (matrix[currRow,currCol] == "T")
                        {
                            myTokens++;
                            matrix[currRow, currCol] = "-";

                        }

                        
                    }
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                 
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row,col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                       
            }
        }
    }
}
