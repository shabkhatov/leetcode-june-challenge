using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day4_Reverse_String
    {
        public void ReverseString(char[] s)
        {
            int n = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                var temp = s[i];
                s[i] = s[n - i];
                s[n - i] = temp;
            }
        }
    }
}
