using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AddCollection : IAdd
    {
        private List<string> elements;

        public AddCollection()
        {
            elements = new List<string>();
        }

        public int Add(string element)
        {
            elements.Add(element);
            return elements.Count - 1;
        }
    }
}
