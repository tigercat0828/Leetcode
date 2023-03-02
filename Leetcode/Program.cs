using Leetcode.Common;
using Leetcode.Problems;
Leetcode443 leet = new();

int[] nums = Utility.RandomIntegerArray(300, 1, 10);

string str = "aabbbcc";
int ans = leet.Compress(str.ToCharArray());
Console.WriteLine(ans);


