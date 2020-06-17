using System;
using System.Collections.Generic;

namespace leetcode_june_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            new Day17_Surrounded_Regions().Solve(
                new char[][]{ 
                    new char[] { 'O', 'O'},
                    new char[] {'O', 'O'}
                }
            );
        }
    }
}
