using System;
using System.Linq;

namespace NthMostRare.ConsoleApp
{
    public static class Rare
    {
        public static int NthMostRare(int[] elements, int n)
        {
            return elements
                .GroupBy(e => e)
                .Select(i => new { i.Key, Count = i.Count() })
                .OrderBy(o => o.Count)
                .ElementAt(n - 1)
                .Key;
        }

        public static void Main(string[] args)
        {
            int x = NthMostRare(new int[] { 5, 4, 3, 2, 1, 5, 4, 3, 2, 5, 4, 3, 5, 4, 5 }, 2);
            Console.WriteLine(x);
        }
    }
}
