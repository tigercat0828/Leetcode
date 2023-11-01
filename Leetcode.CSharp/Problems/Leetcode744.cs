namespace Leetcode.Problems {
    public class Leetcode744 {
        public class Solution {
            public char NextGreatestLetter(char[] letters, char target) {
                for (int i = 0; i < letters.Length; i++) {

                    if ((int)target < (int)letters[i]) {
                        return letters[i];
                    }
                }
                return letters[0];
            }
        }
    }
}
