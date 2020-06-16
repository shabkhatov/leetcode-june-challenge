using System;
using System.Collections.Generic;

namespace leetcode_june_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Contest().MinSumOfLengths(new int[]{1, 6, 1}, 7);
            Console.WriteLine($"Result: {result}");
        }
    }
}
