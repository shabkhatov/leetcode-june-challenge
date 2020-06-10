using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day10_Search_Insert_Position
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (target > nums[nums.Length - 1] || target < nums[0])
                return target < nums[0] ? 0 : nums.Length;
            int l = 0, r = nums.Length - 1;
            while (l < r) {
                int mid = l + (r - l) / 2;
                if (nums[mid] >= target)
                {
                    r = mid;
                }
                else
                    l = mid+1;
            }
            return l;
        }
    }
}
