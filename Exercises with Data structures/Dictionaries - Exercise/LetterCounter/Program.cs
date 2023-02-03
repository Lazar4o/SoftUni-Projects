using System;
using System.Linq;
using System.Collections.Generic;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            for (int i = 0; i < array.Length; i++)
            {
                string givenWord = array[i];

                for (int j = 0; j < givenWord.Length; j++)
                {
                    char letter = givenWord[j];

                    if (!dictionary.ContainsKey(letter))
                    {
                        dictionary.Add(letter, 1);
                    }
                    else
                    {
                        dictionary[letter] += 1;
                    }
                }
            }

            foreach (var letter in dictionary)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
