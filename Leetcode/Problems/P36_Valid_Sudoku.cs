namespace Leetcode.Problems {
    public class P36_Valid_Sudoku {
        // Each row must contain the digits 1-9 without repetition.
        // Each column must contain the digits 1-9 without repetition.
        // Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
        public bool IsValidSudoku(char[][] board) {
            PrintSudoku(board);

            for (int i = 0; i < 9; i++) {
                if (!IsRowValid(board, i)) {
                    return false;
                }
                if (!IsColumnValid(board, i)) {
                    return false;
                }
                if (!IsBoxValid(board, i)) {
                    return false;
                }
            }
            return true;
        }

        private bool IsRowValid(char[][] board, int row) {


            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < 9; i++) {
                char key = board[row][i];
                if (dict.ContainsKey(key)) {
                    dict[key]++;
                }
                else {
                    dict.Add(key, 1);
                }
            }
            foreach (var item in dict) {
                if (item.Value > 1 && item.Key != ',') {
                    return false;
                }
            }
            return true;
        }
        private bool IsColumnValid(char[][] board, int col) {

            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < 9; i++) {
                char key = board[i][col];
                if (dict.ContainsKey(key)) {
                    dict[key]++;
                }
                else {
                    dict.Add(key, 1);
                }
            }
            foreach (var item in dict) {
                if (item.Value > 1 && item.Key != ',') {
                    return false;
                }
            }
            return true;
        }
        private bool IsBoxValid(char[][] board, int box) {

            int row = box / 3 * 3;
            int col = box % 3 * 3;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    char key = board[row + i][col + j];
                    if (dict.ContainsKey(key)) {
                        dict[key]++;
                    }
                    else {
                        dict.Add(key, 1);
                    }
                }
            }
            foreach (var item in dict) {
                if (item.Value > 1 && item.Key != ',') {
                    return false;
                }
            }
            return true;
        }

        private void PrintSudoku(char[][] board) {
            int row = board.Length;
            int col = board[0].Length;
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    Console.Write(board[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
