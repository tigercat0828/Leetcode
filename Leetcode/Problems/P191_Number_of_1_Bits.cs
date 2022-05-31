namespace Leetcode.Problems {
    public class P191_Number_of_1_Bits {
        public int HammingWeight(uint n) {
            int count = 0;
            while (n > 0) {
                count += (int)(n & 1);
                n = n >> 1;
            }
            return count;
        }
    }
}
