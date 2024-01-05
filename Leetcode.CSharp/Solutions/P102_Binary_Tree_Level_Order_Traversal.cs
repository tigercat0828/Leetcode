using Leetcode.CSharp.Common;

namespace Leetcode.CSharp.Solutions {
    public class P102_Binary_Tree_Level_Order_Traversal {

        public IList<IList<int>> LevelOrder(TreeNode root) {
            if (root == null) {
                return new List<IList<int>>();
            }
            List<IList<int>> listList = new();
            Queue<TreeNode> queue = new();
            int count = 1;
            queue.Enqueue(root);
            while (queue.Count > 0) {
                List<int> list = new List<int>();
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
                listList.Add(list);
            }
            return listList;
        }
    }
}
