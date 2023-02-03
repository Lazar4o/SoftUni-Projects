using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowCol[0], rowCol[1]];
            FillingMatrix(matrix);
            int maxSquareSum = int.MinValue;
            int maxSquareCol = 0;
            int maxSquareRow = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 2; column++)
                {
                    int currentSum = matrix[row, column] + matrix[row, column + 1] +
                        +matrix[row, column + 2] + matrix[row + 1, column] +
                        +matrix[row + 2, column] + matrix[row + 1, column + 1] +
                        +matrix[row + 2, column + 2] + matrix[row + 1, column + 2] + 
                        +matrix[row + 2, column + 1];

                    if (currentSum > maxSquareSum)
                    {
                        maxSquareSum = currentSum;
                        maxSquareCol = column;
                        maxSquareRow = row;
                    }
                }
            }
            Console.WriteLine("Sum = " + maxSquareSum);
            for (int row = maxSquareRow; row <= maxSquareRow + 2; row++)
            {
                for (int col = maxSquareCol; col <= maxSquareCol + 2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillingMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] insertNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = insertNumbers[column];
                }
            }
        }
    }
}
