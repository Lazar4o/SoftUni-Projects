using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            FamilyList = new List<Person>();
        }
        public List<Person> FamilyList { get; set; }
        public void AddMember(Person person)
        {
            FamilyList.Add(person);
        }
        public Person GetOldestPerson()
        {
            Person oldestPerson = FamilyList.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestPerson;

            //return FamilyList.Max();
        }
    }
}
