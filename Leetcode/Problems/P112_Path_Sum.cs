using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P112_Path_Sum {
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
        int targetsum;
        public bool HasPathSum(TreeNode root, int targetSum) {
            this.targetsum = targetSum;
            return Sum(root, 0);
        }

        public bool Sum(TreeNode root, int sum) {
            // validate
            if (root == null) {
                return false;
            }
            sum += root.val;
            // leaf node 
            if(root.left == null && root.right == null) {
                if (sum == targetsum) {
                    return true;
                }
                return false;
            }
            bool right = false;
            bool left = false;
            if (root.left != null) {
                left = Sum(root.left, sum);
            }
            if (root.right != null) {
                right = Sum(root.right, sum);
            }
            return right || left;
        }
        
    }

}
