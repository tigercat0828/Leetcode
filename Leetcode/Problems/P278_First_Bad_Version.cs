using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P278_First_Bad_Version {
        public int FirstBadVersion(int n) {
            if (n <= 0) {
                return -2; // Input error;
            }
            int left = 1;
            int right = n;
            // minify the check range by half each iterate
            while (left <= right) {

                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid)) {
                    // check older version
                    right = mid - 1;
                }
                else {
                    // check newer version
                    left = mid + 1;
                }
            }
            if (IsBadVersion(left)) return left;
            return -1; // No bad version
        }
        int bad;
        private bool IsBadVersion(int n) {
            return bad == n;
        }
    }
}
