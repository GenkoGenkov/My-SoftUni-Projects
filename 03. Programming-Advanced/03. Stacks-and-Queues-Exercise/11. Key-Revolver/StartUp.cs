using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int priceForBullet = int.Parse(Console.ReadLine());
            int sizeOfBarrel = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int money = int.Parse(Console.ReadLine());

            int shootBullets = 0;
            int barrelCounter = sizeOfBarrel;
            int shotsFiredTotal = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {

                shotsFiredTotal++;
                shootBullets++;


                if (bullets.Peek() <= locks.Peek())
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");

                }
                else
                {
                    Console.WriteLine("Ping!");

                }

                bullets.Pop();

                if (shootBullets == sizeOfBarrel && bullets.Count > 0)
                {
                    shootBullets = 0;
                    Console.WriteLine("Reloading!");
                }
            }

            int bulletsCost = shotsFiredTotal * priceForBullet;
            int moneyEarned = money - bulletsCost;

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
