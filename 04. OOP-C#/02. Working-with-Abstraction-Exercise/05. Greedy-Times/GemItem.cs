using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class GemItem : Item
    {
        public GemItem(string key, long value)
        {
            Key = key;
            Value = value;
        }
    }
}
