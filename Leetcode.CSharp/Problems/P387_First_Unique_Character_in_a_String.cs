namespace Leetcode.Problems {
    public class P387_First_Unique_Character_in_a_String {

        class CharNode {
            public int count;
            public int index;
            public CharNode(int c, int i) {
                count = c;
                index = i;
            }
        }

        // Very Clean Code
        public int FirstUniqChar(string s) {
            if (string.IsNullOrEmpty(s)) {
                return -1;
            }
            int[] charDict = new int[26];
            foreach (char c in s) {
                charDict[c - 'a']++;
            }
            for (int i = 0; i < s.Length; i++) {
                if (charDict[s[i] - 'a'] == 1) {
                    return i;
                }
            }
            return -1;
        }
        public int FirstUniqChar2(string s) {
            if (string.IsNullOrEmpty(s)) {
                return -1;
            }

            // count char O(n)
            Dictionary<char, CharNode> dict = new Dictionary<char, CharNode>();
            for (int i = 0; i < s.Length; i++) {
                if (!dict.ContainsKey(s[i])) {
                    dict.Add(s[i], new CharNode(1, i));
                }
                else {
                    char key = s[i];
                    dict[key].count++;
                }
            }

            // select unique char O(n)
            List<CharNode> uniqueChars = new List<CharNode>();
            foreach (var item in dict) {
                if (item.Value.count == 1) {
                    uniqueChars.Add(item.Value);
                }
            }
            if (uniqueChars.Count == 0) {
                return -1;
            }
            // the first char O(n)
            int minIndex = uniqueChars[0].index;
            foreach (var item in uniqueChars) {
                if (item.index < minIndex) {
                    minIndex = item.index;
                }
            }
            return minIndex;
        }
        public int FirstUniqChar3(string s) {
            var uniqueChars = s.Distinct();
            foreach (var ch in uniqueChars) {
                if (s.Count(x => x == ch) == 1) {
                    return s.IndexOf(ch);
                }
            }
            return -1;
        }

    }
}
