namespace Leetcode.CSharp.Solutions {
    public class Leetcode1480 {
        public int[] RunningSum(int[] nums) {
            for (int i = 1; i < nums.Length; i++) {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}
