﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CashItem : Item
    {
        public CashItem(string key, long value)
        {
            Key = key;
            Value = value;
        }
    }
}
