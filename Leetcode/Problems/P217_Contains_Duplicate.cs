using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P217_Contains_Duplicate {
        public bool ContainsDuplicate(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) {
                if (!dict.ContainsKey(nums[i])) {
                    dict.Add(nums[i], 1);
                }
                else {
                    dict[nums[i]]++;
                }
            }
            foreach (var item in dict) {
                if (item.Value > 1) {
                    return true;
                }
            }
            return false;
        }
    }

}
