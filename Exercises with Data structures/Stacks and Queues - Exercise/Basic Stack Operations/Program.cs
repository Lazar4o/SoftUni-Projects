using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commandNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int integersToPop = commandNumbers[1];
            int isNumPresented = commandNumbers[2];
            for (int i = 0; i < integersToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Contains(isNumPresented) ? "true" : stack.Min());
                //compile time error - can be fixed by using IF's to check ^
                //                                                         |
            }
        }
    }
}
