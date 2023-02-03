using System;
using System.Linq;

namespace Creating_A_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rowsLenght = rowsCols[0];
            int colsLenght = rowsCols[1];
            int[,] matrix = new int[rowsLenght, colsLenght];
            int totalSum = 0;
            for (int row = 0; row < rowsLenght; row++)
            {
                int[] numbersToMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < colsLenght; col++)
                {
                    matrix[row, col] = numbersToMatrix[col];
                    totalSum += numbersToMatrix[col];
                }
            }
            Console.WriteLine(rowsLenght);
            Console.WriteLine(colsLenght);
            Console.WriteLine(totalSum);
        }
    }
}
