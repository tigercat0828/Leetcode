using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public  class P1346_Check_If_N_and_Its_Double_Exist {
        public bool CheckIfExist(int[] arr) {
            Dictionary<float, float> dict = new();
            for (int i = 0; i < arr.Length; i++) {
                float val = arr[i];
                if (dict.ContainsKey(val)) {
                    return true;
                }
                dict[val * 2] = val;
                dict[val / 2] = val;
            }
            return false;
        }
    }
}
