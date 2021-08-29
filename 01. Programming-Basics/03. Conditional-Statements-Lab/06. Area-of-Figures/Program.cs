using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();


            if (figure == "square")
            {
                double numOne = double.Parse(Console.ReadLine());
                double square = Math.Round(numOne * numOne, 3);
                Console.WriteLine(square);
            }
            else if (figure == "rectangle")
            {
                double numOne = double.Parse(Console.ReadLine());
                double numTwo = double.Parse(Console.ReadLine());
                double rectangle = Math.Round(numOne * numTwo, 3);
                Console.WriteLine(rectangle);
            }
            else if (figure == "circle")
            {
                double numOne = double.Parse(Console.ReadLine());

                double circle = Math.Round(Math.PI * numOne * numOne, 3);
                Console.WriteLine(circle);
            }
            else if (figure == "triangle")
            {
                double numOne = double.Parse(Console.ReadLine());
                double numTwo = double.Parse(Console.ReadLine());
                double triangle = Math.Round(numOne * numTwo / 2, 3);
                Console.WriteLine(triangle);
            }
        }
    }
}
