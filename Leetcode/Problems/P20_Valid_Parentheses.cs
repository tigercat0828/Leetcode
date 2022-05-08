namespace Leetcode.Problems {
    public class P20_Valid_Parentheses {
        public bool IsValid(string s) {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++) {
                if (stack.Count == 0) {
                    stack.Push(s[i]);
                }
                else {
                    char top = stack.Peek();
                    char current = s[i];
                    if (top == '[' && current == ']' ||
                        top == '(' && current == ')' ||
                        top == '{' && current == '}') {
                        stack.Pop();
                    }
                    else {
                        stack.Push(current);
                    }
                }
            }
            return stack.Count == 0;
        }
    }
}
