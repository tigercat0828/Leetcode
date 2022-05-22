using Leetcode.Common;
using Leetcode.Problems;
int col = 5;



int[] vs = new int[] { 6,1,2,4,6,3,7,2,8,9};
Array.Sort(vs, (a,b)=>b.CompareTo(a));
Console.WriteLine(string.Join(',', vs));
Utility.GenerateProblemString();

