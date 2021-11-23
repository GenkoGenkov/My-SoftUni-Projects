using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Student
    {
        private string name;
        private string email;

        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Any(c => !char.IsLetter(c)))
                {
                    throw new InvalidPersonNameException("Name should contain only letters.");
                }
                name = value;
            }
        }

        public string Email { get; set; }

    }
}
