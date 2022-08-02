namespace Leetcode.Problems {
    public class Leetcode746 {

        private int[] memo;
        private int[] cost;
        public int MinCostClimbingStairs(int[] cost) {
            // top down approach 
            this.cost = cost;
            int n = cost.Length;
            memo = new int[n];
            Array.Fill(memo, int.MaxValue);
            memo[0] = 0;
            memo[1] = 0;
            return Math.Min(    // call h(n) will out of index
                dp(n - 1) + cost[n - 1],
                dp(n - 2) + cost[n - 2]);
        }
        private int dp(int n) {
            // one step
            if (memo[n] != int.MaxValue) {
                return memo[n];
            }
            // dp[i] 到第i階所需的cost
            // dp[i+1] = dp[i] + cost[i] -> 走一步

            int oneStep = dp(n - 1) + cost[n - 1];
            int twoStep = dp(n - 2) + cost[n - 2];
            memo[n] = Math.Min(oneStep, twoStep);
            return memo[n];
        }
    }
}
