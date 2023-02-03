using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> supermarkets= new Dictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();
            while (command != "Revision")
            {
                string[] commandArgs = command.Split(", ");
                string market = commandArgs[0];
                string product = commandArgs[1];
                double productPrice = double.Parse(commandArgs[2]);
                if (!supermarkets.ContainsKey(market))
                {
                    supermarkets.Add(market, new Dictionary<string, double>());
                }
                if (!supermarkets[market].ContainsKey(product))
                {
                    supermarkets[market].Add(product, productPrice);
                }
                command = Console.ReadLine();
            }
            foreach (var supermarket in supermarkets.OrderBy(x => x.Key))
            {
                Console.WriteLine(supermarket.Key + "->");
                foreach (var product in supermarket.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
