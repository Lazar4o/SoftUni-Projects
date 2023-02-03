using System;
using System.Linq;

namespace Math_Operations_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowCols, rowCols];
            FillTheMatrix(matrix);
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int specifiedRow = int.Parse(commandArgs[1]);
                int specifiedColumn = int.Parse(commandArgs[2]);
                if (action == "Add")
                {
                    if (specifiedRow >= 0 && specifiedRow < matrix.GetLength(0) && specifiedColumn >= 0 && specifiedColumn < matrix.GetLength(1))
                    {
                        int numberToAdd = int.Parse(commandArgs[3]);
                        matrix[specifiedRow, specifiedColumn] += numberToAdd;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                if (action == "Subtract")
                {
                    if (specifiedRow >= 0 && specifiedRow < matrix.GetLength(0) && specifiedColumn >= 0 && specifiedColumn < matrix.GetLength(1))
                    {
                        int numberToAdd = int.Parse(commandArgs[3]);
                        matrix[specifiedRow, specifiedColumn] -= numberToAdd;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    Console.Write(matrix[rows, columns] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbersToMatrix = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = numbersToMatrix[column];
                }
            }
        }
    }
}
