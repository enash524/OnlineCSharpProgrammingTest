﻿using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace EvensAndOdds.ConsoleApp
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            // Read input from stdin and provide input before running
            var line1 = System.Console.ReadLine().Trim();
            var N = Int64.Parse(line1);
            var cases = new List<long>();

            for (var i = 0; i < N; i++)
            {
                cases.Add(Int64.Parse(System.Console.ReadLine().Trim()));
            }

            // Process the list of cases generated by the code above.
            // sample code for writing to console: System.Console.WriteLine("Hello World!\n");
            foreach(long input in cases)
            {
                var arr = input.ToString().ToCharArray();
                var even = arr.Where(a => (Int32)char.GetNumericValue(a) % 2 == 0).Count();
                var odd = arr.Where(a => (Int32)char.GetNumericValue(a) % 2 == 1).Count();

                if (even % 2 == 0 && odd % 2 == 1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}