using Leetcode.Common;

namespace Leetcode.Problems {
    public class P617_Merge_Two_Binary_Trees {
        public TreeNode MergeTrees(TreeNode A, TreeNode B) {
            if (A == null) return B;
            if (B == null) return A;
            TreeNode root = new TreeNode(A.val + B.val);
            root.left = Merge(A.left, B.left);
            root.right = Merge(A.right, B.right);
            return root;
        }

        public TreeNode MergeTrees2(TreeNode root1, TreeNode root2) {
            // edge case
            if (root1 == null) return root2;
            if (root2 == null) return root1;
            if (root1 == null && root2 == null) return null;
            root1 = Merge(root1, root2);
            return root1;
        }
        private TreeNode Merge(TreeNode A, TreeNode B) {
            // merging

            if (A == null && B == null) {
                return null;
            }
            else if (A != null && B != null) {
                A.val += B.val;
            }
            else if (A == null && B != null) {
                A = new TreeNode(B.val);
            }
            else {  // A != null && B==null
                return A;
            }
            A.left = Merge(A.left, B.left);
            A.right = Merge(A.right, B.right);
            return A;
        }

    }
}
