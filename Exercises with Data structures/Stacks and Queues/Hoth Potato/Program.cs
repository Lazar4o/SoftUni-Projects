using System;
using System.Collections.Generic;

namespace Hoth_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>(Console.ReadLine().Split(' '));
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            while (names.Count != 1)
            {
                counter++;
                if (counter == number)
                {
                    Console.WriteLine("Removed " + names.Dequeue());
                    counter = 0;
                    continue;
                }
                string personWithoutHotPotato = names.Dequeue();
                names.Enqueue(personWithoutHotPotato);

            }
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
