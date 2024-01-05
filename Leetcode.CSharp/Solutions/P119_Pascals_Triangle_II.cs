namespace Leetcode.CSharp.Solutions {
    public class P119_Pascals_Triangle_II {
        public IList<int> GetRow(int rowIndex) {
            List<int> row2 = new List<int> { 1, 1 };

            return nextRow(row2, 1, rowIndex);
        }
        public List<int> nextRow(List<int> row, int currentRowIndex, int rowIndex) {

            if (rowIndex == 0) {
                return new List<int> { 1 };
            }

            if (currentRowIndex == rowIndex) {
                return row;
            }

            List<int> newRow = new();          // space O(n)
            newRow.Add(1);
            for (int i = 0; i < row.Count - 1; i++) {
                newRow.Add(row[i] + row[i + 1]);
            }
            newRow.Add(1);

            return nextRow(newRow, newRow.Count - 1, rowIndex);
        }
    }
}
