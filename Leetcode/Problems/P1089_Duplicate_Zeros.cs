using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P1089_Duplicate_Zeros {
        public void DuplicateZeros(int[] arr) {
            int index = 0;
            while (index < arr.Length) {
                if (arr[index] == 0) {
                    ShiftRight(arr, index);
                    index += 2;
                }
                else {
                    index++;
                }
            }
        }
        public void ShiftRight(int[] arr, int index) {
            for (int i = arr.Length - 1; i > index; i--) {
                arr[i] = arr[i - 1];
            }
        }
    }
}
