namespace Leetcode.Problems {
    public class Leetcode300 {
        // O(n^2)
        int LengthOfLIS(int[] nums) {
            int len = nums.Length;
            int[] result = new int[len];
            Array.Fill(result, 1);
            int max = 1;
            for (int i = 1; i < len; i++) {
                for (int j = 0; j < i; j++) {
                    if (nums[j] < nums[i]) {
                        result[i] = Math.Max(result[i], result[j] + 1);
                        max = Math.Max(max, result[i]);
                    }
                }
            }
            return max;
        }
    }
}