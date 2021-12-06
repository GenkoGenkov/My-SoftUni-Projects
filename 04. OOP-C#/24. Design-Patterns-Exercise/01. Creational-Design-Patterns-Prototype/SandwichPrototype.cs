using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class SandwichPrototype
    {
        public abstract SandwichPrototype ShallowCopy();

        public abstract SandwichPrototype DeeoCopy();
    }
}
