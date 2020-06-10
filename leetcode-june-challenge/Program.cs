using System;
using System.Collections.Generic;

namespace leetcode_june_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Day10_Search_Insert_Position()
                .SearchInsert(new int[] { 1, 3, 5, 6 }, 2);

            Console.WriteLine($"Result: {result}");
        }
    }
}
