using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Problems {
    public  class Leetcode1662 {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
            string str1 = string.Join("",word1);
            string str2 = string.Join("", word2);
            return str1 == str2;
        }
    }
}
