

namespace Leetcode.CSharp.Solutions; 
public class Leetcode1460 {
    public bool CanBeEqual(int[] target, int[] arr) {

        if(target.Length != arr.Length) return false;
        // len : 1 ~ 1000
        int[] dictT = new int[1000];
        int[] dictA = new int[1000];

        for (int i = 0; i < target.Length; i++) {
            dictT[target[i]]++;
            dictA[arr[i]]++;
        }
        for (int i = 0; i < 1000; i++) {
            if (dictA[i] != dictT[i]) return false;
        }
        return true;
    }
}
