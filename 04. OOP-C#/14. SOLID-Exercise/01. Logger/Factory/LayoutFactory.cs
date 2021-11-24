using ConsoleApp1.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Factory
{
    public class LayoutFactory
    {
        public ILayout Create(string type)
        {
            ILayout layout = null;

            if (type == nameof(SimpleLayout))
            {
                layout = new SimpleLayout();
            }
            else if (type == nameof(XmlLayout))
            {
                layout = new XmlLayout();
            }
            else
            {
                throw new ArgumentException("Invalid type");
            }

            return layout;
        }
    }
}
