namespace Leetcode.CSharp.Solutions {

    public class Leetcode378 {
        public int KthSmallest(int[][] matrix, int k) {
            int rowSize = matrix.Length;
            int colSize = matrix[0].Length;

            int r = k / colSize;
            int col = k % matrix.Length;
            throw new NotImplementedException();
        }
    }
}
