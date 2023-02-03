using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hashset = new HashSet<string>();
            int queries = int.Parse(Console.ReadLine());
            for (int i = 0; i < queries; i++)
            {
                string name = Console.ReadLine();
                hashset.Add(name);
            }
            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
        }
    }
}
