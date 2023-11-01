namespace Leetcode.Problems {
    public class P1051_Height_Checker {
        public int HeightChecker(int[] heights) {
            int fault = 0;

            int len = heights.Length;
            int[] tmp = new int[heights.Length];
            Array.Copy(heights, tmp, len);
            Array.Sort(tmp);
            for (int i = 0; i < len; i++) {
                if (tmp[i] != heights[i]) {
                    fault++;
                }
            }

            return fault;
        }
    }
}
