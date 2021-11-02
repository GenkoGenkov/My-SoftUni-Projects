using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace SetCover
{
    using System.Collections.Generic;
    class StartUp
    {
        static void Main(string[] args)
        {
            List<int> universe = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            List<int[]> sets = new List<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] set = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                sets.Add(set);
            }

            var result = ChooseSets(sets, universe);

            Console.WriteLine($"Sets to take ({result.Count}):");

            foreach (var item in result)
            {
                Console.WriteLine($"{{ {string.Join(", ", item)} }}");
            }
        }

        public static List<int[]> ChooseSets(IList<int[]> sets, IList<int> universe)
        {
            List<int[]> result = new List<int[]>();

            while (sets.Count > 0 && universe.Count > 0)
            {
                int[] largestSubset = sets.OrderByDescending(set => set.Count(el => universe.Contains(el))).FirstOrDefault();

                foreach (var item in largestSubset)
                {
                    universe.Remove(item);
                }

                result.Add(largestSubset);
                sets.Remove(largestSubset);
            }

            return result;
        }
    }
}