namespace Leetcode.Problems {
    public class P70_Climbing_Stairs {
        // iterative
        public int ClimbStairs(int n) {
            if (n <= 3) return n;
            int A = 2;    // N2
            int B = 3;    // N3
            int C = 0;
            for (int i = 4; i <= n; i++) {
                C = A + B;
                A = B;
                B = C;
            }
            return C;
        }
        // recursive with memo
        int[] memo = new int[46];
        public int ClimbStarirs2(int n) {
            Array.Fill(memo, -1);
            memo[0] = 0;
            memo[1] = 1;
            memo[2] = 2;
            memo[3] = 3;
            return climb(n);
        }
        public int climb(int n) {

            if (n <= 3) return n;
            if (memo[n] != -1) return memo[n];
            memo[n] = climb(n - 1) + climb(n - 2);
            return memo[n];
        }
    }
}
