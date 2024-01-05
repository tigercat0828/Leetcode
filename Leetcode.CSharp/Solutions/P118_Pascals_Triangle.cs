namespace Leetcode.CSharp.Solutions {
    public class P118_Pascals_Triangle {
        public IList<IList<int>> Generate(int numRows) {
            List<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int> { 1 });
            if (numRows == 1) {
                return result;
            }
            result.Add(new List<int> { 1, 1 });
            if (numRows == 2) {
                return result;
            }

            for (int i = 1; i < numRows - 1; i++) {
                IList<int> row = GenNextRow(result[i]);
                result.Add(row);
            }
            return result;
        }
        private IList<int> GenNextRow(IList<int> row) {
            List<int> newRow = new();
            newRow.Add(1);
            for (int i = 0; i < row.Count - 1; i++) {
                newRow.Add(row[i] + row[i + 1]);
            }
            newRow.Add(1);
            return newRow;
        }
    }
}
