

namespace Leetcode.Problems {
    public class P647_Palindromic_Substrings {
        public int CountSubstrings(string s) {
            int row = s.Length;
            int col = s.Length;
            int[][] matrix = new int[row][];
            for (int i = 0; i < row; i++) { 
                matrix[i] = new int[col];
            }

            int count = 0;
            for (int i = 0; i < row; i++) { // one char palindrome
                matrix[i][i] = 1;
                count++;
            }

            for (int j = 1; j < col; j++) {
                for (int i = 0; i < j; i++) {
                    if (i == j - 1 && s[i] == s[j]) { // right to the diagnal 
                        count++;
                        matrix[i][j] = 1;
                    }
                    else if (s[i] == s[j] && matrix[i + 1][j - 1] == 1) {
                        count++;
                        matrix[i][j] = 1;
                    }
                }
            }
            // PrintMatrix(matrix);
            return count;
        }
        private void PrintMatrix(int[][] matrix) {
            for (int i = 0; i < matrix.Length; i++) {
                Console.WriteLine("[" + string.Join(',', matrix[i]) + "]");
            }
        }


    }
}


/*
   a b c b a b
a [1,0,0,0,1,0]
b [0,1,0,1,0,0]
c [0,0,1,0,0,0]
b [0,0,0,1,0,1]
a [0,0,0,0,1,0]
b [0,0,0,0,0,1]
 
 */
