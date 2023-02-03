
using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (!dictionary.ContainsKey(currentChar))
                {
                    dictionary.Add(currentChar, 1);
                }
                else
                {
                    dictionary[currentChar]++;
                }
            }
            foreach (var (character, count) in dictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{character}: {count} time/s");
            }
        }
    }
}
