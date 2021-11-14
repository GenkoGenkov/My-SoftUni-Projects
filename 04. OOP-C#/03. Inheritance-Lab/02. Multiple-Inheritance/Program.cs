using System;
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
            Puppy puppy = new Puppy();

            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}