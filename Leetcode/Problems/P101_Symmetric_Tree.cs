using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Common;
namespace Leetcode.Problems {
    public class P101_Symmetric_Tree {
        public bool IsSymmetric(TreeNode root) {
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root.left);
            queue.Enqueue(root.right);
            while (queue.Count > 0) {
                TreeNode left = queue.Dequeue();
                TreeNode right = queue.Dequeue();
                if(left == null && right == null) {
                    continue;
                }
                if ((left == null && right != null) ||
                    (left != null && right == null)) {
                    return false;
                }
                if (left.val != right.val) {
                    return false;
                }
                queue.Enqueue(left.left);
                queue.Enqueue(right.right);
                queue.Enqueue(left.right);
                queue.Enqueue(right.left);
            }
            return true;
        }
        public bool IsSymmetric2(TreeNode root) { 
            return recurive(root.left, root.right);
        }

        public bool recurive(TreeNode left, TreeNode right) {
            if (left == null && right == null) {
                return true;
            }
            // left=null, right!= null or left!=null, right=null
            if (left == null || right == null) {
                return false;
            }
            if (left.val != right.val) {
                return false;
            }
            return recurive(left.left, right.right) && recurive(left.right, right.left);
        }
    }

}


