using System;
using System.Linq;

namespace Substract_Diagonals
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbersToInsert = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] += numbersToInsert[column];
                }
            }
            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                secondaryDiagonal += matrix[row, matrix.GetLength(0) - 1 - row];
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (row == column)
                    {
                        primaryDiagonal += matrix[row, column];
                    }
                }
            }
            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
