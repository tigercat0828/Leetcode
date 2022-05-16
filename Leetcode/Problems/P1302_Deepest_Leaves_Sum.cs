using Leetcode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {

    // O(n) node of the root, BFS
    public class P1302_Deepest_Leaves_Sum {
        public int DeepestLeavesSum(TreeNode root) {

            if(root == null) return 0;

            int sum = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                int size = queue.Count;
                sum = 0;
                for (int i = 0; i < size; i++) {
                    TreeNode pop = queue.Dequeue();
                    sum += pop.val;

                    if (pop.left != null) { 
                        queue.Enqueue(pop.left);
                    }
                    if (pop.right != null) { 
                        queue.Enqueue(pop.right);
                    }
                }
                
            }
            return sum;
        }
    }
}
