using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get 
            { 
                return lenght; 
            }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }

                lenght = value; 
            }
        }
        public double Width
        {
            get 
            { 
                return width; 
            }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }

                width = value; 
            }
        }
        public double Height
        {
            get 
            { 
                return height; 
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }

                height = value; 
            }
        }

        public double SurfaceArea()
        {
            double result = (2 * (lenght * width)) + (2 * (lenght * height)) + (2 * (width * height));

            return result;
        }

        public double LateralSurfaceArea()
        {
            double result = (2 * (lenght * height)) + (2 * (width * height));

            return result;
        }

        public double Volume()
        {
            double result = lenght * width * height;

            return result;
        }
    }
}
