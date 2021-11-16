using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {
        public Person(string firstname, string lastName, int age)
        {
            FirstName = firstname;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }

    }
}
