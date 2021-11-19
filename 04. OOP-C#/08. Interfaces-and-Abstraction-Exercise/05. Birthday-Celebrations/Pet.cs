using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Pet : ICelebratable 
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; set; }
        public string Birthdate { get; set; }
    }
}
