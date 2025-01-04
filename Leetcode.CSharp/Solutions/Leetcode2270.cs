namespace Leetcode.CSharp.Solutions;
public class Leetcode2270 {
    public int WaysToSplitArray(int[] nums) {
        int length = nums.Length;
        long totalSum = 0;

        // Calculate the total sum of the array
        foreach (int num in nums) {
            totalSum += num;
        }

        long prefixSum = 0;
        int answers = 0;

        // Iterate through the array to calculate prefix sum and check the condition
        for (int i = 0; i < length - 1; i++) {
            prefixSum += nums[i];
            long suffixSum = totalSum - prefixSum;

            if (prefixSum >= suffixSum) {
                answers++;
            }
        }

        return answers;
    }
}