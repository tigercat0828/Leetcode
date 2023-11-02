﻿using Leetcode.CSharp.Common;

namespace Leetcode.CSharp.Problems; 
public class Leetocde1161 {
    public int MaxLevelSum(TreeNode root) {
        // do level order
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        int maxSum = int.MinValue;
        int maxLevel = 0;
        int level = 0;
        while (queue.Any()) {
            int levelCount = queue.Count();
            int sum = 0;
            level++;
            for (int i = 0; i < levelCount; i++) {
                TreeNode pop = queue.Dequeue();
                sum += pop.val;
                if (pop.left != null) queue.Enqueue(pop.left);
                if (pop.right != null) queue.Enqueue(pop.right);
            }
            if (sum > maxSum) {
                maxSum = sum;
                maxLevel = level;
            }
            
        }
        return maxLevel;
    }
}
