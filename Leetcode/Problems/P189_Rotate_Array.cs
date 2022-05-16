namespace Leetcode.Problems {
    public class P189_Rotate_Array {
        // P189_Rotate_Array
        public class Solution {
            // space O(n)
            // time O(n)
            public void Rotate(int[] nums, int k) {

                int len = nums.Length;
                int[] result = new int[len];
                for (int i = 0; i < len; i++) {
                    int ni = (i + k) % len;
                    result[ni] = nums[i];
                }
                Array.Copy(result, 0, nums, 0, len);
            }
        }
    }
}
