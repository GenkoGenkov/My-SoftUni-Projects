using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;


namespace Christmas
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            bool partyStart = false;
            string guest;

            while ((guest = Console.ReadLine()) != "END")
            {
                if (guest == "PARTY")
                {
                    partyStart = true;
                    continue;
                }

                if (partyStart)
                {
                    vip.Remove(guest);
                    regular.Remove(guest);
                }
                else
                {
                    if (char.IsDigit(guest[0]))
                    {
                        vip.Add(guest);
                    }
                    else
                    {
                        regular.Add(guest);
                    }
                }
            }

            Console.WriteLine(vip.Count + regular.Count);

            foreach (var g in vip)
            {
                Console.WriteLine(g);
            }

            foreach (var g in regular)
            {
                Console.WriteLine(g);
            }
        }
    }
}

