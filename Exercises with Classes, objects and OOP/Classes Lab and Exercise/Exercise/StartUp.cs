using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                Person person = new Person(commandArgs[0], int.Parse(commandArgs[1]));
                family.AddMember(person);
            }
            var sortedListOfPeople = family.FamilyList.Where(p => p.Age > 30).OrderBy(p => p.Name);
            foreach (var item in sortedListOfPeople)
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
            //Person oldestPerson = family.GetOldestPerson();
            //Console.WriteLine(oldestPerson.Name + " " + oldestPerson.Age);
        }
    }
}
