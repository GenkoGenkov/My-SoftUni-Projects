﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();

            cat.Eat();
            cat.Meow();
        }
    }
}