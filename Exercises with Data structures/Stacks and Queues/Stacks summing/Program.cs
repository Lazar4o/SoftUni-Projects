using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_summing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 2 3 4
            adD 5 6
            REmove 3
            eNd*/
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < array.Length; i++)
            {
                stack.Push(array[i]);
            }
            while (true)
            {
                string command = Console.ReadLine().ToLower();
                if (command == "end")
                {
                    break;
                }
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                if (action == "add")
                {
                    int numberOne = int.Parse(commandArgs[1]);
                    int numberTwo = int.Parse(commandArgs[2]);
                    stack.Push(numberOne);
                    stack.Push(numberTwo);
                }
                else if (action == "remove")
                {
                    int numbersToRemove = int.Parse(commandArgs[1]);
                    if (stack.Count >= numbersToRemove)
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {                          
                                stack.Pop();                            
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
