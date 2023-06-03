using Leetcode.Common;
using Leetcode.Problems;

Leetcode1376 code = new ();

int ans = code.NumOfMinutes(
    7,
    2,
    new int[] {3,2,-1,2,2,1,1},
    new int[] { 0,7,4,2,0,0,0 }
    );
Console.WriteLine(ans);
