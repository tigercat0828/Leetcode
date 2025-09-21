using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Solutions {
    public class Leetcode2028 {
        public int[] MissingRolls(int[] rolls, int mean, int n) {
            int throws = rolls.Length + n;
            int points = throws * mean;
            int missPoints = points - rolls.Sum();

            if (missPoints <= 0 || (float)missPoints /n > 6 || missPoints < n) return [];

            int[] answer = new int[n];

            int baseValue = missPoints / n;
            int remainder = missPoints % n;

            Array.Fill(answer, baseValue);
            for (int i = 0; i < remainder; i++) {
                answer[i]++;
            }
            return answer;
        }
    }
}
