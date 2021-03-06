using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var inputTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> materialsForCrafting = new Stack<int>(inputOne);
            Queue<int> magicLevelValues = new Queue<int>(inputTwo);

            Dictionary<int, string> presentsMagicLevel = new Dictionary<int, string>
            {
                { 150, "Doll" },
                { 250, "Wooden train" },
                { 300, "Teddy bear"},
                { 400, "Bicycle" }
            };

            Dictionary<string, int> presentsMade = new Dictionary<string, int>();

            while (materialsForCrafting.Count > 0 && magicLevelValues.Count > 0)
            {
                int magicLevel = materialsForCrafting.Peek() * magicLevelValues.Peek();

                if (presentsMagicLevel.ContainsKey(magicLevel))
                {
                    if (!presentsMade.ContainsKey(presentsMagicLevel[magicLevel]))
                    {
                        presentsMade.Add(presentsMagicLevel[magicLevel], 0);
                    }

                    presentsMade[presentsMagicLevel[magicLevel]]++;

                    materialsForCrafting.Pop();
                    magicLevelValues.Dequeue();
                }
                else
                {
                    if (magicLevel < 0)
                    {
                        int sum = materialsForCrafting.Peek() + magicLevelValues.Peek();

                        materialsForCrafting.Pop();
                        magicLevelValues.Dequeue();
                        materialsForCrafting.Push(sum);
                    }
                    else if (magicLevel > 0)
                    {
                        int material = materialsForCrafting.Peek() + 15;

                        materialsForCrafting.Pop();
                        magicLevelValues.Dequeue();
                        materialsForCrafting.Push(material);
                    }
                    else if (magicLevel == 0)
                    {
                        if (materialsForCrafting.Peek() == 0) 
                        {
                            materialsForCrafting.Pop();
                        }

                        if (magicLevelValues.Peek() == 0)
                        {
                            magicLevelValues.Dequeue();
                        }
                    }
                }
            }

            if ((presentsMade.ContainsKey("Doll") && presentsMade.ContainsKey("Wooden train")) ||(presentsMade.ContainsKey("Teddy bear") && presentsMade.ContainsKey("Bicycle")))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materialsForCrafting.Count > 0)
            {
                Console.WriteLine("Materials left: " + string.Join(", ", materialsForCrafting));
            }

            if (magicLevelValues.Count > 0)
            {
                Console.WriteLine("Magic left: " + string.Join(", ", magicLevelValues));
            }

            foreach (var present in presentsMade.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{present.Key}: {present.Value}");
            }
        }
    }
}

