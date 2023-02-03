
using System;
using System.Linq;

namespace Squares_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowCols[0];
            int columns = rowCols[1];
            string[,] matrix = new string[rows, columns];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] numbersToInsert = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersToInsert[col];
                }
            }
            int totalMatches = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        totalMatches++;
                    }
                }
            }
            Console.WriteLine(totalMatches);
        }
    }
}
