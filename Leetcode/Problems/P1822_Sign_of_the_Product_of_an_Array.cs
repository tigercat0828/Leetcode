using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P1822_Sign_of_the_Product_of_an_Array {
        public int ArraySign(int[] nums) {
            int sign = 1;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 0) return 0;
                if (nums[i] < 0) {
                    sign = -sign;
                }
            }
            return sign;
        }
    }
}
