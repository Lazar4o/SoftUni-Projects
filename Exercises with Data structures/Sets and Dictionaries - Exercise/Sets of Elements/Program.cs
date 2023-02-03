using System;
using System.Collections.Generic;

namespace Problem_2._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> firstMatchNumbers = new HashSet<int>();
            HashSet<int> secondMatchNumbers = new HashSet<int>();
            HashSet<int> matchedNumbers = new HashSet<int>();
            string[] command = Console.ReadLine().Split();
            int firstSet = int.Parse(command[0]);
            int secondSet = int.Parse(command[1]);
            for (int i = 0; i < firstSet; i++)
            {
                int checkAutenticity = int.Parse(Console.ReadLine());
                firstMatchNumbers.Add(checkAutenticity);
            }
            for (int i = 0; i < secondSet; i++)
            {
                int checkAutenticity = int.Parse(Console.ReadLine());
                secondMatchNumbers.Add(checkAutenticity);
            }
            foreach (int firstNumbers in firstMatchNumbers)
            {
                foreach (int secondNumbers in secondMatchNumbers)
                {
                    if (secondNumbers == firstNumbers)
                    {
                        matchedNumbers.Add(firstNumbers);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", matchedNumbers));
        }
    }
}
