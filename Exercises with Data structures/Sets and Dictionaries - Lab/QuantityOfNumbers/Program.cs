using System;
using System.Collections.Generic;
using System.Linq;

namespace QuantityOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> dictionary = new Dictionary<double, int>();
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                double currentNumber = array[i];
                if (!dictionary.ContainsKey(currentNumber))
                {
                    dictionary.Add(currentNumber, 1);
                }
                else
                {
                    dictionary[currentNumber]++;
                }
            }
            foreach ((double number, int count) in dictionary)
            {
                Console.WriteLine($"{number} - {count} times");
            }
        }
    }
}
