namespace Leetcode.CSharp.Solutions;

public class Leetcode3042 {
    public int CountPrefixSuffixPairs(string[] words) {
        
        int ans = 0;
        for (int i = 0; i < words.Length; i++) {
            for (int j = i+1; j < words.Length; j++) {
                string a = words[i];
                string b = words[j];
                if (b.StartsWith(a) && b.EndsWith(a)) {
                    ans++;
                }
            }
        }
        return ans;
    }
}