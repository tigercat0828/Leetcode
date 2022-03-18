using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P144_Binary_Tree_Preorder_Traversal {
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
        public IList<int> PreorderTraversal(TreeNode root) {
            if(root == null) {
                return new List<int>();
            }
            List<int> list = new();
            Stack<TreeNode> stack = new();
            stack.Push(root);
            while (stack.Count > 0) {
                TreeNode node = stack.Pop();
                list.Add(node.val);
                if (node.right != null) {
                    stack.Push(node.right);
                }
                if (node.left != null) {
                    stack.Push(node.left);
                }
            }
            return list;
        }
        // recursion
        public IList<int> PreorderTraversal2(TreeNode root) {
            List<int> list = new List<int>();
            PreOrder(root, list);
            return list;
        }
        private void PreOrder(TreeNode root, List<int> list) {
            if (root != null) {
                list.Add(root.val);
                PreOrder(root.left, list);
                PreOrder(root.right, list);
            }
        }
    }
}
