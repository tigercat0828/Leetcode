

namespace Leetcode.CSharp.Solutions; 
public class Leetcode2441 {
    public int FindMaxK(int[] nums) {
        int max = 0;
        HashSet<int> negatives = [];
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < 0) {
                negatives.Add(nums[i]);
            }
        }
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < 0) continue;
            else if (negatives.Contains(-nums[i])) {
                max = Math.Max(max, nums[i]);
            }
        }
        return max;
    }
}
