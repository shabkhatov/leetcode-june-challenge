using System;
using System.Collections.Generic;

namespace leetcode_june_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day7_Coin_Change_2().Change(5, new int[] { 2, 5 });
            Console.WriteLine($"{result}");
        }
    }
}
