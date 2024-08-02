
namespace Leetcode.CSharp.Solutions; 
public class Leetcode2134 {

    // count '1' num, this decide window size x
    // slide the window, if '1' count in the window sufficient x
    // the '0' in the window is the least swap time.
    public int MinSwaps(int[] nums) {

        // boundary case
        
        int totalOnes = nums.Sum();         // '1' count in input array
        if (totalOnes == 0 || totalOnes == nums.Length) return 0;
        int[] circular = [.. nums, .. nums];
        int size = totalOnes;               // window size
        int i = 0;                          // window head index
        int j = size-1;                     // window tail index
        int ones = circular.Take(size).Sum();   // '1' count in window

        int minSwap = size-ones;
        while (j < circular.Length-1) {
            if (circular[i] == 1) ones--;
            i++;
            j++;
            if (circular[j] == 1) ones++;

            if (ones == totalOnes) {
                minSwap = Math.Min(minSwap, size - ones);
            }
        }
        return -1;
    }
}

/*
size = 3
1100111001
    ___
21123
 */