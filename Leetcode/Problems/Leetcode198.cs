// House Robber

namespace Leetcode.Problems {
    public class Leetcode198 {
        int[] memo;
        int[] nums;
        public int Rob(int[] nums) {
            this.nums = nums;
            int size = nums.Length;
            memo = new int[size];
            Array.Fill(memo, -1);
            if (size == 1) return nums[0];
            memo[0] = nums[0];
            memo[1] = Math.Max(nums[0], nums[1]);
            return dp(size - 1);
        }
        private int dp(int n) {
            if (memo[n] != -1) return memo[n];
            memo[n] = Math.Max(dp(n - 2) + nums[n], dp(n - 1));
            return memo[n];
        }
    }
}
