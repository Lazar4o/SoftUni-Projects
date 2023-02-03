using System;
using System.Collections.Generic;

namespace UniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> uniqueNames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();
                uniqueNames.Add(username);
            }
            foreach (string username in uniqueNames)
            {
                Console.WriteLine(username);
            }

        }
    }
}
