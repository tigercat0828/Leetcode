using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CSharp.Solutions; 
public class Leetcode2678 {
    public int CountSeniors(string[] details) {
        //   0123456789 0 12
        // ["7868190130 M 75 22",
        //  "5303914400 F 92 11",
        //  "9273338290 F 40 10"]
        int validNum = 0;
        foreach (string detail in details) {
            if (!IsValidLength(detail)) continue;
            if (IsSenior(detail)) validNum++;
        }
        return validNum;
    }

    private bool IsValidLength(string detail) {
        return detail.Length < 0 || detail.Length > 10;
    }
    private bool IsSenior(string detail) {
        string ageStr = detail.Substring(11, 1);
        int age = int.Parse(ageStr);
        Console.WriteLine(age);
        return age > 60;
    }
}
