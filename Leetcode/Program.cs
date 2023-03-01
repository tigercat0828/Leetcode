using Leetcode.Common;
using Leetcode.Problems;
Leetcode912 leetcode912 = new Leetcode912();

int[] nums = Utility.RandomIntegerArray(300,1,10);

leetcode912.SortArray(nums);
foreach (int num in nums) {
    Console.Write (num + " ");
}

