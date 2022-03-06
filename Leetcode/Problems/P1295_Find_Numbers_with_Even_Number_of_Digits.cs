using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P1295_Find_Numbers_with_Even_Number_of_Digits {
        public int FindNumbers(int[] nums) {
            int count = 0;
            for (int i = 0; i < nums.Length; i++) {
                int digits = (int)Math.Log10(nums[i]) + 1;
                if (digits % 2 == 0) {
                    count++;
                }

            }
            return count;
        }
    }
}
