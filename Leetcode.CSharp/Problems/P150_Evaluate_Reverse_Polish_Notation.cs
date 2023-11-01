namespace Leetcode.Problems {
    public class P150_Evaluate_Reverse_Polish_Notation {
        public int EvalRPN(string[] tokens) {
            Stack<int> stack = new Stack<int>();
            List<string> operators = new List<string>(){
            "+", "-", "*", "/"
        };
            for (int i = 0; i < tokens.Length; i++) {
                if (!operators.Contains(tokens[i])) {
                    int num = int.Parse(tokens[i]);
                    stack.Push(num);
                }
                else {
                    int operandB = stack.Pop();
                    int operandA = stack.Pop();
                    int result = 0;
                    switch (tokens[i]) {
                        case "+":
                            result = operandA + operandB;
                            break;
                        case "-":
                            result = operandA - operandB;
                            break;
                        case "*":
                            result = operandA * operandB;
                            break;
                        case "/":
                            result = operandA / operandB;
                            break;
                    }
                    stack.Push(result);
                }
            }
            return stack.Pop();
        }
    }
}
