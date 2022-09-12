using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public  class Leetcode300 {
        // DP bottom-up
        /*
         * State Transition Equation
         * L[i] 代表至該節點的遞增長度
         * L[i] = max{L[j], j | 0<j<i and A[j]<A[i]}
         */

        // faster (no "new list" cost)
        public int LengthOfLIS(int[] nums) {
            int[] Len = new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++) {

                int count = 0;
                // 0<j<i and A[j]<A[i]
                for (int j = 0; j < i; j++) {
                    if (nums[j] < nums[i]) {
                        count = Math.Max(count, Len[j]);
                    }
                }
                Len[i] = count+1;
            }
            return Len.Max();
        }
        public int LengthOfLIS2(int[] nums) {
            int[] Len = new int[nums.Length];
            Array.Fill(Len, 1);
            for (int i = 1; i < nums.Length; i++) {

                List<int> subproblem = new();
                // 0<j<i and A[j]<A[i]
                for (int j = 0; j < i; j++) {
                    if (nums[j] < nums[i]) {
                        subproblem.Add(Len[j]);
                    }
                }
                if (subproblem.Count > 0) { 
                    Len[i] = subproblem.Max() + 1;
                }
            }
            return Len.Max();
        }
    }
}
