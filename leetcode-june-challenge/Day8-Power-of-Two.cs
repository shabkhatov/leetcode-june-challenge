using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day8_Power_of_Two
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n < 0)
                return false;
            int temp = n, count = 0;
            while (temp >> 1 != 0)
            {
                temp = temp >> 1;
                count++;
            }


            return n == 1 << count;
        }
    }
}
