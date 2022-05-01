using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems {
    public class P739_Daily_Temperatures {
        
        public int[] DailyTemperatures(int[] temperatures) {
            Stack<(int, int)> stack = new Stack<(int, int)>();
            int[] res = new int[temperatures.Length];
            stack.Push((0, temperatures[0]));
            for (int i = 1; i < temperatures.Length; i++) {
                
            }
            return res;
        }
    }
}
