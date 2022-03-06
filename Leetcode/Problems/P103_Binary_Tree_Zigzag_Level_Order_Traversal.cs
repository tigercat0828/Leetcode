using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.Common;
namespace Leetcode.Problems {
    public class P103_Binary_Tree_Zigzag_Level_Order_Traversal {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
            List<IList<int>> listList = new List<IList<int>>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                TreeNode node = queue.Dequeue();
                if(node.right != null) { queue.Enqueue(node.right); }
                if(node.left != null) { queue.Enqueue(node.left); }

            }


            return listList;
        }
    }
}
