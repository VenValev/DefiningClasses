using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        //Fields
        private List<Person> olderThan30;
        private List<Person> familyMembers;

        //Constructor

        public Family()
        {
            this.familyMembers = new List<Person>();
            this.olderThan30 = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
            if (member.Age > 30)
            {
                this.olderThan30.Add(member);
            }
        }

        

        public Person GetOldestMember()
        {
            int maxAge = this.familyMembers.Max(member => member.Age);
            return this.familyMembers.First(member => member.Age == maxAge);
        }

    }
}
