using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day2_Delete_Node_In_Linked_List
    {
        public void DeleteNode(ListNode node)
        {
            var nextNode = node.next;
            var prevNode = node;

            int[] arr = new int[] { 4, 5, 1, 9 };
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] != node.val) {
                    Console.Write($"{ arr[i]} ");
                }
            }
        }
    }
}
