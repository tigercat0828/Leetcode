﻿namespace Leetcode.CSharp.Solutions; 
public class Leetcode1588 {
    // Brute Force o(n^3)
    public int SumOddLengthSubarrays(int[] arr) {
        int sum = 0;
        int t = 0;
        while (2 * t <= arr.Length) {
            int i = 0;
            int j = 2 * t;
            Console.WriteLine($"t = {t}");
            while (j < arr.Length) {
                Console.WriteLine($"{i}, {j}");
                for (int k = i; k <= j; k++) {
                    sum += arr[k];
                }
                i++;
                j++;
            }
            t++;
        }
        return sum;
    }
}
