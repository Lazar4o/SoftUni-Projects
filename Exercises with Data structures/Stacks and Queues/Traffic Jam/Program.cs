using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsToPass = int.Parse(Console.ReadLine());
            int totalCarsPassed = 0;
            Queue<string> cars = new Queue<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
                    break;
                }
                if (command == "green")
                {
                    //totalCarsPassed += cars.Count;
                    for (int i = 0; i < numberOfCarsToPass; i++)
                    {
                        if (cars.Count != 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            totalCarsPassed++;
                        }
                    }
                    continue;
                }
                cars.Enqueue(command);
            }
        }
    }
}
