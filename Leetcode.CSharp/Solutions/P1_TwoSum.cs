namespace Leetcode.CSharp.Solutions {
    public class P1_TwoSum {
        // O(n)
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) {
                if (dict.ContainsKey(nums[i])) {
                    int a = dict[nums[i]];
                    int b = i;
                    return new int[] { a, b };
                }
                if (!dict.ContainsKey(target - nums[i])) {
                    dict.Add(target - nums[i], i);
                }
            }
            return null; // Not found;
        }
        // O(n^2)
        public int[] TwoSum2(int[] nums, int target) {
            for (int i = 0; i < nums.Length; i++) {
                for (int j = i; j < nums.Length; j++) {
                    if (i != j && nums[i] + nums[j] == target) {
                        return new[] { i, j };
                    }
                }
            }
            return null; // Not found;
        }
    }

}
