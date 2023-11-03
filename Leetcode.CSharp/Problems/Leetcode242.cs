﻿namespace Leetcode.CSharp.Problems {
    public class Leetcode242 {
        // O(n)
        public bool IsAnagram(string s, string t) {
            int[] dictS = new int[26];
            int[] dictT = new int[26];
            foreach (char ch in s) {
                dictS[ch - 'a']++;
            }
            foreach (char ch in t) {
                dictT[ch - 'a']++;
            }
            for (int i = 0; i < dictS.Length; i++) {
                int sc = dictS[s[i] - 'a'];
                int tc = dictT[t[i] - 'a'];
                if (sc != tc) {
                    return false;
                }
            }
            return true;
        }
    }
}