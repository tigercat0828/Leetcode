<<<<<<< Updated upstream
﻿namespace Leetcode.Problems {
    internal class Leetcode1332 {
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class Leetcode1332 {
        public int RemovePalindromeSub(string s) {

            if (string.IsNullOrEmpty(s)) {
                return 0;
            }
            for (int i = 0; i < s.Length / 2; i++) {
                if (s[i] != s[s.Length - 1 - i]) {
                    return 2;
                }
            }
            return 1;   // is paliondrome
        }
>>>>>>> Stashed changes
    }
}
/*
 s is palindrome =>1
 s is not palindrome
    step1. remove a in s
    step2. remove b in s
    => 2
 */
