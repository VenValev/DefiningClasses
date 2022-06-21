using System;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main()
        {
            Person person1 = new Person();
            person1.Name = "Peter";
            person1.Age = 20;
            Person person2 = new Person("George", 18);
            Person person3 = new Person("Jose", 43);
        }
    }
}
