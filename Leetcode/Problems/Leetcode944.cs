using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class Leetcode944 {
        public int MinDeletionSize(string[] strs) {
            int faultColumn = 0;
            for (int j = 0; j < strs[0].Length; j++) {
                for (int i = 1; i < strs.Length; i++) {
                    if (strs[i - 1][j] > strs[i][j]) {
                        faultColumn++;
                        break;
                    }
                }
            }
            return faultColumn;  // all column are sorted
        }
    }
}
