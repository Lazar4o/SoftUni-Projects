using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            while (true)
            {
                string nameCommand = Console.ReadLine();
                if (nameCommand == "End")
                {
                    break;
                }
                if (nameCommand == "Paid")
                {
                    while (names.Count != 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                    continue;
                }
                names.Enqueue(nameCommand);
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
