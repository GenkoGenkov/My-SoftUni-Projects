﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Stealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Spy spy = new Spy();

            string result = spy.CollectGettersAndSetters("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}
