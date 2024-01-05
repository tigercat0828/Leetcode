﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Problems; 
public class Leetcode455 {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int indexG = 0;
        int indexS = 0;
        int assignedCookies = 0;
        while (indexG < g.Length && indexS < s.Length) {
            if (g[indexG] <= s[indexS]) {
                indexS++;
                indexG++;
                assignedCookies++;
            }
            else {
                indexS++;
            }
        }
        return assignedCookies;
    }
}
