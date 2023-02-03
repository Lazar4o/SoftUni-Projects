using System;
using System.Collections.Generic;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int openBracketIndex = stack.Pop();
                    int closedBracketIndex = i;
                    Console.Write(input.Substring(openBracketIndex, closedBracketIndex - openBracketIndex + 1) + " = ");
                }
            }
        }
    }
}
