using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string input = Console.ReadLine();
            string reversed = string.Join("", input.Reverse());
            Console.WriteLine(reversed);*/
            char[] array = Console.ReadLine().ToCharArray();
            Stack<char> stack = new Stack<char>();
            foreach (var character in array)
            {
                stack.Push(character);
            }
            foreach (var sentence in stack)
            {
                Console.Write(sentence);
            }
        }
    }
}
