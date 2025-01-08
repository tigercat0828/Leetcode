namespace Leetcode.CSharp.Solutions;

public class Leetcode2381 {
    public string ShiftingLetters(string s, int[][] shifts) {
        int[] shiftSum = new int[s.Length];
        foreach (var shift in shifts) {
            int from = shift[0];
            int to = shift[1];
            int direction = shift[2];
            for (int i = from; i <= to; i++) {
                if (direction == 0) {
                    // backward
                    shiftSum[i]--;
                }
                else if (direction == 1) {
                    // forward
                    shiftSum[i]++;
                }
            }
        }
        Console.WriteLine(string.Join("", shiftSum));
        
        char[] str = s.ToCharArray();
        for (int i = 0; i < str.Length; i++) {
            str[i] = Cast(str[i], shiftSum[i]);
        }
        return new string(str);
    }
    private char Cast(char c, int shift) {
        if (shift > 0) {
            shift %= 26;    
        }
        if (shift < 0) {    // process negative round
            shift = 26-((-shift)%26);
        }
        c = (char)(c + shift);
        return c;
    }
}