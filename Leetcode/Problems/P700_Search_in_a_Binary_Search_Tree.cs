using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Common;
namespace Leetcode.Problems {
    public class P700_Search_in_a_Binary_Search_Tree {

        // iterative
        public TreeNode SearchBST(TreeNode root, int val) {
            if (root == null) return null;
            TreeNode current = root;
            while (current != null) {
                if (val > current.val ) { 
                    current = current.right;
                    continue;
                }
                if (val < current.val  ) {
                    current = current.left;
                    continue;
                }
                if(current.val == val) {
                    return current;
                }
            }
            return current;
        }
        // recursive
        public TreeNode SearchBST2(TreeNode root, int val) {
            if(root == null) return null;
            if(val > root.val){
                SearchBST2(root.right, val);
            }
            if(val < root.val) {
                SearchBST2(root.left, val);
            }
            return root;
        }
    }
}
