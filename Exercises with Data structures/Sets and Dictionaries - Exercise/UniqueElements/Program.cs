using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueElements = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                foreach (var item in command)
                {
                    uniqueElements.Add(item);
                }
            }
            foreach (var item in uniqueElements.OrderBy(x => x))
            {
                Console.Write(item + " ");
            }
        }
    }
}
