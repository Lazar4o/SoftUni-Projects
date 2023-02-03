using System;

namespace Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jaggedArray = new long[n][];
            Console.WriteLine(1);
            for (int row = 1; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = new long[row + 1];
                jaggedArray[row][0] = 1;
                jaggedArray[row][jaggedArray[row].Length - 1] = 1;
                for (int column = 0; column < jaggedArray[row].Length - 2; column++)
                {
                    if (row == 1 )
                    {
                        break;
                    }
                    jaggedArray[row][column + 1] = jaggedArray[row-1][column] + jaggedArray[row-1][column + 1];
                }
            }
            for (int row = 1; row < jaggedArray.Length; row++)
            {
                for (int column = 0; column < jaggedArray[row].Length; column++)
                {
                    Console.Write(jaggedArray[row][column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
