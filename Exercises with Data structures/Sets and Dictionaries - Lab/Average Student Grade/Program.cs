using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            int queries = int.Parse(Console.ReadLine());
            for (int i = 0; i < queries; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = command[0];
                decimal grade = decimal.Parse(command[1]);
                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                } 
            }
            foreach (var keyValuePair in students)
            {
                Console.Write($"{keyValuePair.Key} -> ");
                Console.WriteLine($"{string.Join(" ", keyValuePair.Value.Select(v => $"{v:f2}"))} (avg: {keyValuePair.Value.Sum() / keyValuePair.Value.Count:F2})");
            }
        }
    }
}
