using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Common;
namespace Leetcode.Problems {
    public class P226_Invert_Binary_Tree {


        public TreeNode InvertTree(TreeNode root) {
            if (root != null) {
                TreeNode temp = root.left;
                root.left = root.right;
                root.right = temp;

                InvertTree(root.left);
                InvertTree(root.right);
            }
            return root;
        }
    }
}
