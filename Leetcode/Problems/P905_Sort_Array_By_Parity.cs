using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P905_Sort_Array_By_Parity {
        public int[] SortArrayByParity(int[] nums) {
            int index = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] %2 == 0) {
                    // swap
                    int temp = nums[index];
                    nums[index] = nums[i];
                    nums[i] = temp;

                    index++;
                }
            }
            return nums;
        }
    }
}
