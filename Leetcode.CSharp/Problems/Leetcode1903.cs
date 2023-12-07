using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Problems {
    public class Leetcode1903 {
        // Brute Force O(n^2)
        public string LargestOddNumber(string num) {
            int max = 0;
            int i;
            for (i = num.Length - 1; i >= 0; i--)
            {
                int number = num[i]-'0';
                if (number % 2 == 1) break;
            }
            return num.Substring(0, i+1);
        }
    }
}
