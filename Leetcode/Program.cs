using Leetcode;
using Leetcode.Problems;
using static System.Console;



Test(new int[] {400});

void Test(int[] nums) {
    P1299_Replace_Elements_with_Greatest_Element_on_Right_Side problem = new();
    problem.ReplaceElements(nums);
    Console.WriteLine(string.Join(',', nums));

}

