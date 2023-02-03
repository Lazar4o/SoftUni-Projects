using System;
using System.Linq;

namespace FIll_Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int primaryDiagonal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbersToInsert = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] += numbersToInsert[column];
                    if (row == column)
                    {
                        primaryDiagonal += numbersToInsert[column];
                    }
                }
            }
            Console.WriteLine(primaryDiagonal);
        }
    }
}
