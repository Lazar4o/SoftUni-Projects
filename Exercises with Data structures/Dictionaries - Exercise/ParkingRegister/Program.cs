using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRegistrations = int.Parse(Console.ReadLine());
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string command = string.Empty;

            for (int i = 1; i <= numberOfRegistrations; i++)
            {
                command = Console.ReadLine(); 
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                string name = commandArgs[1];
                if (action == "register")
                {
                    string licensePlate = commandArgs[2];
                    if (!dictionary.ContainsKey(name))
                    {
                        dictionary.Add(name, licensePlate);
                        Console.WriteLine($"{name} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dictionary[name]}");
                    }
                }
                else if (action == "unregister")
                {
                    if (dictionary.ContainsKey(name))
                    {
                        dictionary.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var (name, licensePlate) in dictionary)
            {
                Console.WriteLine($"{name} => {licensePlate}");
            }
        }
    }
}
