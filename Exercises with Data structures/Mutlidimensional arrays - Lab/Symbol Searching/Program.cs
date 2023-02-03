
using System;

namespace Symbol_Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCols = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowCols, rowCols];
            FillMatrix(matrix);
            char symbol = char.Parse(Console.ReadLine());
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    if (symbol == matrix[rows, columns])
                    {
                        Console.WriteLine($"({rows}, {columns})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = symbols[column];
                }
            }
        }
    }
}
