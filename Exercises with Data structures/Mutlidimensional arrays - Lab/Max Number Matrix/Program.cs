using System;
using System.Linq;

namespace Max_Number_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[rowCol[0], rowCol[1]];
            FillMatrix(matrix);
            int squareMaxSum = int.MinValue;
            int currentSum = 0;
            int theBiggestRow = 0;
            int theBiggestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row + 1, col] +
                       + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (currentSum > squareMaxSum)
                    {
                        theBiggestRow = row;
                        theBiggestCol = col;
                        squareMaxSum = currentSum;
                    }
                }
            }
            Console.WriteLine($"{matrix[theBiggestRow, theBiggestCol]} {matrix[theBiggestRow, theBiggestCol + 1]}");
            Console.WriteLine($"{matrix[theBiggestRow + 1, theBiggestCol]} {matrix[theBiggestRow + 1, theBiggestCol + 1]}");
            Console.WriteLine(squareMaxSum);
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbersToFill = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersToFill[col];
                }
            }
        }
    }
}
