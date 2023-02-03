using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            int total = 0;            
            for (int i = 0; i < array.Length; i++)
            {
                stack.Push(array[i]);
            }
            stack.Reverse();
            while (stack.Count != 0)
            {
                if (stack.Peek() == '-')
                {
                    stack.Pop();
                    char negativeNumberChar = stack.Pop();
                    int minusNumber = (int)char.GetNumericValue(negativeNumberChar);
                    total -= minusNumber;
                    continue;
                }
                else if (stack.Peek() == '+')
                {
                    stack.Pop();
                    char positiveNumberChar = stack.Pop();
                    int positiveNumber = (int)char.GetNumericValue(positiveNumberChar);
                    total += positiveNumber;
                    continue;
                }
                char curr = stack.Pop();
                int oneTimeConverter = (int)char.GetNumericValue(curr);
                total += oneTimeConverter;
            }
            Console.WriteLine(total);
        }
    }
}
