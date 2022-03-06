using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P977_Squares_of_a_Sorted_Array {
        public int[] SortedSquares(int[] nums) {
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = nums[i] * nums[i];
            }

            Array.Sort(nums);
            return nums;
        }
    }
}
