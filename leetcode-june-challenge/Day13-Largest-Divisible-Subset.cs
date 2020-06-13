using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day13_Largest_Divisible_Subset
    {
        public IList<int> LargestDivisibleSubset(int[] nums)
        {
            if (nums.Length == 0) return new List<int>();
            int n = nums.Length;
            int[] dp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++) {
                dp[i] = 1;
            }

            Array.Sort(nums);

            for (int i = 1; i < n; i++) {
                for (int j = 0; j < i; j++) {
                    if (nums[i] % nums[j] == 0) {
                        dp[i]  = Math.Max(dp[i], dp[j]+1);
                    }
                }
            }
            var result = new List<int>();
            int maxIndex = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                maxIndex = dp[i] > dp[maxIndex] ? i : maxIndex; // step 3 pick the index of the largest element in count.
            }

            int temp = nums[maxIndex];
            int currentCount = dp[maxIndex];
            for (int i = maxIndex; i >= 0; i--)
            {
                if (temp % nums[i] == 0 && dp[i] == currentCount)
                {
                    result.Add(nums[i]); // step 4 from nums[maxIndex] to 0, add every element belongs to the largest subset.
                    temp = nums[i];
                    currentCount--;
                }
            }
            return result;
        }
    }
}
