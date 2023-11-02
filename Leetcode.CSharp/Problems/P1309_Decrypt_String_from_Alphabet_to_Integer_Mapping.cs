namespace Leetcode.CSharp.Problems {
    public class P1309_Decrypt_String_from_Alphabet_to_Integer_Mapping {

        public string FreqAlphabets(string s) {
            string result = "";
            int code;
            // read from right to left
            int i = s.Length - 1;
            while (i >= 0) {
                if (s[i] == '#') {
                    code = s[i - 1] - '0' + 10 * (s[i - 2] - '0') + 96;
                    i -= 3;
                }
                else {
                    code = s[i] - '0' + 96;
                    i--;
                }
                result += (char)code;
            }
            var charArr = result.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
    }
}
