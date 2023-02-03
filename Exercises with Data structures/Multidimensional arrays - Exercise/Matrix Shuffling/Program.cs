using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[rowCols[0], rowCols[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] numbersToInsert = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] += numbersToInsert[column];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                if (action == "swap")
                {
                    int row1 = int.Parse(commandArgs[1]);
                    int col1 = int.Parse(commandArgs[2]);
                    int row2 = int.Parse(commandArgs[3]);
                    int col2 = int.Parse(commandArgs[4]);
                    if (row1 >= 0 && row2 >= 0 && row1 < matrix.GetLength(0) && row2 < matrix.GetLength(0) &&
                    col1 < matrix.GetLength(1) && col1 >= 0 &&
                    col2 < matrix.GetLength(1) && col2 >= 0)
                    {
                        string integerToProtect = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = integerToProtect;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int column = 0; column < matrix.GetLength(1); column++)
                            {
                                Console.Write($"{matrix[row, column]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}
