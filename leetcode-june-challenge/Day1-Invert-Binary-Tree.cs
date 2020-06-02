using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day1_Invert_Binary_Tree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            DFS(root);
            return root;
        }

        private void DFS(TreeNode root)
        {
            if (root == null) return;
            DFS(root.left);

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            DFS(root.left);
        }
    }
}
