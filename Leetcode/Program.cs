using Leetcode.Common;
using Leetcode.Problems;
Leetcode54 code = new();
int[][] matrix = Utility.RandomMatrix(100, 50, 1, 9);
Utility.PrintMatrix(matrix);

code.SpiralOrder(matrix);