using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.Name = "Peter";
            person1.Age = 20;
            Person person2 = new Person("George", 18);
            Person person3 = new Person("Jose", 43);

            Family family = new Family();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person();
                person.Name = s[0];
                person.Age = int.Parse(s[1]);
                family.AddMember(person);
            }

            Person oldestPerson = new Person();
            oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
