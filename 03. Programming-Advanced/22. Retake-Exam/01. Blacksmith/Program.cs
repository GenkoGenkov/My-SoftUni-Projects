using System;
using System.Collections.Generic;
using System.Linq;

namespace Guild
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            int broadsword = 0;
            int gladius = 0;
            int katana = 0;
            int sabre = 0;
            int shamshir = 0;

            while (steel.Count > 0 && carbon.Count > 0)
            {
                int st = steel.Peek();
                int cb = carbon.Peek();
                int mix = st + cb;

                if (mix == 70)
                {
                    gladius++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (mix == 80)
                {
                    shamshir++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (mix == 90)
                {
                    katana++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (mix == 110)
                {
                    sabre++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (mix == 150)
                {
                    broadsword++;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else
                {
                    steel.Dequeue();
                    cb += 5;
                    carbon.Pop();
                    carbon.Push(cb);
                }
            }

            if (broadsword + gladius + katana + sabre + shamshir > 0)
            {
                Console.WriteLine($"You have forged {broadsword + gladius + katana + sabre + shamshir} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steel.Sum() > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }
            else
            {
                Console.WriteLine($"Steel left: none");
            }

            if (carbon.Sum() > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }
            else
            {
                Console.WriteLine($"Carbon left: none");
            }

            if (broadsword > 0)
            {
                Console.WriteLine($"Broadsword: {broadsword}");
            }

            if (gladius > 0)
            {
                Console.WriteLine($"Gladius: {gladius}");
            }

            if (katana > 0)
            {
                Console.WriteLine($"Katana: {katana}");
            }

            if (sabre > 0)
            {
                Console.WriteLine($"Sabre: {sabre}");
            }

            if (shamshir > 0)
            {
                Console.WriteLine($"Shamshir: {shamshir}");
            }
        }
    }
}
