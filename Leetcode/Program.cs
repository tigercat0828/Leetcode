using Leetcode.Common;
using Leetcode.Problems;

Utility.GenerateProblemString();

public class Solution {
    public int MaxDepth(TreeNode root) {
        if(root == null) return 0;
        if(root.left == null && root.right == null) return 1;
        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return Math.Max(left, right) + 1;
    }
}




