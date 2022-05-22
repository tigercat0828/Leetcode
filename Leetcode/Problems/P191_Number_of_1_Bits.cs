using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public  class P191_Number_of_1_Bits {
        public int HammingWeight(uint n) {
            int count = 0;
            while (n > 0) {
                if (n % 10 == 1) {
                    count++;
                }
                n /= 10;
            }
            return count;
        }
    }
}
