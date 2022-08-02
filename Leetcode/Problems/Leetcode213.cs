// House Robber II
namespace Leetcode.Problems {
    public class Leetcode213 {
        int[][] memo;
        int[] nums;
        public int Rob(int[] nums) {
            int size = nums.Length;
            if (size == 1) return nums[0];
            if (size == 2) return Math.Max(nums[0], nums[1]);
            // setup
            this.nums = nums;
            memo = new int[2][];
            memo[0] = new int[size];
            memo[1] = new int[size];
            Array.Fill(memo[0], -1);
            Array.Fill(memo[1], -1);

            return Math.Max(
                DP(0, size - 2),
                DP(1, size - 1)
            );
        }

        public int DP(int i, int j) {
            if (j < i) return 0;
            if (memo[i][j] != -1) return memo[i][j];
            memo[i][j] = Math.Max(
                DP(i, j - 2) + nums[j],
                DP(i, j - 1));

            return memo[i][j];
        }
    }
}
