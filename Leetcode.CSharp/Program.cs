using Leetcode;
using Leetcode.CSharp.Problems;

Leetcode228 code = new ();
int[] nums = new int[] { 0, 1, 2,  4, 5, 7, 8, 9 };
IList<string> ans = code.SummaryRanges(nums);

foreach (var item in ans) {
    Console.WriteLine(item);
}
