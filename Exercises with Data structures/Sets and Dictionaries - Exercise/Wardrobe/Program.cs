using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(" -> ");
                string colour = commandArgs[0];
                string clothes = commandArgs[1];
                string[] clothesArgs = clothes.Split(",");
                for (int j = 0; j < clothesArgs.Length; j++)
                {
                    if (!dictionary.ContainsKey(colour))
                    {
                        dictionary[colour] = new Dictionary<string, int>();
                        dictionary[colour].Add(clothesArgs[j], 1);
                        continue;
                    }
                    if(!dictionary[colour].ContainsKey(clothesArgs[j]))
                    {
                        dictionary[colour].Add(clothesArgs[j], 1);
                    }
                    else //dictionary[colour].ContainsKey(clothesArgs[j])
                    {
                        dictionary[colour][clothesArgs[j]]++;
                    }
                }
            }
            string[] specificCloth = Console.ReadLine().Split();
            foreach (var (key, dict) in dictionary)
            {
                Console.WriteLine($"{key} clothes:");
                foreach (var (innerKey, innerValue) in dict)
                {
                    if (key == specificCloth[0] && innerKey == specificCloth[1])
                    {
                        Console.WriteLine($"* {innerKey} - {innerValue} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {innerKey} - {innerValue}");
                }
            }
        }
    }
}
