using Leetcode.Common;
namespace Leetcode.Problems {
    public class P103_Binary_Tree_Zigzag_Level_Order_Traversal {

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
            if (root == null) {
                return new List<IList<int>>();
            }
            List<IList<int>> listList = new();
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);
            bool reverse = false;
            while (queue.Count > 0) {
                List<int> list = new();
                int size = queue.Count;
                for (int i = 0; i < size; i++) {
                    TreeNode node = queue.Dequeue();
                    list.Add(node.val);
                    if (node.left != null) {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null) {
                        queue.Enqueue(node.right);
                    }
                }
                reverse = !reverse;
                if (reverse) {
                    list.Reverse();
                }
                listList.Add(list);
            }
            return listList;
        }
    }
}
