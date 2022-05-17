namespace Leetcode.Problems {
    public class Node {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val, Node _left, Node _right, Node _next) {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public class P116_Populating_Next_Right_Pointers_in_Each_Node {
        public Node Connect(Node root) {
            // corner case
            if (root == null) return null;
            connect(root);
            return root;
        }
        // recursive
        public void connect(Node root) {
            if (root.left != null && root.right != null) {
                // connect brother
                root.left.next = root.right;
                // connect cousin

                if (root.next != null) {
                    root.right.next = root.next.left;
                }

                Connect(root.left);
                Connect(root.right);
            }
        }
        // iterative
        // Time O(n) levelOrder Traversal
        // Space O(n)
        public Node Connect2(Node root) {
            if (root == null) return null;
            List<List<Node>> levelList = new List<List<Node>>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count > 0) {
                int size = queue.Count;
                List<Node> list = new List<Node>();
                for (int i = 0; i < size; i++) {
                    Node pop = queue.Dequeue();
                    list.Add(pop);
                    if (pop.left != null) {
                        queue.Enqueue(pop.left);
                    }
                    if (pop.right != null) {
                        queue.Enqueue(pop.right);
                    }
                }
                levelList.Add(list);
            }
            foreach (var level in levelList) {
                for (int i = 0; i < level.Count - 1; i++) {
                    level[i].next = level[i + 1];
                }
            }
            return root;
        }
    }
}
