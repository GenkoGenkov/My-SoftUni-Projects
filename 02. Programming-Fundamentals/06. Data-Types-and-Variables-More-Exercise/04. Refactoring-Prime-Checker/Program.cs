using System;
using System.Linq;



namespace GamingStore
{
    class GameStore
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 2; i <= n; i++)
            {
                string prime = "true";

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = "false";
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {prime}");
            }

        }

        private static bool TOLower(bool v)
        {
            throw new NotImplementedException();
        }
    }
}