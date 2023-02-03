using System;
using System.Collections.Generic;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> brackets = new Stack<char>();
            string sequence = Console.ReadLine();
            bool bracketsMatch = true;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (bracketsMatch == false)
                {
                    Console.WriteLine("NO");
                    return;
                }
                char currentElement = sequence[i];
                if (currentElement == '{' || currentElement == '[' || currentElement == '(')
                {
                    brackets.Push(currentElement);
                }
                else
                {
                    if (brackets.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    char checkBracket = brackets.Pop();
                    if (checkBracket == '(' && currentElement == ')')
                    {
                        bracketsMatch = true;
                    }
                    else if (checkBracket == '[' && currentElement == ']')
                    {
                        bracketsMatch = true;
                    }
                    else if (checkBracket == '{' && currentElement == '}')
                    {
                        bracketsMatch = true;
                    }
                    else
                    {
                        bracketsMatch = false;
                    }
                }

            }
            Console.WriteLine("YES");
        }
    }
}
