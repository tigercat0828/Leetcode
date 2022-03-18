using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Common;


namespace Leetcode {
    public class P94_Binary_Tree_Inorder_Traversal {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        // iterative 
        public IList<int> InorderTraversal(TreeNode root) { 
            if(root == null) {
                return new List<int>();
            }
            List<int> result = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            LeftMost(root, stack);
            while (stack.Count > 0) {
                TreeNode current = stack.Pop();
                result.Add(current.val);
                LeftMost(current.right, stack);
            }
            return result;
        }
        private void LeftMost(TreeNode root, Stack<TreeNode> stack) {
            if (root != null) {
                TreeNode current = root;
                while (current != null) {
                    stack.Push(current);
                    current = current.left;
                }
            }
        }

        public IList<int> InorderTraversal2(TreeNode root) {
            List<int> list = new List<int>();
            InOrder(root, list);
            return list;
        }
        public void InOrder(TreeNode root, List<int> list) {
            if (root != null) {
                InOrder(root.left, list);
                list.Add(root.val);
                InOrder(root.right, list);
            }
        }
    }
}
