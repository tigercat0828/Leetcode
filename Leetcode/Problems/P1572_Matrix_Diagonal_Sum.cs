namespace Leetcode.Problems {
    internal class P1572_Matrix_Diagonal_Sum {

        // o(n)
        public int DiagonalSum(int[][] mat) {
            int sum = 0;
            int n = mat.Length;
            for (int i = 0; i < n; i++) {
                sum += mat[i][i];
            }
            for (int i = 0; i < n; i++) {
                sum += mat[i][n - i - 1];
            }
            // minus the duplicate mid term
            if (n % 2 == 1) {
                int m = n / 2;
                sum -= mat[m][m];
            }
            return sum;
        }
        // O(n^2)
        public int DiagonalSum2(int[][] mat) {
            int sum = 0;
            int n = mat.Length;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == j || i + j == n - 1)
                        sum += mat[i][j];
                }
            }
            return sum;
        }
    }
}
