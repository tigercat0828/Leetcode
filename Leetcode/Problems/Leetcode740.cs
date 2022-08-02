// Delete and Earn 
namespace Leetcode.Problems {
    public class Leetcode740 {

        int[] memo;
        int[] price;
        public int DeleteAndEarn(int[] nums) {
            // counting

            price = new int[nums.Last() + 1];
            memo = new int[nums.Last()+1];
            Array.Fill(memo, -1);
            // turn into 198 House Robber
            for (int i = 0; i < nums.Length; i++) {
                price[nums[i]] += nums[i] ;
            }
            
            return DP(nums.Last());
        }
        private int DP(int i) {
            if(i<0) return 0;
            if(memo[i] != -1) return memo[i];
            memo[i] = Math.Max(DP(i - 1), DP(i - 2) + price[i]);
            return memo[i];
        }
    }
}
