using System;
using System.Collections.Generic;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> dictionray = new Dictionary<string, double[]>();
            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] commandArgs = command.Split();
                string product = commandArgs[0];
                double price = double.Parse(commandArgs[1]);
                int quantity = int.Parse(commandArgs[2]);
                if (!dictionray.ContainsKey(product))
                {
                    dictionray.Add(product, new double[2]);
                    dictionray[product][0] = price;
                    dictionray[product][1] = quantity;
                }
                else
                {
                    dictionray[product][1] += quantity;
                    if (dictionray[product][0] != price)
                    {
                        dictionray[product][0] = price;
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var product in dictionray)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
            }
        }
    }
}
