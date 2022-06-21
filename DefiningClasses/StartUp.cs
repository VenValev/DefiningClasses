using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            /*Family family = new Family();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] sa = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person();
                person.Name = sa[0];
                person.Age = int.Parse(sa[1]);
                family.AddMember(person);
            }
            var s = family.Where(p => p.Age > 30).OrderBy(p => p.Name);

            //Person oldestPerson = new Person();
            //oldestPerson = family.GetOldestMember();

            //Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");*/

            /*int n = int.Parse(Console.ReadLine());
            List<Person> listOfPeople = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] sa = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person();
                person.Name = sa[0];
                person.Age = int.Parse(sa[1]);
                listOfPeople.Add(person);
            }

            var sortedListPeople = listOfPeople.Where(p => p.Age > 30).OrderBy(p => p.Name);

            foreach(Person person in sortedListPeople)
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }*/

            string d1 = Console.ReadLine();
            string d2 = Console.ReadLine();
            DateModifier dateModifier = new DateModifier(d1, d2);

        }
    }
}
