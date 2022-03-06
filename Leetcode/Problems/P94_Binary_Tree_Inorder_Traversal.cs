using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Common;


namespace Leetcode {
    public class P94_Binary_Tree_Inorder_Traversal {
     
        public IList<int> InorderTraversal(TreeNode root) {
            List<int> list = new List<int>();
            inorder(root, list);
            return list;
        }
        public void inorder(TreeNode root, List<int> list) {
            if (root != null) {
                inorder(root.left, list);
                list.Add(root.val);
                inorder(root.right, list);
            }
        }
    }
}
