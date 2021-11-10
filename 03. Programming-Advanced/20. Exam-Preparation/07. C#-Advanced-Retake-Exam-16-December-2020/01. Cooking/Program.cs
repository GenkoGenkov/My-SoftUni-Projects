using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPie = 0;

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                if (liquids.Peek() + ingredients.Peek() == 25)
                {
                    bread++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (liquids.Peek() + ingredients.Peek() == 50)
                {
                    cake++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (liquids.Peek() + ingredients.Peek() == 75)
                {
                    pastry++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else if (liquids.Peek() + ingredients.Peek() == 100)
                {
                    fruitPie++;
                    liquids.Dequeue();
                    ingredients.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    ingredients.Push(ingredients.Pop() + 3);
                }
            }

            if (bread > 0 && cake > 0 && pastry > 0 && fruitPie > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");
        }
    }
}

