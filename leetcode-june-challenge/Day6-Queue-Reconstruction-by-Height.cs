using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day6_Queue_Reconstruction_by_Height
    {
        private static int IntComparator(int[] x1, int[] x2)
        {
            if (x1[0] == x2[0])
            {
                if (x1[1] == x2[1]) return 0;
                return x1[1] > x2[1] ? 1 : -1;
            }
            return x1[0] > x2[0] ? 1 : -1;
        }
        public int[][] ReconstructQueue(int[][] people)
        {
            int[][] result = new int[people.Length][];

            Array.Sort(people, IntComparator);
            foreach (var p in people)
            {
                Console.WriteLine($"{p[0]} - {p[1]}");
                int count = p[1];
                int i = 0;
                while (count > 0)
                {
                    if (result[i] == null || result[i][0] >= p[0])
                        count--;
                    i++;
                }
                while (result[i] != null) i++;
                result[i] = new int[] { p[0], p[1] };
            }

            return result;
        }
    }
}
