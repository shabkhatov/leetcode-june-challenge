using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day11_Sort_Colors
    {
        public void SortColors(int[] nums)
        {
            QuickSort(nums, 0, nums.Length - 1);
        }

        private void QuickSort(int[] nums, int l, int r)
        {
            if (l < r) {
                int pivotIndex = getPivotIndex(nums, l, r);

                QuickSort(nums, l, pivotIndex-1);
                QuickSort(nums, pivotIndex+1, r);
            }
        }

        private int getPivotIndex(int[] nums, int l, int r)
        {
            Random rnd = new Random();
            int rndIndex = rnd.Next(l, r+1);
            int pivot = nums[rndIndex];
            swap(nums, r, rndIndex);
            int i = l - 1;
            for (int j = l; j <= r-1; j++) {
                if (nums[j] > pivot) {
                    i++;
                    swap(nums, i, j);
                }
            }
            swap(nums, i + 1, r);
            return i + 1;
        }

        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
