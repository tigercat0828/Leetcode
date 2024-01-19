using Leetcode.CSharp.Common;

namespace Leetcode.CSharp.Solutions {
    public class Leetcode98 {
        public bool IsValidBST(TreeNode root) {
            return check(root, long.MinValue, long.MaxValue);
        }
        private bool check(TreeNode root, long min, long max) {
            if (root == null) return true;
            if (root.val <= min || root.val >= max) return false;
            bool left = check(root.left, min, root.val);
            bool right = check(root.right, root.val, max);
            return left && right;
        }
    }
}
