using System;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[rowCols[0], rowCols[1]];
            string input = Console.ReadLine();
            bool isLeftToRight = true;
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (isLeftToRight)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] += input[counter++];
                        if (counter == input.Length)
                        {
                            counter = 0;
                        }
                    }
                    isLeftToRight = false;
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] += input[counter++];
                        if (counter == input.Length)
                        {
                            counter = 0;
                        }
                    }
                    isLeftToRight = true;
                }
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
