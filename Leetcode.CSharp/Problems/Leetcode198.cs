// House Robber

namespace Leetcode.CSharp.Problems {
    public class Leetcode198 {
        // DP bottom-up 
        public int Rob(int[] nums) {
            int n = nums.Length;
            if (n == 1) return nums[0];
            if (n == 2) return Math.Max(nums[0], nums[1]);
            int[] DP = new int[n];
            DP[0] = nums[0];
            DP[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < n; i++) {

                DP[i] = Math.Max(
                    DP[i - 2] + nums[i],
                    DP[i - 1]
                );
            }
            return DP[n - 1];
        }
        int[] memo;
        int[] nums;
        // DP top-down
        public int Rob2(int[] nums) {
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
