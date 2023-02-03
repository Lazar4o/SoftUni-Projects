using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person person;

            if (age < 0)
            {
                throw new Exception();
            }
            else if (age > 15)
            {
                person = new Person(name, age);
            }
            else
            {
                person = new Child(name, age);
            }
            Console.WriteLine(person.GetType() + person.ToString());
        }
    }
}
