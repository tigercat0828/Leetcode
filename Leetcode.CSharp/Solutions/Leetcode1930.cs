namespace Leetcode.CSharp.Solutions;
public class Leetcode1930 {
    string str;
    public int CountPalindromicSubsequence(string s) {
        // check(a), check(b), ... , check(z)
        str = s;
        HashSet<char> letters = [];
        foreach (char c in s) {
            letters.Add(c);
        }
        int sum = 0;
        foreach (var c in letters) {
            sum += Count(c);
        }
        return sum;
    }
    private int Count(char c) {
        // search from head
        int head = -1;
        int tail = -1;
        for (int i = 0; i<str.Length; i++) {
            if (str[i] == c) {
                head = i;
                break;
            }
        }
        // search from tail
        for (int i = str.Length-1; i>=0; i--) {
            if (str[i] == c) {
                tail = i;
                break;
            }
        }
        if (tail - head < 2) return 0;
        HashSet<char> visited = [];
        for (int i = head+1; i<tail; i++) {
            visited.Add(str[i]);
        }
        return visited.Count;
    }
}
