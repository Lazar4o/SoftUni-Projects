using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine()); //number of arrays in array
            var jaggedArray = new double[rows][]; //initialize arrays in array
            for (int row = 0; row < jaggedArray.Length; row++) //inserting numbers in the arrays
            {
                int[] numbersToInsert = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new double[numbersToInsert.Length];
                for (int column = 0; column < numbersToInsert.Length; column++)
                {
                    jaggedArray[row][column] += numbersToInsert[column];
                }
            }

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int column = 0; column < jaggedArray[row].Length; column++)
                    {
                        jaggedArray[row][column] *= 2;
                        jaggedArray[row + 1][column] *= 2;
                    }
                }
                else
                {
                    for (int column = 0; column < jaggedArray[row].Length; column++)
                    {
                        jaggedArray[row][column] /= 2;
                    }
                    for (int column = 0; column < jaggedArray[row + 1].Length; column++)
                    {
                        jaggedArray[row + 1][column] /= 2;
                    }
                }
            }

            string command = Console.ReadLine(); //read command from console
            while (command != "End")
            {
                string[] commandArgs = command.Split(); //splitting command
                string action = commandArgs[0];
                int row = int.Parse(commandArgs[1]);
                int column = int.Parse(commandArgs[2]);
                int value = int.Parse(commandArgs[3]);
                if (action == "Add")
                {
                    if (row >= 0 && row < jaggedArray.Length && column >= 0 && column < jaggedArray[row].Length)
                    {
                        jaggedArray[row][column] += value;
                    }
                }
                else if (action == "Subtract")
                {
                    if (row >= 0 && row < jaggedArray.Length && column >= 0 && column < jaggedArray[row].Length)
                    {
                        jaggedArray[row][column] -= value;
                    }
                }

                command = Console.ReadLine();
            }
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[row]));
            }
        }
    }
}
