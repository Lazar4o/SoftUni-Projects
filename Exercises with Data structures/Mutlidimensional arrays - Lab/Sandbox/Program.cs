using System;
using System.Linq;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[num][];
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] consoleNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[consoleNumbers.Length];
                for (int column = 0; column < jaggedArray[row].Length; column++)
                {
                    jaggedArray[row][column] = consoleNumbers[column];
                }
            }
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int numOfArray = int.Parse(commandArgs[1]);
                int numOfElement = int.Parse(commandArgs[2]);
                if (action == "Add")
                {
                    int numToAdd = int.Parse(commandArgs[3]);
                    if (numOfArray >= 0 && numOfArray < jaggedArray.Length &&
                        numOfElement >= 0 && numOfElement < jaggedArray[numOfArray].Length)
                    {
                        jaggedArray[numOfArray][numOfElement] += numToAdd;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (action == "Subtract")
                {
                    int numToSubtract = int.Parse(commandArgs[3]);
                    if (numOfArray >= 0 && numOfArray < jaggedArray.Length &&
                        numOfElement >= 0 && numOfElement < jaggedArray[numOfArray].Length)
                    {
                        jaggedArray[numOfArray][numOfElement] -= numToSubtract;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int column = 0; column < 1; column++)
                {
                    Console.WriteLine(string.Join(" ", jaggedArray[row]));
                }
            }
        }
    }
}
