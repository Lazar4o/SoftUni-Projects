using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_minimum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < queries; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string action = commandArgs[0];
                if (action == "1")
                {
                    int number = int.Parse(commandArgs[1]);
                    stack.Push(number);
                }
                else if (action == "2" && stack.Count != 0)
                {
                    stack.Pop();
                }
                else if (action == "3" && stack.Count != 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (action == "4" && stack.Count != 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
