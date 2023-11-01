﻿using Leetcode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Problems; 
public class Leetcode501 {
    Dictionary<int, int> dict = new();
    public int[] FindMode(TreeNode root) {
        List<int> modes = new();
        PreOrder(root);
        int maxNum = 0;
        foreach (var item in dict) {
            maxNum = Math.Max(maxNum, item.Value);
        }

        foreach (var item in dict) {
            if(item.Value == maxNum)
        }
        return modes.ToArray();
    }
    private void PreOrder(TreeNode root) {
        if(dict.ContainsKey(root.val)) {
            dict[root.val]++;
        }
        else {
            dict.Add(root.val, 1);
        }
        if(root.left != null) {
            PreOrder(root.left);
        }
        if(root.right != null) { 
            PreOrder(root.right);
        }
    }
}
