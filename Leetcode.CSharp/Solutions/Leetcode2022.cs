using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Solutions {
    public class Leetcode2022 {
        public int[][] Construct2DArray(int[] original, int m, int n) {

            if (m*n>original.Length) return [];

            int[][] matrix = new int[m][];
            for (int i = 0; i < m; i++) {
                matrix[i] = new int[n];
            }
            for (int i = 0; i < original.Length; i++) {
                int row = i/m;
                int col = i%n;
                matrix[row][col] = original[i];
            }
            return matrix;
        }
    }
}
