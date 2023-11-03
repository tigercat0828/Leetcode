using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Problems;
// 1441. Build an Array With Stack Operations
public class Leetcode1441 {
    public IList<string> BuildArray(int[] target, int n) {
        List<string> result = new();
        bool[] isTarget = new bool[n + 1];
        foreach (var t in target) {
            isTarget[t] = true;
        }
        int addedIn = 0;
        for (int i = 1; i <= n; i++) {
            if (isTarget[i]) {
                result.Add("Push");
                addedIn++;
                if (addedIn == target.Length)
                    break;
            }
            else {
                result.Add("Push");
                result.Add("Pop");
            }
        }
        return result;
    }
}


/*
 input: [1,3], n = 3
Output: ["Push","Push","Pop","Push"]
 
 */