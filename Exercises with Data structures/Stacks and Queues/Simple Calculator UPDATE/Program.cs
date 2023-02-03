using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator_UPDATE
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<string> stack = new Stack<string>(Console.ReadLine().Split().Reverse());
            
            while (stack.Count > 1)
            {
                int firstNumber = int.Parse(stack.Pop());
                string charachter = stack.Pop();
                int secondNumber = int.Parse(stack.Pop());
                stack.Push(@charachter == "+" ? (firstNumber + secondNumber).ToString() : (firstNumber - secondNumber).ToString());
            }
            Console.WriteLine(string.Join("", stack));
        }
    }
}
