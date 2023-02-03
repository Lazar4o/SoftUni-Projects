using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var inputArgs = Console.ReadLine().Split();
                var person = new Person(inputArgs[0], inputArgs[1], int.Parse(inputArgs[2]), decimal.Parse(inputArgs[3]));

                persons.Add(person);
            }
            decimal parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(Console.WriteLine);

        }
    }
}