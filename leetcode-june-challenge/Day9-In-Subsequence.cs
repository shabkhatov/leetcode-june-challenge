using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day9_In_Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            int j = 0;
            for (int i = 0; j < s.Length && i < t.Length; i++)
            {
                if (s[j] == t[i])
                {
                    j++;
                }
            }

            return j == s.Length;
        }
    }
}
