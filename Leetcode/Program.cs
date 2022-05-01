using Leetcode;
using Leetcode.Common;
using Leetcode.Problems;
using System.Collections;
using static System.Console;




public class Solution {
    // O(n)
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int[] Nums = new int[m+n];
        int i = 0;
        int j = 0;
        int k = 0;
        while(i <  m&& j < n) {
            if (nums1[i] < nums2[j]) {
                Nums[k++] = nums1[i++];
            }
            else {
                Nums[k++] = nums2[j++];
            }
        }
        // add remain part
        while (i < m) {
            Nums[k++] = nums1[i++];
        }
        while (j < n) { 
            Nums[k] = nums2[j++];
        }
        Array.Copy(Nums, nums1, Nums.Length);
    }

}