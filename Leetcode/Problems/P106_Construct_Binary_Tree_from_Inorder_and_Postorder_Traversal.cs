using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P106_Construct_Binary_Tree_from_Inorder_and_Postorder_Traversal {
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
        public TreeNode BuildTree(int[] inorder, int[] postorder) {
            throw new NotImplementedException();
        }
        private TreeNode MakeNode(int left, int mid, int right, int[] inorder) {
            throw new NotImplementedException();
        }
    }
}
