using Leetcode.Common;

Console.WriteLine('9' - '0');

Utility.GenerateProblemString();

public class MyQueue {

    Stack<int> stack;
    Stack<int> tmp;
    public MyQueue() {
        stack = new Stack<int>();
        tmp = new Stack<int>();
    }

    public void Push(int x) {
        stack.Push(x);
    }

    public int Pop() {
        while (stack.Count > 0) {
            tmp.Push(stack.Pop());
        }
        int pop = tmp.Pop();
        while (tmp.Count > 0) {
            stack.Push(tmp.Pop());
        }
        return pop;
    }

    public int Peek() {
        while (stack.Count > 0) {
            tmp.Push(stack.Pop());
        }
        int peek = tmp.Peek();
        while (tmp.Count > 0) {
            stack.Push(tmp.Pop());
        }
        return peek;
    }

    public bool Empty() {
        return stack.Count == 0;
    }
}