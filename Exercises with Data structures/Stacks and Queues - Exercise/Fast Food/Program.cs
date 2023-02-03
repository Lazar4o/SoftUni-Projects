using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            if (orders.Count > 0)
            {
                Console.WriteLine(orders.Max());
            }
            while (quantityOfFood > 0 && orders.Count != 0)
            {
                int currentOrder = orders.Peek();
                bool biggerThanZero = quantityOfFood - currentOrder > 0;
                if (biggerThanZero)
                {
                    quantityOfFood -= orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
